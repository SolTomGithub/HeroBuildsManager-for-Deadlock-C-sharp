using Microsoft.Win32;
using ProtoBuf;
using ProtobufDecodeTestDeadlock.Models;
using SteamKit2.GC.Deadlock.Internal;
using SteamKit2.GC.Dota.Internal;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using ValveKeyValue;
using ValveResourceFormat;
using ValveResourceFormat.ResourceTypes;
using ValveResourceFormat.Serialization.KeyValues;
using KVObject = ValveResourceFormat.Serialization.KeyValues.KVObject;
using KVValue = ValveResourceFormat.Serialization.KeyValues.KVValue;

namespace ProtobufDecodeTestDeadlock
{
	//one kv3 file at a time
	public static class HeroBuildsManager
	{
		public static List<(uint, string)> steamUsers = new List<(uint, string)> ();
		public static uint currentSteamUserId = 0;
		private static string kv3Path = "";

		//hero builds
		public static List<CMsgHeroBuild> Favorites = new();
		public static List<CMsgHeroBuild> Unpublished = new();
		public static List<CMsgHeroBuild> SavedLastUsed = new();

		//connects internal character names with build's hero_build_id
		//probably could be used to assign an online build,
		//for example if you were to fetch the best builds for all characters each day and assign them automatically
		public static Dictionary<string, KVValue> LastUsedBuilds = new();

		//user doesn't need to bother themselves with it
		private static BinaryKV3 binaryKV3 = new BinaryKV3(BlockType.DATA) { Resource = new Resource() };
		private static KVObject data = null;

		public static List<heroEntryCSV> heroes = fetchHeroesFromCSV();
		public static List<Models.Item> items = fetchItemsFromJSON();
		public static List<Models.Item> shoppableItems = fetchItemsFromJSON(shoppableOnly: true);

		public enum buildTypes
		{
			Favorites,
			Unpublished,
			SavedLastUsed
		}
		//link types to the list
		//I could also do the build lists themselves work like this but I don't want to make it more confusing for the user
		private static Dictionary<buildTypes, Func<List<CMsgHeroBuild>>> buildTypeToArrayLink = new Dictionary<buildTypes, Func<List<CMsgHeroBuild>>>()
		{
			{ buildTypes.Favorites, () => Favorites },
			{ buildTypes.Unpublished, () => Unpublished},
			{ buildTypes.SavedLastUsed, () => SavedLastUsed }
		};

		//unused, planned to save code in saveBuilds() but simply iterating over allBuildArrays is a better idea
		//private static Dictionary<buildTypes, string> buildTypeToString = new Dictionary<buildTypes, string>()
		//{
		//	{ buildTypes.Favorites, "Favorites" },
		//	{ buildTypes.Unpublished, "Unpublished"},
		//	{ buildTypes.SavedLastUsed, "SavedLastUsed" }
		//};

		//used to quickly iterate over all lists
		private static List<List<CMsgHeroBuild>> allBuildArrays()
		{
			List<List<CMsgHeroBuild>> output = new();
			output.Add(Favorites);
			output.Add(Unpublished);
			output.Add(SavedLastUsed);
			return output;
		}

		private static List<string> buildTypeNames = new List<string>()
		{
			{ "Favorites" },
			{ "Unpublished"},
			{ "SavedLastUsed" }
		};

		
		public static Dictionary<itemTypesEnum, string> itemTypes = new Dictionary<itemTypesEnum, string>()
		{
			{ itemTypesEnum.Weapon, "weapon" },
			{ itemTypesEnum.Vitality, "vitality" },
			{ itemTypesEnum.Spirit, "spirit" }
		};
		public static List<string> itemTypesList = new()
		{
			"weapon",
			"vitality",
			"spirit"
		};
		public static List<int> shoppableItemCosts = new()
		{
			800,
			1600,
			3200,
			6400
		};

		//populate the three lists
		public static void fetchBuildsByPath(string _kv3Path)
		{
			kv3Path = _kv3Path;

			//get the file read
			using var readingStream = File.OpenRead(kv3Path);
			using var reader = new BinaryReader(readingStream);
			binaryKV3.Read(reader);
			readingStream.Close();

			data = binaryKV3.AsKeyValueCollection();

			//getting a dictionary from the kiwi object for the ease of use
			LastUsedBuilds = ((KVObject)data.Properties["LastUsedBuilds"].Value).Properties;
			//three subcollections, we need them because we convert them to byte[] next, unlike LastUsedBuilds
			var     favoritesSubCollection	=	data.GetSubCollection("Favorites");
			var   unpublishedSubCollection	=	data.GetSubCollection("Unpublished");
			var savedLastUsedSubCollection	=	data.GetSubCollection("SavedLastUsed");

			    Favorites = getBuildsFromSubCollection(favoritesSubCollection);
			  Unpublished = getBuildsFromSubCollection(unpublishedSubCollection);
			SavedLastUsed = getBuildsFromSubCollection(savedLastUsedSubCollection);
		}
		//fetch path automatically
		public static void fetchBuilds(string username)
		{
			string steamPathValue = getSteamLocation();
			steamUsers = getSteamIDs(steamPathValue);
			currentSteamUserId = steamUsers.Single(x => x.Item2 == username).Item1;
			kv3Path = steamPathValue += "/userdata/" + currentSteamUserId.ToString() + "/1422450/remote/cfg/cached_hero_builds.kv3";
			fetchBuildsByPath(kv3Path);
		}

		
		public static void saveBuilds(bool inTheSameLocation = true, string locationIfNotSame = "")
		{
			string _kv3Path = "";
			if (inTheSameLocation) _kv3Path = kv3Path;
			else _kv3Path = locationIfNotSame;

			for(int a=0; a<allBuildArrays().Count; a++)
			{
				var buildsKiwiValueArray = new KVObject(buildTypeNames[a], isArray: true);
				for (int b=0; b<allBuildArrays()[a].Count; b++)
				{
					MemoryStream newBuildMemoryStream = new MemoryStream();
					Serializer.SerializeWithLengthPrefix<CMsgHeroBuild>(newBuildMemoryStream, allBuildArrays()[a][b], PrefixStyle.Base128, 1);
					byte[] newBuildBytes = newBuildMemoryStream.ToArray();
					buildsKiwiValueArray.Properties.Add(b.ToString(), new KVValue(KVValueType.BinaryBlob, newBuildBytes));
				}
				data.Properties[buildTypeNames[a]] = new KVValue(KVValueType.Array, buildsKiwiValueArray);
			}
			
			using var writingStream = File.OpenWrite(kv3Path);
			binaryKV3.Serialize(writingStream);
		}


		public static void addBuild(CMsgHeroBuild build, buildTypes type, string commonHeroName = "")
		{
			//check if valid, and only if not search by commonHeroName
			if(!heroes.Select(x=>x.internalId).ToList().Contains(build.hero_id))
			{
				heroEntryCSV heroEntryCSV = heroes.SingleOrDefault(x=>x.commonName == commonHeroName);
				if (heroEntryCSV != null)
				{
					build.hero_id = heroEntryCSV.internalId;
				}
				//might be better to just let it trigger the exception
				//else return;
			}
			int indexOfWorkBuild = buildTypeToArrayLink[type]().FindIndex(x => x.name == build.name);
			
			if (indexOfWorkBuild == -1)
			{
				buildTypeToArrayLink[type]().Add(build);
			}
			else
			{
				buildTypeToArrayLink[type]()[indexOfWorkBuild] = build;
			}
		}
		//returns a hero build id that is unoccupied to the best of it's knowledge
		public static uint getNewBuildID()
		{
			uint output = 10000;
			uint highestTakenId = 0;
			for(int a = 0; a<allBuildArrays().Count; a++)
			{
				for(int b = 0; b<allBuildArrays()[a].Count; b++)
				{
					if (allBuildArrays()[a][b].hero_build_id > highestTakenId) highestTakenId = allBuildArrays()[a][b].hero_build_id;
				}
			}
			output = highestTakenId+1;
			return output;
		}
		public static void setHeroBuildId(string heroName, uint heroBuildId, bool useInternalName = false)
		{
			if(useInternalName) LastUsedBuilds[heroName] = new KVValue(KVValueType.Int32, heroBuildId);
			else LastUsedBuilds[heroes.Single(x=>x.commonName == heroName).internalName] = new KVValue(KVValueType.Int32, heroBuildId);
		}


		public static uint unixTimeNow()
		{
			var time0 = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
			return (uint)time0.TotalSeconds;
		}

		//very likely to crash and burn the whole app down
		public static string getSteamLocation()
		{
			List<(uint, string)> output = new();
			RegistryKey key = null;
			try
			{
				key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Valve\\Steam");
			}
			catch
			{
				try
				{
					key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Valve\\Steam");
				}
				catch
				{
					return null;
				}
			}
			string steamPathValue = key.GetValue("SteamPath").ToString();
			return steamPathValue;
		}
		public static List<(uint, string)> getSteamIDs(string steamLocation)
		{
			string loginUsersVdfPath = steamLocation + "/config/loginusers.vdf";
			//https://github.com/BrianLima/VDFParser Does NOT work here.
			//System.IO.InvalidDataException: 'Invalid header detected. Cannot continue.'
			//List<VDFEntry> vDFEntries = VDFParser.VDFParser.Parse(loginUsersVdfPath).ToList();
			//for (int a=0; a<vDFEntries.Count; a++)
			//{
			//	output.Add(new ValueTuple<uint, string>(1, ""));
			//}
			return parseThatDamnedVdfForSteamIds(File.ReadAllText(loginUsersVdfPath));
		}
		public static Item getItem(string name)
		{
			return HeroBuildsManager.items.Single(x => x.name == name);
		}
		public static heroEntryCSV getHero(string commonName)
		{
			return HeroBuildsManager.heroes.Single(x => x.commonName == commonName);
		}

		private static List<(uint, string)> parseThatDamnedVdfForSteamIds(string input)
		{
			List<(uint, string)> output = new();
			List<char> nonDataChars = new List<char>()
			{
				'{',
				'}',
				'\"',
				'\n'
			};
			int currentDepth = 0;
			bool inString = false;
			bool leftSideString = false;
			bool rightSideString = false;
			string leftSideBuffer = "";
			string rightSideBuffer = "";
			char lastSpecialChar = '\0';
			ValueTuple<uint, string> tempTuple = new ValueTuple<uint, string>();
			for (int a=0; a<input.Length; a++)
			{
				if(input[a] == '{') 
				{
					if (currentDepth == 0) 
					{
						leftSideBuffer = "";
					}
					currentDepth++;
				}
				
				if(input[a] == '\"' && !inString) 
				{
					inString = true;
				}
				else if(input[a] == '\"' && inString) 
				{
					inString = false;
				}
				if(currentDepth>1)
				{
					if(lastSpecialChar == '{') 
					{
						tempTuple.Item1 = (uint)(Convert.ToUInt64(leftSideBuffer) - 76561197960265728);
						leftSideBuffer = "";
					}
					if (lastSpecialChar == '\"' && input[a] == '\"')
					{
						//unnecessary?
						//if(leftSideString)
						//{
						//	inString = false;
						//}
						if (!leftSideString && rightSideBuffer == "") rightSideString = true;
						leftSideString = false;
					}
					if(lastSpecialChar == '\"' && input[a] == '\"' && rightSideString && rightSideBuffer != "")
					{
						//leftSideString = true;
						if(leftSideBuffer == "PersonaName")
						{
							tempTuple.Item2 = rightSideBuffer;
							output.Add(tempTuple);
							tempTuple = new();
						}
						else
						{
							leftSideBuffer = "";
						}
							rightSideBuffer = "";
					}
					if (lastSpecialChar == '\n') 
					{
						leftSideBuffer = "";
						rightSideString = false;
					}
					if(input[a] == '\n') leftSideString = true;

					if(!nonDataChars.Contains(input[a]))
					{
						if(inString)
						{
							if (rightSideString)
							{
								rightSideBuffer += input[a];
							}
							if (leftSideString) leftSideBuffer += input[a];
						}
					}
					else
					{
						lastSpecialChar = input[a];
					}

					
				}
				else
				{
					if(inString && !nonDataChars.Contains(input[a])) leftSideBuffer += input[a];
				}
				if (input[a] == '}') currentDepth--;
			}


			return output;
		}

		private static List<heroEntryCSV> fetchHeroesFromCSV(string filePathCSV = "heroes.csv")
		{
			List<heroEntryCSV> output = new();
			string CSV = File.ReadAllText(filePathCSV);
			List<string> lines = CSV.Split('\n').ToList();
			for(int a=1; a<lines.Count; a++)
			{
				List<string> lineParts = lines[a].Split(',').ToList();
				output.Add(new heroEntryCSV(lineParts[0], lineParts[1], lineParts[2]));
			}
			return output;
		}
		private static List<Models.Item> fetchItemsFromJSON(string filePathJSON = "item_upgrades.json", bool shoppableOnly = false)
		{
			List<Models.Item> output = new();
			string JSON = File.ReadAllText(filePathJSON);
			output = JsonSerializer.Deserialize<List<Models.Item>>(JSON);
			if(shoppableOnly) output = output.Where(x => x.shopable == true).ToList();
			return output;
		}


		//private method exclusively for use in fetchBuilds()
		private static List<CMsgHeroBuild> getBuildsFromSubCollection(KVObject subCollection)
		{
			List<CMsgHeroBuild> builds = new List<CMsgHeroBuild>();
			for (int a = 0; a < subCollection.Count; a++)
			{
				var buildBytes = (byte[])subCollection.First().Value;
				MemoryStream buildMemoryStream = new MemoryStream(buildBytes);

				CMsgHeroBuild build = Serializer.DeserializeWithLengthPrefix<CMsgHeroBuild>(buildMemoryStream, PrefixStyle.Base128, 1);
				builds.Add(build);
			}
			return builds;
		}
	}
	public class heroEntryCSV
	{
		public string commonName = "";
		public string internalName = "";
		public uint internalId = 1;
		public heroEntryCSV(string _commonName, string _internalName, string _internalId)
		{
			commonName = _commonName;
			internalName = _internalName;
			internalId = Convert.ToUInt32(_internalId);
		}
		public heroEntryCSV(string _commonName, string _internalName, uint _internalId)
		{
			commonName = _commonName;
			internalName = _internalName;
			internalId = _internalId;
		}

	}
}
