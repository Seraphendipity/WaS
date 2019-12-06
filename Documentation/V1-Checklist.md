# Checklist for V1

## Game
* GUI
  *  Menu Start Game
  *  Options tied to a few features to show save-state
* Playable Map
  * Two Bases
  * Distributed Resource - Gold
* Units can bring gold to gold processor
* Gold Processor adds Gold to Gold Points (GP)
  * CoRoutine Timer for Processing (multithreading)
* Player can buy units and more buildings from castle
  * GUI Context Menu on Clicking Castle
  * Placing Buildings on Grid
* Select and Move Units
* Bow - Attack in Firing line at direction
  * Generated from Castle
* Units Attack via Bow - select firing direction (no tracking or such yet, just basic physics)
* Two Player Combat -- not necessarily online, but preferable
* MAYBE: AoE Heal From Commander (to demonstrate commander's potential influence)

Why Gold and bows and such? These are the simplest elements to model from where we are rright now, and while simple, show the basic principle of resource generation, collection, processing, and consumption (which eventually will be diversified into wood, stone, food, etc.) as well as player, building and unit interaction. Bows/Crossbows because still trying to figure out sword interactions and how AI's follow and fight each other -- thus instead they'll just be directed to shoot in a line.

## Tasks

We will meet THURSDAY NIGHT at 7:00PM (I'll try to get a room reserved) to mesh our projects and get us on GitHub and all that stuff. Additionally, whatever I inevitably do not finish witht he above, we'll work on completing together -- the only reason why I'm hesitant to delegate now is
1. Lack of GitHub/Version Control which is due to 
2. Project is very Messy - Basically turned my Unity playground into WaS (ideally now I'd start a new clean project and refactor with new knowledge, but dont have time to do so rn)
3. I have bits and pieces of almost all of the above components, thus need to work on fixing and integrating them -- ie I do not know what to exactly delegate yet.

### Alex
* GUI: You mostly have this done, even if we can't tie do the entire JSON dynamic read right now, I'd like to show just 1 or 2 variables being stored if possible and intialized in the game. We can work this out Thursday.
* UML Diagrams: Ensure the Use-Case Diagram looks correct (idk what theyre really supposed to be) -- should there be multiple?
* Double-Check our Documentation to make sure we're hitting all of the rubric marks

### Reece
* First and Main Priority (others extra): Multiplayer capability. We don't even need a seperate client server model, just two players with two controllers plugged in or such (although networking would be cool too, but is not mandatory here). I've arranged the player into a "PlayerController" to make it a prefab to be used with most implementation of multiple player models. Also teams, and team-based coloring (ie setting the material of one set of sheep units and buildings to blue) -- can be hard-coded for now.
* Extra if you Can: Trello on Track, try to get our tasks organized.
* Extra if you Can: Report on Networking (you can delegate report to Alex if you can explain it well as you have a lot on your plate)

### Elijah
* Various Game Components and Mechanics (as described above)
  * Contextual GUIs
  * 
* Rudimentary Castle Model
* Rudimentary Crossbow Model
* Rudimentary Processor Model
* Rudimentary Gold Ore Model
* MAYBE: Basic Animations (they're all T-Posing rn)

(Please note that while it took a good bit of time, the player model is still utter crap aesthetically due to time constraints; however, I am making the animations for a humanoid model in general, ie as long as our future ideal model has generally the same outline, our work on these models should carry over if we update them)

### Other Tasks to Pick Up if you have Time (which no one probably does)
* Keybinding - how does it work? How should we refactor code from `Input.GetKeyDown(keycode.w)` to something less keyboard specific? Can it be saved in a JSON or such?
* Map Editor -  can we serialize a map? I'll have a placement script ready, so we'd only need some way to save the state.
* Steamworks API - can we delegate friends list and user IDs to Steam or nah?