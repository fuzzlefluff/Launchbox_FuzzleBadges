# Launchbox_FuzzleBadges
An extension plugin that adds a ton of badges for launchbox for things like source versions, platforms, and some misc custom values and tracking. 
Some are simple replacements for existing ones but I wanted my own icon embeded in so I made a duplicate badge.

![Example](img/lbBadgesExample.PNG)
### If you don't want all of these, just recompile it and exclude the classes you don't want (or just turn them off in launchbox)

###### Has some issues with the indexing, seems to be fairly random and Launchbox is ignoring my prescribed values, maybe I have too many on a single index?

## Misc Functional
* **Overwrite Icon for Game Completed**

&emsp;&emsp;&emsp;&emsp;![GoldTrophy](Launchbox_FuzzleBadges/Images/GameCompletedBadge.png)
> Because a gold trophy is better


* **Overwrite Icon for Favorite**

&emsp;&emsp;&emsp;&emsp;![PurpleRibbon](Launchbox_FuzzleBadges/Images/FavoriteBadge.png)
> Purple Ribbons!


* **Overwrite Icon for Installed (needs download)**

&emsp;&emsp;&emsp;&emsp;![NeedsDownload](Launchbox_FuzzleBadges/Images/NeedsDownloadBadge.png)
> Need to download this game!


* **Custom Field "Needs Purchase" == True, display a money sign** 

&emsp;&emsp;&emsp;&emsp;![Purchase](Launchbox_FuzzleBadges/Images/NeedsPurchaseBadge.png)
> This is to keep track of games that I plan to buy in the future


* **Custom Field "100% Completed" == True, display a platinum trophy** 

&emsp;&emsp;&emsp;&emsp;![Platinum](Launchbox_FuzzleBadges/Images/FullyCompletedBadge.png)
> To keep track of the games you platinum


* **Replacement for "New" Badge**

&emsp;&emsp;&emsp;&emsp;![NewGameBadge](Launchbox_FuzzleBadges/Images/PlayedBadge.png)
> Checks to see if the game has a lastplayed value, if its null the badge will display, otherwise it won't, 

> allows for marking several games as played without tediously launching them all by simply setting them all to a last played date



## Pc Source Libraries
![Amazon](Launchbox_FuzzleBadges/Images/AmazonGamesBadge.png)
![Battlenet](Launchbox_FuzzleBadges/Images/BattlenetBadge.png)
![Epic](Launchbox_FuzzleBadges/Images/EpicGamesBadge.png)
![GOG](Launchbox_FuzzleBadges/Images/GoGGalaxyBadge.png)
![Origin](Launchbox_FuzzleBadges/Images/OriginBadge.png)
![Steam](Launchbox_FuzzleBadges/Images/SteamBadge.png)
![Ubisoft](Launchbox_FuzzleBadges/Images/UplayBadge.png)
![Xbox](Launchbox_FuzzleBadges/Images/XboxBadge.png)
* Amazon Games
* Battle.Net/Blizzard App
* Epic Games Store/Epic Games Launcher
* GOG/GOG Galaxy
* Origin
* Steam
* Ubisoft Connect/Uplay
* Xbox Game Pass/Microsoft Store

## Consoles/Portables
![Xbox](Launchbox_FuzzleBadges/Images/XboxConsole.png)
![360](Launchbox_FuzzleBadges/Images/Xbox360Console.png)
![DS](img/dsReduced.png)
![64](Launchbox_FuzzleBadges/Images/Nintendo64Console.png)
![3DS](Launchbox_FuzzleBadges/Images/Nintendo3DSConsole.png)
![NES](img/nesReduced.png)
![GB](Launchbox_FuzzleBadges/Images/NintendoGameboyConsole.png)
![GBC](Launchbox_FuzzleBadges/Images/NintendoGameboyColorConsole.png)
![GBA](Launchbox_FuzzleBadges/Images/NintendoGameboyAdvanceConsole.png)
![GCN](Launchbox_FuzzleBadges/Images/NintendoGamecubeConsole.png)
![NS](Launchbox_FuzzleBadges/Images/NintendoSwitchConsole.png)
![Wii](Launchbox_FuzzleBadges/Images/NintendoWiiConsole.png)
![WiiU](Launchbox_FuzzleBadges/Images/NintendoWiiUConsole.png)
![PS](Launchbox_FuzzleBadges/Images/SonyPlaystationConsole.png)
![PS2](Launchbox_FuzzleBadges/Images/SonyPlaystation2Console.png)
![PS3](Launchbox_FuzzleBadges/Images/SonyPlaystation3Console.png)
![PS4](Launchbox_FuzzleBadges/Images/SonyPlaystation4Console.png)
![PSP](Launchbox_FuzzleBadges/Images/SonyPSPConsole.png)
![PSV](Launchbox_FuzzleBadges/Images/SonyVitaConsole.png)
* Microsoft Xbox
* Microsoft Xbox 360
* Nintendo 3DS
* Nintendo 64
* Nintendo DS
* Nintendo Entertainment System
* Super Nintendo Entertainment System
* Nintendo Gameboy
* Nintendo Gameboy Color
* Nintendo Gameboy Advance
* Nintendo Gamecube
* Nintendo Switch
* Nintendo Wii
* Nintendo WiiU
* Sony Playstation
* Sony Playstation 2
* Sony Playstation 3
* Sony Playstation 4
* Sony Playstation Portalble (PSP)
* Sony Playstation Vita

## In Launchbox
![Example](img/badgelist.PNG)
