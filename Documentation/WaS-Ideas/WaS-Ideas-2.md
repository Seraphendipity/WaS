# WaS-Ideas-2

## Overview
A multiplayer educational game that utilizes programming in cooperative and competitive manners. Built on a custom framework that allows relatively simple creation of scenarios (that is, without having to mess with the source code).

Purpose: A tool to teach and play with various programmable ideas in a fun and cooperative enviornment. Can branch to several ideas, from a Minecraft-esque world built on automation, puzzle tutorials, programming puzzles, educational demoes, competitive game modes, etc.

## Programmable Sheep
https://play.elevatorsaga.com/

Notice how you can program the elevators inside the "world" of the game without having to change the [source code](https://github.com/magwo/elevatorsaga). 

https://developers.google.com/blockly

We can use blockly API for this to allow block-based coding or javascript. Potentially, even our own language type based probably on JavaScript, but that allows MarkDown and "checkpoints" to jump to, fixing or suggesting fixes for quick oversights (ie missing semicolons), allow method(,,param) syntax, etc....

Each sheep is an "instance" of a class, the Sheeple. However, that base class is not accessible, but the "instance" is. That is, you can teach a person, but you cant teach Humans as an object (a similar relationship of the abstract and implemented course idea in the SCRS). As such, each Sheep is their own "class" that can be programmed.

For an example of how this would work... 

![UI](Images/design-ui-1.png)

This would be an example of that "abstract" non-modifiable (in a regular game, but can be modified in a "creative" mode):

```javascript
Sheeple {
    
    public Sheeple() {

    }

    ## Properties

    ### Attributes
    int stamina;
    int posture;
        * Hydration
        * Hunger
        * Restedness
        * Entertainment
        * Psych (maybe combined with entertainment)
    string name;
    int weight

    ### Meta
    enum feet {{l,left}, {r,right}} nextFoot{} = feet.rand();

    ## Methods
    digest();
    digest();
    step(dir) {
        this.step(dir, nextFoot);
    };
    step(dir, foot) {
        static var anim[] = ...; //timing and visuals
        nextFoot!!; // nextFoot = !nextFoot;
    }
        * F - Forward
        * L - Left
        * R - Right
        * B - Back
    step(dir, foot);
    step(dir, foot, distance);
    openMouth();
    closeMouth();
    ...
}
```

A specific sheeple. Note that users shouldn't usuall need to specify the most minimal functions and can use "higher level" functions more usually.

```javascript
Mary (SH-02213532) {

    ## Methods
    Walk(distance) {
        stepSize = 0.5
        for(int i = 0; i < distance; i++) {
            AnimEvent e = step(F,,stepSize);
            waitFor(e.cancellable());
        }
    };

    Run(distance);
    Path();
    PickUp();
    See();

}
```

These could then be put into a library, such as "Standard" which is incorporated with most every Sheeple. Users can also create their own libraries similar to this with varying simple or complex procedures. Then they can walk up, click them, and tell them to do something, such as `Walk(2)` (perhaps also allow united parameters, ie `Walk(2m)` or `Walk(2f)` without necessarily doing a string).


(sidenote: the SH or other ID number has various factors that play into it, including a unique ID for any "established" player accounts as well as computer and such, as such is near always uniqe, and if players choose go to a DB to allow a collection of all Sheeple)

Additionally, there will be varying levels of "detail" that is decided to be shown. Code can be wrapped and marked in sections, as well as "detail level" markers (similar to logging), so when teaching you can hide unnecessary stuff but you still have access to lower level stuff if need be

## Player Character


## Thought Storm
* Programmable Sheep
* Custom Avatar
  * Why? Direct influence on the world
  * Personalization
  * "Invests" users
  * Potentially less overwhelmming (can only interact with elements on screen)
  * Allows you to "act" out actions to think through what you want to code
  * Consider auto-chess -- largely redundant PC, but that "commander" helps integrate you to the game
* Engine/Platform/Creation Tool
  * Proof of Concept Prototype -- not optimized and likely will be scrapped if popular
  * Allow easy creation of...
    * Environments/Maps
    * Scenarios/Objectives
    * Adding objects to the game?
    * Adding animations to the game?
      * Camera tracker?
    * "videos"
    * Options/Parameters
  * Examples...
    * Spark
    * Spore DLC
    * Fate?
  * Most game mechanics built on it
  * Programmable
* Dynamic Avatars/Animations (meta)
  * Animations are parametrized and not static to accomodate various scenarios
  * Use overlapping and partial masking
  * Physics applies (ie a push against a wall does not faze through)
  * Animations are an object as well, with defined timimgs as well as what they affect, metadata descriptions, potentially optical comparisons at various angle (so, say, if a computer is supposed to react akin to a human with mixup based animations that are similar looking), cancellability (what type of things can they cancel into and can be cancelled from, such as a combination of musts and cannot tags of other animations), etc.
* Physics Engine
  * Voxel-based wolrd? no need for entirely voxel
  * Voxels mainly for allowing easier programming (on the players)
  * Think McWane or Playground "building blocks" or Legos
  * Weight
  * Tensile strength (for building bridges -- how many blocks can "lean out"?)
* Abstract Vocals/Language
  * After a button press, keys make sounds. They are simply syllables. Modifiable pitch and volume (maybe emotion?) that can be used to associate commands or just create a in-game language with your people
  * Alt. simple emotions on button press which can be combined a bit.
* "Free" animating emotes
  * Allow dragging limbs manually with mouse or controls for quick and derpy movements
  * As aforementioned, also perhaps a dedicated meta or in-game option to create animations
  * Limbs as seperate entities


---

## Thought Storm
> with different feature maps to have different gameplay mechanics