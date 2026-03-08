using ProtobufDecodeTestDeadlock.Models.ItemDeps;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProtobufDecodeTestDeadlock.Models
{
	public enum itemTypesEnum
	{
		Weapon,
		Vitality,
		Spirit
	}
	public class Item
	{
		public uint id { get; set; }
		public string class_name { get; set; }
		public string name { get; set; }
		public bool start_trained { get; set; }
		public List<object> heroes { get; set; }
		public Properties properties { get; set; }
		public WeaponInfo weapon_info { get; set; }
		public string type { get; set; }
		public string item_slot_type { get; set; }
		public int item_tier { get; set; }
		public Description description { get; set; }
		public string activation { get; set; }
		public List<TooltipSection> tooltip_sections { get; set; }
		public bool is_active_item { get; set; }
		public bool shopable { get; set; }
		public int cost { get; set; }
		public string shop_image { get; set; }
		public string shop_image_webp { get; set; }
		public bool? disabled { get; set; }
		public string image { get; set; }
		public string image_webp { get; set; }
		public List<Upgrade> upgrades { get; set; }
		public List<string> component_items { get; set; }
		public int? update_time { get; set; }
		public string imbue { get; set; }
	}
}
