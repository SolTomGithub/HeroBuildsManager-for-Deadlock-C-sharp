# Hero Builds Manager for Deadlock
I made this project to be able to easily alter my builds from the level of code.
Since the prototype stage everything I could think of was abstracted away to make it easier to use.

## Extent of capabilities
* Automatically searches for Steam's path in system's registry (which you may decide not to do by providing the path yourself) to find loginusers.vdf and use it to get the Steam ID for the username that was given as method's argument. Past the point of knowing your account's display name it's an automatic process.(as long as it works)
* Handles the entire process of reading the KV3 file, decoding the builds (which are saved as a hex blob inside of it) forward and backwards automatically.
* Compatible with all three types of builds (though I doubt anyone will ever use anything but Unpublished) and with multiple builds.
* Many features that make the process of making a build easier, such as having a mapping of heroes and items to their internal names and ids.
* Can set the currently used build, meaning the user will have it set right as they open the game.(given that they have the relevant character chosen by the last time they closed the game, otherwise they will see it once they switch to that character)
* Randomizer included as an example.
* I suspect it might be possible to set an online build as the currently chosen build as long as you have it's Id, but I didn't try myself because I'm simply not interested. It might possibly be used with the API to fetch current top builds and assign them to all characters if it works like this.

## Safety
As far as I can tell it's safe to use. All builds that existed will still exist in the most common usecases unless the user explicitly decides to purge or overwrite them.

## How to use it?
As a word of warning: Project ran as is with no alterations will add a build with randomized items as Victor's currently chosen build. It's not dangerous, just unexpected.
If you look into Program.cs you will see (with lots of comments that mention such things as alternative ways to deal with xyz) an example of how to use this repository in the form of a randomizer.

Generally if you want to use this project, there are three ways:
* detach the Program.cs and compile it as a dll dependency for your project, though I have not tested it
* copy over the code besides Program.cs to your project, and it will work as long as your project has the same dependencies and is on .NET 10.
* for a quick and "dirty" usecase you could just remove the randomizer's code and work on the project as is in it's Program.cs file.

## Credits
First and foremost the packages I've used that made it possible at all:
* SteamKit2(3.4.0)
* ValveResourceFormat(18.0.5805)
* [Deadlock API](https://deadlock-api.com/) for making the [data about items](https://assets.deadlock-api.com/scalar#tag/items/GET/v2/items) easily accessible

If you want to credit me in any way wherever, thanks a lot. I do not require it, but it is very nice.
I'm doing [Youtube](https://www.youtube.com/@SolTomYT) and [streaming](https://www.twitch.tv/soltomtwitch) sometimes so having any kind of additional mentions anywhere is nice.(not that I'm doing anything content-wise with this repo, it's just another small project)
