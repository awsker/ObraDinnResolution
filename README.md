# Obra Dinn Resolution Mod

This mod is a [BepinEx 5](https://github.com/BepInEx/BepInEx) plugin that increases the rendering resolution of Return of the Obra Dinn. This is a rough first draft and can not be used to play through the entire game. The plugin and its code is provided as-is with no guarantees.

![4K Screenshot](https://github.com/awsker/ObraDinnResolution/assets/604653/7a7b4b47-90b7-46e8-9533-e6b01fa35788)
*Screenshot captured in 5120 x 2880*

## Installation
* Download and install the latest release of [BepinEx 5 32-bit](https://github.com/BepInEx/BepInEx/releases) (The zip with x86 in its name)
* Unzip it into your Obra Dinn directory
* Download the [latest release](https://github.com/awsker/ObraDinnResolution/releases) of ResolutionFix.zip and unzip it into your BepinEx\Plugins directory

## Usage
The plugin will use your Windows desktop resolution when starting the game as its target resolution. 
You can use Nvidia DSR (Nvidia Control Panel -> 3D Settings -> DSR Factors) to set up a custom resolution much higher than your monitor supports and then launch the game.
When starting the game, it's possible the main menu is very small. If you can't see the "Begin" button, it could be hiding in the clouds. Be careful when clicking around so you don't accidentally remove your save game.
The plugin will hide all blur effects (edge blur, edge wave, blur from explosions and guns and even the blur over some gore effects)

## Known issues
GUI components, the book and some effects when zooming in on faces are not rendered properly
