# Wolves and Sheep: Game Design Document
A blend of classic RTS, economy-management, and top-down HnS.

## Table of Contents
- [Wolves and Sheep: Game Design Document](#wolves-and-sheep-game-design-document)
  - [Table of Contents](#table-of-contents)
  - [Overview](#overview)
    - [Concept](#concept)
    - [Genre](#genre)
    - [Audience](#audience)
    - [Game Flow](#game-flow)
    - [Aesthetics](#aesthetics)
  - [Gameplay](#gameplay)
    - [Objectives](#objectives)
    - [Progression](#progression)
    - [Play Flow](#play-flow)
  - [Mechanics](#mechanics)
    - [Physics](#physics)
    - [Movement](#movement)
      - [Player Movement](#player-movement)
      - [Unit Movement](#unit-movement)
      - [Collisions](#collisions)
    - [Actions](#actions)
      - [Marriage](#marriage)
    - [Resources](#resources)
      - [Wood](#wood)
      - [Stone](#stone)
      - [Stone](#stone-1)
      - [Stone](#stone-2)
      - [Stone](#stone-3)
      - [Stone](#stone-4)
      - [Stone](#stone-5)
    - [Combat](#combat)
      - [Competitive Theory](#competitive-theory)
      - [Core Components](#core-components)
      - [Character "Health" Gauges](#character-%22health%22-gauges)
      - [](#)
      - [Attack-Defense Types](#attack-defense-types)
  - [Narrative](#narrative)
    - [Summary](#summary)
    - [Characters](#characters)
      - [Sheeple](#sheeple)
      - [Sholves](#sholves)
      - [Wolves](#wolves)
  - [Artificial Intelligence](#artificial-intelligence)
    - [General AI](#general-ai)
    - [Auxillary AI](#auxillary-ai)
    - [Friendly AI](#friendly-ai)
    - [Roaming Enemies](#roaming-enemies)
    - ["Player" Enemies](#%22player%22-enemies)
  - [Technical](#technical)
    - [Target Hardware](#target-hardware)
    - [Development Software](#development-software)
    - [Network\Interplayer Connectivity](#networkinterplayer-connectivity)
  - [Other](#other)
    - [Options](#options)
    - [Replaying|Saves](#replayingsaves)
    - [Easter Eggs](#easter-eggs)

---

## Overview

### Concept
Wolf-people and Sheeple have a symbiotic relationship: the sheeple work contently to build, care, and feed the wolves, while the wolves provide the planning, thinking, and defense for the sheeple (they aren't the brightest).

### Genre
* Real-Time Strategy (RTS)
  * Economy
  * Military
  * Micromanagement
* Hack and Slash (HnS)

While WaS relies on its RTS and planning elements, its gives individual controls to the Wolf, allowing players to emphasize the HnS elements of the game through gear.

### Audience
WaS, while having fighting and death, is intended to be light-hearted in its style and approach of violence, intended for casual RTS and HnS fans.

### Game Flow
The player assumes hte position of the Wolf, the powerful leader that commands the sheep. The player controls the Wolf as any other HnS hero from a top-down perspective, using him as a frame to issue commands to the subordinate sheeple. 

### Aesthetics
WaS possesses a more minimal, simple 3D cartoonish design. While not entirely "minimalist" and down to bare bones, items and structures are exaggerated to only a few materials and composed of large pieces. Similarly, the character models are generally 1:2:2, as opposed to the actual human dimensions of 1:3:3

[![Body Proportion Examples, WaS uses characters with a more cartoony vibe, yet still flexible, as with the 110-130 cm models, a1:2:2 ratio of head:body:legs.][BodyRatios-img]][BodyRatios-link]

Characters are all human-esque, with small animal traits.

![Sheeple Concept][sheeple-1]

![Wolf Concept][wolf-1]

Due to the scope of this game, fluid animations, coloring, and other such design tastes are not planned to be necessarily fully realized.

## Gameplay
### Objectives
Typicall, WaS emphasizes creating a sustainable economy, army, and countering the enemy or acquiring some objectives. To this end, typically the player attempts to keep themselves safe (so they can retain control), which is dificult to do with the player character alone.
* **PvE|Survival**: The player is tasked with defending themselves with preparing throughout the day for nighttime, when monsters lurk about and attempt to kill you. They can easily overwhelm a lone wolf. Survive as long as possible using your Sheeple and Demiwolves, perhaps alongside your friends.
* **PvP|Skirmish**: Battle against either AI or other players in completing an objective or being the last to stand.
  * **Attrition**: Simple. Annihilate everyone else on the map.
  * **Blood for the Blood Gods (BBG)**: Sacrifice enough lives to the bottomless pit in the center of the map to appease the Bottomless Pit of Doom and gain a Doom Orb. Balance fending off your enemy, growing your city, and sacrificing units (or stealing the doom orb) and be the first to possess three Doom Orbs.
  * **Consume|Hypercarnivore**: Consume, from either your own ranks or the enemies, 100 lives, or be the last alive. A true test of building a fast, sustainable workforce.
  * **Apex Predator**: Simple melee of the pureblood Wolves, no RTS to slow down the combat.
  * **Arena**: Forgo the economy aspects of the game; granted a certain number of troops or funds, battle your enemy's army in a closed arena.
  * **Castle Wars**: one player on each side is given command of the Sheeple, the others assist as independent Wolves. Firstly survive through the perilous nights, grow your castle, then gather a force powerful enough it can push through the enemy infested forest that seperates you and the enemy castle.

### Progression
Starting with minimal equipment, there are some clear-cut guidelines for player improvement through gaining resources and building new structures and crafting new tools, such as a pickaxe for mining precious iron and stone. Later game elements focus on improving the player's units and military prowess -- the goal of most games are to produce the strongest and largest military units.

### Play Flow
???

## Mechanics

### Physics
Ideally, the game would employ a full physics-based game. Due to scope limitations, however, the game employs a more rudimentary physics engine. Carts do not have a true "roll" system, for instance. However, projectiles will have arcs and basic expected environmental rules will apply.

### Movement
#### Player Movement
#### Unit Movement
#### Collisions 
Custom pathfinding

### Actions
#### Marriage
The term for reproduction and mating in the game.

| MATING      | Sheeple  | Sholf  | Wolf  |
| ----------- | -------- | ------ | ----- |
| **Sheeple** | Sheeple  | Sholf* | Sholf |
| **Sholf**   | Sheeple* | Sholf  | Sholf |
| **Wolf**    | Sholf    | Sholf  | Wolf  |

\* = 50|50 Chance for Sheeple or Sholf.

### Resources
Resources are "minimalist", using bare-bones to create the world. Additionally, nigh everything in the world is usable to some extent.

#### Wood

#### Stone
#### Stone
#### Stone
#### Stone
#### Stone
#### Stone


### Combat

#### Competitive Theory
Balance is oft regarded as a crucial element to even semi-competitive games. While WaS does not seek to create an established meta and FGC foothold, it is important to keep in mind what makes games balanced and particularly "how is skill defined", i.e. what behaivor should be rewarded. While sometimes lack of balance or accidental tech can be found that surpasses the intentions of the developers and create games far better than intended (e.g. [Melee][^1]), it is more often lack of foresight that leads to even great games such as [For Honor][^2] to be unplayable after enough time when gimmicks wear off and players see the core of the game.

On the flip side of this, balance and competitiveness should not overrule *fun*, a concept some games lose nowadays. Indeed, the most balanced fighters are the earliest such as [Street Fighter I][^3], which [had two heroes who were clones of each other][^4]. Thus a fine-line must exist, and a somewhat non-gimmicky way to set this up is through [common tools avaliable to all characters][^5]. 

Thus we define, at least in the context of a simple game, *what is skill*. This is dificult to pin, a good assessment of skill types in games was marked by Technoraptor writer [Evan Hitchings][^6], breaking down mental skill into four main categories:
1. **Strategy**: Long-term planning and preparation, consideration of future events in the present.
2. **Tactics**: Short-term decision making that results in the best outcome now, such as using a correct counter or executing a short set of moves to gain an objective or favorable position or even merely defending from some building (as opposed to out in the open).
3. **Yomi**: One of the trickiest, but also oft-used skils, which is knowing your opponent, conditioning them, and making reads based on their past actions. The core of most fighting games this can essentially be boiled down to a complex, weighted, and multivairable Rock-Paper-Scissors skill. This also relates to "getting inside the enemy's head", which, along with crowd pressure, can lead to causing emotional reactions (anger, frustration, fear, confusion, etc.) rather than the ideal stoic and rational responses expected of players.
   1. Soft Reads: A mixture of Yomi and Game knowledge, predicting a handful of likely options from your opponent and covering those general options with a single move or set of moves.
   2. Hard Reads: Covering exactly one option that you predict your opponent will do, usually for great reward.
4. **Game Knowledge**: One of the broadest sets, this includes knowing health, stamina, game state, positioning, character interactions, frame data, counters, options, etc. This also applies to pattern recognition and application.

Additionally, physical or technical skills can be sub-divided:
1. Timing: Ability to perform an action at a specific interval or timeframe based on a reaction or prediction.
2. Reaction: Ability to physically see, hear, or otherwise process a data input such that you can then execute an output
   1. Simple Reactions: Around 265ms for most, the ability to do one execution based on one input, such as pressing a button when a light glows.
   2. Choice Reactions: More dificult to measure and increases somewhat with number of choices and outputs, but requires reading from multiple possible inputs and responding with multiple possible outputs. Can be brought down with practise to memorize and familiarize yourself with all options to allow quicker execution based on a given input (ie pattern recognition), as well as making soft predicitions as to what the opponent will do and your anticipated counter to effectively turn it into a simple reaction.
3. Execution
   1. Speed: Ability to input several different or same inputs, keystrokes, mouse clicks, etc. in a short period of time.
   2. Maneuvers: Loosely, the ability to execute complicated sequences of buttons or simultaneous clicks in order to execute a command.
4. Endurance: Ability to go through a game without loss of vigor and energy; especially notable in games with demanding execution such as [Melee][^1] or in long series of games where focus is needed.
5. Focus: Ability to remain focused on details and traits in the game, such as small indicators or marginal gaps in distance.
6. Precision: The ability to make exact movements and maintain control over their executions.

This is not an exhaustive list nor entirely set in stone, however offers a good summary of how games vary in how they define and reward "skill", an otherwise subjective term...

`Compilation Error: Abstract class 'Skill' cannot be instantiated.`

As WaS is a blend of two seperate genres, it gives a unique ability to allow players to emphasize different skillsets, not unlike multi-character games such as [Overwatch][^7]. Primarily, longer-term strategy is enabled by the prominent RTS elements such as base-building and economy management. A variety of tactical decisions can come into play with military units as well as unit management. These also are fairly low technical skill tasks. On the other side, playing sharp fighter-esque games as a solo combatant should also be rewarding to players with good movement, understanding of enemy types, weaknesses, and openings, etc. Regarding the interaction between the two, favor is on the side of numbers; while there is something to be said for reactable and easily conquered AI minions, long-term planning, preparation, and execution should not be defeated by simple reactions from another player, and hence combat in general should be risky and costly through unreactable, read-based offense.


[^1]: [Super Smash Bros Melee](https://en.wikipedia.org/wiki/Super_Smash_Bros._Melee), a 2002 Nintendo mascot fighter (in)famous for players having found numerous explots in the engine that allowed the game to become much faster paced, intense, and competitively viable than the game was originally intended to be. As of this writing (2019), the game is still played frequently at eSport and FGC tounaments such as EVO, [EVO 2019](https://en.wikipedia.org/wiki/Evo_2019#games) being the first time the game was relegated to a side event in years.
[^2]: [For Honor](https://en.wikipedia.org/wiki/For_Honor) is a mixed genre pseudo-medieval fighting game. While its mixture of game genres, impressiveart design and execution, and innovative ideas led to some success, it suffered immensely in their attempt to make the game competitive from a combat system designed for slow and casual defensive play.
[^3]: [Street Fighter](https://en.wikipedia.org/wiki/Street_Fighter_(video_game)) notably lacked the multiple characters introduced in future iterations. [Street Fighter II: The World Warrior](https://en.wikipedia.org/wiki/Street_Fighter_II:_The_World_Warrior), while inherently less balanced due to its multitude of characters and lack of easy and reliable post-launch balance in 1991, was also far more popular and considered a classic in gaming history.
[^4]: This line is more or less taken from [Core-A Gaming](https://www.youtube.com/channel/UCT7njg__VOy3n-SvXemDHvg)'s video on FGC buffing, [Analysis: Why We Should Buff More Than Nerf](https://www.youtube.com/watch?v=bsC8io4w1sY) (at 2:07).
[^5]: [Walker Jesse](http://www.pauseresume.com/balance-in-fighting-games/) talks about how games such as [Vampire Savior](https://en.wikipedia.org/wiki/Darkstalkers_3) seeks to rectify balancing problems by giving a foundational moveset to every character, then modifying them off of it, allowing even the weakest heroes to have the fundamental tools to play against the strongest.
[^6]: [Understanding Skill in Competitive Games](https://techraptor.net/gaming/opinions/understanding-skill-in-competitive-games)
[^7]: [Overwatch](https://en.wikipedia.org/wiki/Overwatch_(video_game)), a 2016 competitive team-based shooter featuring a broad range of unique characters with various abilities.

#### Core Components
As WaS tries to limit the UI overload of many games, similarly its core combat is done without meter, health bars, or the like. Moves are **lethal**, **non-lethal**, or **conditionally-lethal**-- fights are ended in one hit. This allows combat to be incredibly risky, quick, and brutal as well as a constant threat of death at any moment, though there better players will have back and forth exchanges. As such, there are three non-lethal components that contribute to "health" in a fight: **posture**, **stamina**, and **limbs**. 

The goal in most fights, as such, is to either quickly eliminate the opponent with a deadly weapon strike. Failing that, wear down the posture of the opponent and cut down on their options in order to force more active responses. Likewise, if on the defense, use a mixture of passive defense to stay safe from lethal deathblows while throwing in risky defensive moves in order to turn the tide, conserve posture, and/or take the offense. Each character has at least the following options avaliable to them:

W-SPEED: WindUp Speed
A-SPEED: Active|Release Speed
R-SPEED: Recovery Speed


| MOVE         | W-SPEED | A-SPEED | R-SPEED | MK KEYBIND | CTRLLER KEYBIND                        | PURPOSE            | COUNTERS                | COUNTERED BY | DESCRIPTION                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      |
| ------------ | ---------- | -------------------------------------- | ------------------ | ----------------------- | ------------ | -| -| -| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Step         | 300 | | | WASD       | LStick (tap)                     | Initiates Movement | Aim, Max Range Attack | Slashes      | Each press of a direction key moves your character by a half-step. This is important, as pressing a directional key repeatedly has you moving at a slow half-pace as compared to a normal walk while holding it down, giving you finer control over your movement. Additionally, steps can be cancelled back to neutral by pressing in the opposite direction, letting you feint movement tells. Sidesteps can be used as a defense against stab-like attacks, although it is rather strict timing, and can be beaten if they aim for where you are headed instead of where you are at. Sidesteps can also be used to "emphasize" or "temper" blows and defenses, giving them more or less strength, by moving in with the strike or away. Lastly, step forwards or backwards can also drastically affect the range of the attack by moving you with the attack. |
| Turning      | | | | Cursor     | RStick | Decides where your character is facing |                    |                         |              |
| Offhand Attack | | | | M1         | L1 | Quick Non-Lethal Attacks (Left-Hand)                              | Slower Windups, Grabs, Close Opponents           | Movement, Range, Blocks            | Your fast offhand attacks, pommel strikes, etc. these attacks are your close quarted bread and butter. Due to their speed, unless predicted, they are relatively safe to throw out. They can never kill and do little to no knockback, but can be used to chip at posture, stun opponents out of moves, pressure them to move or back up, etc. Additionally, punches can be charged for a good deal more posture damage and ensure the safety of the punch against defenses, but the slowed down version is quite reactable. Punches can be feinted during their windup.  |
| Primary Attack         | W-SPEED | A-SPEED | R-SPEED | M2    | R2 | Your Lethal Weapon Attacks                                | COUNTERS           | COUNTEREDBY            | DESCRIPTION  |
| Kicks/Sweeps         | W-SPEED | A-SPEED | R-SPEED |KEYBIND    | M5 | PURPOSE                                | Blocks, Sidesteps           | COUNTEREDBY            | DESCRIPTION  |
| Grab         | W-SPEED | A-SPEED | R-SPEED | M1+M2    | CTRLKEYBIND | PURPOSE                                | COUNTERS           | COUNTEREDBY            | Can use A and D for wide arcing grabs, W for forward momentum grab  |
| Jump         | W-SPEED | A-SPEED | R-SPEED |KEYBIND    | CTRLKEYBIND | PURPOSE                                | Sweeps, Kicks           | COUNTEREDBY            | Can wallkick off of opponent if too close  |
| Crouch         | W-SPEED | A-SPEED | R-SPEED |KEYBIND    | CTRLKEYBIND | PURPOSE                                | Jabs, Fast Attacks           | Kicks, Overhead Swings, Diagonal Swings            | Diagonal Swings can be countered by crouching and moving in the lower corner of the swing.  |
| Feint         | W-SPEED | A-SPEED | R-SPEED |R4    | CTRLKEYBIND | PURPOSE                                | Jabs, Fast Attacks           | Kicks, Overhead Swings, Diagonal Swings            | Diagonal Swings can be countered by crouching and moving in the lower corner of the swing.  |
| Feint         | W-SPEED | A-SPEED | R-SPEED |R4    | CTRLKEYBIND | PURPOSE                                | Jabs, Fast Attacks           | Kicks, Overhead Swings, Diagonal Swings            | Diagonal Swings can be countered by crouching and moving in the lower corner of the swing.  |

* Jump > Crouch: fast fall, can catch sweeps and low attacks
* Jump>Kick:
* Back > Punch: deflects punches, winds into slow but unblockable punch (easily punchable from neutral, but if charged from deflected punch...)
* Back > Kick: Lifts foot to counter sweep attacks
* Stand to Relax
* Shift to Dodge, hold to Sprint
* Super Sprint
* Turning Speed?
* Need to address the issue on if it's "blocky" or "free flowing"
* Offensive Recovery -- better recovery in chaining, almost unpunishable (defense returns to neutral, sometimes gives offense to defender, but doesn't necessarily guarantee dmg)
* Feint/Block same Button, release to parry, requires windup to parry
* Switch hands
* Switch weapons (scroll wheel? Click to drop?)

Sidesteps: while they are "passive" mostly, they can also be beaten by "passive" aim -- that is, ontop of everything else, sidesteps|movement and aiming stabs have their own role.

Goal: There are two fronts, the "upper body" (weapon) and the "lower body" (movement). They are fundamentally connected, but also somewhat seperate -- to "win" exchanges, you need to either overwhelmingly win one front, or win on both fronts -- often they should "cancel" and there be net neutrality.

#### Character "Health" Gauges
* **Posture**: Posture relates to how much energy you can put into attacks, defense, etc. at any given time. Blocking attacks, for instance, costs a large amount of posture. Care must be taken that your posture does not run out, as it limits your options, forcing you to take riskier defensive and offensive actions. Posture is worn down rather quickly in a fight, but also regenerates rather quickly, sometimes several times in a single fight. Posture refills exponentially (like a capacitor), so while you can get to a decent posture in short time, it is dificult to get to the same posture with which you started the battle. Posture can be told by the literal posture of the hero, with weaker posture affecting how they hold their weapon or feet, as well as the rate of their breathing/heartbeat. Additionally, posture is divided into two components:
  * Arm|Standing Posture: This relates to the energy in upper-body defenses and offenses, such as blocking, deflecting, parrying, grapples, etc. Running out of arm posture often means your standing defenses are riskier.
  * Leg|Movement Posture: This relates to your ability to stand your ground, dodge, jump, crouch, sprinting, etc. As you run out of movement posture, you cannot dodge attacks as easily or escape battles.
* **Stamina**: while posture relates to more tactical play and quickly regenerates over battles, stamina is essentially your "pool" of energy and relates to how well you came into battle prepared. Higher stamina means you regenerate your posture faster and increases your max posture. Stamina is consumed by refilling posture and refilled itself over time given a character's needs are met (food, water, sleep). Unlike posture, there is not an at-a-glance way to tell the stamina of a character, further reinforcing its role as a hidden and prepared stat, though it can be estimated by how fast they recover their posture. Max stamina increases by specific measures, typically eating hearts: sheep increases stamina slightly, sholves by a good bit, and the hearts of pureblood Wolves by a percentage of their max stamina. While stamina is consumed across all of properties, it is refilled into three subsections, which are not necessarily equal in how much stamina is consumed on posture refill. If a unit ever runs out of one stamina subsection, they can rely on the others, but at doubled consumption; if they fall to one
  * **Thirst**: the most short-term stamina bar, this bar is consumed the fastest and refilled quickly; as it must be filled potentially multiple times a day, it is advised to have water on person in the form of bottles. Running low on water causes characters to smack their lips and leave their mouths open with their tongues slightly out.
  * **Food**: medium-term property, this is consumed roughly once a day with average work. It takes some time to eat, though characters can be sped up to eat fast at the cost of efficiency of food. Additionally, characters can be fed different rations, and double the food each day increases their food stamina by 1.3 times past their max (it is not linear, and linear increases in consumption require exponentially more food). Hunger causes characters' tummies to grumble and they will stare longingly at food (plants for Sheeple, Sheeple for Sholves). Eating with friends and in comfortable environments increases the efficiency of food and effectiveness, giving a bonus to the stamina regenerated.
  * **Sleep**: the most long-term attribute, this stamina bar is refilled on resting. It starts at slow consumption which increases with time since the last rest, thus characters can do short rests each day or very long rests every couple of days (time-wise, it is more efficient to do short rests). While resting, there is a small delay in which stamina regenerates slowly, but then rapidly picks up (simulating REM sleep and preventing quick, meaningless naps). Sleeping in a comfortable environment increases the effectiveness of the sleep.
  * Comfort/Sanity: Not planned as of now, but could be a statistic if deemed necessary to focus more on the "social" side of managing your units.
  * Stamina Consumption Multipliers: Comfort, temperature, effort, etc. can also come into play as stamina consumer modifiers.
* **Limbs**: some attacks target limbs specifically, causing different affects. Generally, though, **wounds** cause a drop in your max posture (which can heal to scars), **scars** give a max posture bonus and prevent the wounding of a limb, and loss of limbs have drastic costs to your abilities.
  * **Wounds**: Attacks that cause wounds leave that limb (and its associated posture) at a massive disadvantage until healed. The wound bleeds out for several seconds, decreasing the posture of that limb, and the limb's max posture is halved. As such, for a regular full posture opponent, taking a wound to the leg decreases max leg or movement posture to $75\%$ (as each leg contributes half of the max posture), or $\frac{7}{8}$ of the total posture of the character. 
    * Only slashing weapons can cause wounds. 
    * Visually, shown as a bloodied large scratch that drips cartoonish blood droplet out.
    * Heals to scars. 
  * **Bruises**: Attacks the leave bruising increase the posture consumption and damage to that limb. As such, a bruised leg will be doubly as vulnerable to stamina attacks that attack that leg (such as a knee kick) while also increasing dodge costs using that leg. 
    * Only blunt weapons can cause bruising.
    * Visually, shown as a large black-blue patch if skin is shown, as well as a limping of the limb.
  * **Scars**: Wounds heal to scars after being treated. This is a visual only, however there are possibilities...
    * Positive Affliction: Scars increases your endurance in that limb, increasing max posture. This encourages battling often and acts as a pseudo "levelling up" after multiple battles, but also can lead to cheesy play such as damaging yourself early game to be stronger later. Although, given the [personality of Wolves](#wolves), this may be an interesting style to promote.
    * Negative Affliction: Wounds could be considered a perma debuff, having a slight decrease ($10\%$) to that limb once healed to a scar.
    * Mixture Affliction: Scars could have a buff and debuff, for instance increasing max posture in that limb at the cost of an even more steep penalty if wounded again (serving as a target to the enemy if they know about it or see it), or the opposite, having permanently decreased max posture by a bit but being resistant to future scars/bleedouts on that limb or increased max stamina.
  * **Dismemberment**: causes drastic differences in gameplay. Missing an arm prevents you from using punch attacks, missing a leg causes your characters dodges to be rolls to the ground (and thus much more risky) as well as a constant bleeding out (loss of posture) until addressed. These can be overcome slightly with prosthetics *if* the dismemberment was of the lower half of the limb (past the elbow or knee) which constitutes the majority of dismemberments, such as a wooden/bone/metal leg or forearm, although there movement and damage is permanently decreased as well as some potential moves and equipment. There may be an option to play the [Rimworld][^8] route where limbs can be scavenged from enemies or an unreleastic limb regrowth mechanic such that characters do not have to live with them permanently. Alternatively, prosthetics can be given some unique advantages (such as immunity to wounds/bruises of course, special moves, attached weapons, etc.) similar to the ideas for scars above to encourage battle and unique character development. Note that, as with all of these things, the game is cartoonish in its depiction, and dismemberments look like cartoonish red blobs at the end of the limbs, maybe with that infamous white center; they should not be overly detailed or graphic, despite their grim nature.

#### 

#### Attack-Defense Types
Note that not all weapons deal only type of damage, and indeed some weapons can do multiple forms of damage (such as the waraxe, both blunt and slashing damage in its swing).
* Slashing Damage
  * Generally versatile and "main" damage
  * Can cause wounds, dismemberments, and decapitations.
  * Swords, Axes, Knives (throwing?)
* Blunt Damage
  * Does percent stamina damage, great against high stamina heroes.
  * Can cause bruises as well as headcrushes.
  * Warhammers, Maces, Shields, Rocks, Melees, Axes (minor), Swords (mordhau-grip)
* Impaling Damage
  * Impales and usually kills (fewer limb attacks).
  * Can cause bleeding, leaking stamina.
  * Can cause stuns?
  * Spears, Swords, Arrows, Javelins, Knives, Daggers

* Cloth|Gambeson Protection
  * Cheapest, goog all-around armor
* Maile Protection
  * Fairly expensive, medium-tier armor
* Plate Protection
  * Very Expensive, Time intensive high tier armor
  * Longer don/doff time, increased with help

* Armor can be stacked; one layer for Sheeple, two for Sholves, three for Wolves
* Different quality levels for each armor set
* Seperate for each limb

Attack Types
* Stabs
* Swings

Damage Types
* Slash
* Blunt
* Impale

Protection Types
* Gambeson
* Maile
* Plate
* (wood? Magic?)

Does DAMAGE beat ARMOR?

IDEA 1: A balance of all three, where each acts as a counter and defeated by one thing.

| DAMAGEvARMOR | Gambeson | Maile | Plate |
| ------------ | -------- | ----- | ----- |
| **Slash**    | DMG      | ARM   | -     |
| **Blunt**    | ARM      | -     | DMG   |
| **Impale**   | -        | DMG   | ARM   |

A "more releaistic" version where every weapon still has an advantage, but armor is very useful (due to increased costs)

| DAMAGEvARMOR | Gambeson | Maile | Plate |
| ------------ | -------- | ----- | ----- |
| **Slash**    | DMG      | -     | ARM   |
| **Blunt**    | ARM      | -     | DMG   |
| **Impale**   | -        | DMG   | ARM   |


Same as above, blunt does almost the same damage across the board (though gambeson has an advantage), though does not specifically beat any one thing, making it almost equally effective against all types (although plate and maile will still likely have s light dmg reduction compared to Naked).

| DAMAGEvARMOR | Naked | Gambeson | Maile | Plate |
| ------------ | ----- | -------- | ----- | ----- |
| **Slash**    | DMG   | DMG      | -     | ARM   |
| **Blunt**    | -     | ARM      | -     | -     |
| **Impale**   | DMG   | -        | DMG   | ARM   |



[^8]: [Rimworld](https://en.wikipedia.org/wiki/RimWorld) is a top-down colony sim management game, which allows near comedic levels of sociopathic medical practises, such as trading limbs and organs freely and practises such as stripping prisoners of all non-vital organs and limbs and then sending them back home.


## Narrative
### Summary
Pureblood Wolves, ie the players, are intelligent and powerful beings. However, a single creature can only do so much. As such, Purebloods rely on Sheeple and Demiwolves to extend them and their ideas. The Sheeple and Demiwolves, none too bright, rely on their powerful leaders for protection and the guarantee of either their future or the future of their children. 

This symbiotic feudalism serves everyone well, especially in the face of roaming bandits, powerful bears, dragons, and other such fearsome predators. Most of all, though, protection is needed against the most dangerous enemies of all: other Wolf-led kingdoms and tribes.
### Characters

![The three basic characters][characters-all]

#### Sheeple

![Sheeple Design][sheeple-char]

| ATTR | VAL                                                 |
| ---- | --------------------------------------------------- |
| NAME | Sheeple - Sheep - Commons - Peasants                |
| ROLE | Economy - Production - Food                         |
| DIET | Leavery - Grass - Fruit - Bread                     |
| AEST | Round Ears - Soft Eyes - Fluffy Tails - Colorful    |
| CHAR | Simple Minded - Caring - Obedient - Gullible - Weak |
| METL | Bronze                                              |

While the Wolves are the player units, the Sheeple are arguably the main characters of the game, and there will undoubtedly be a lot more Sheeple than Wolves.

None too bright, the Sheeple are often content and calm with the world around them, merrily eating, marrying, and working as need be. Naturally, Sheeple are communal and do not have strong sense of ownership or possession, even jointly raising children. Due to their laid-back lifestyle, lack of ambition, and physical weakness, they often willingly defer to more powerful creatures to protect them, serving them to do so.

#### Sholves

![Demiwolf][demiwolf-char]

| ATTR | VAL                                                                                  |
| ---- | ------------------------------------------------------------------------------------ |
| NAME | Sholves - Weeple - Demiwolves - Wolvlets - Carnivorous Sheeple - Weresheep - Knights |
| ROLE | Military - Combat - Protection                                                       |
| DIET | Meat - Sheeple                                                                       |
| AEST | Sharp Ears - Sharp Eyes - Wolf Tail - Colorful                                       |
| CHAR | Strong - Pack Focused - Justice - Protecting - Honor - Loyal                         |
| METL | Silver                                                                               |

Sholves (name undetermined) are the children of Wolves and Sheeple. They are not near as powerful as a pureblood Wolf, but much stronger than a Sheep. They have strong sense of formation, leadership, loyalty, and codes of honor that lend themself well to their warrior role. While not the brightest animals, like the Sheep they are capable of learning tool use and weaponry, as well as having additional mental complexities, such as fear met with courage and honor over survival. 

Due to their carnivorous diet, it is dificult to sustain a meaningful Sholve population without a well-based Sheeple populace. As with the Wolf, the Sheeple understand their use as food, although this still limits attachment or meaningful relationships between the two, and often Sheeple show fear in the face of Demiwolves -- indeed, without an overwhelming ratio of Sheeple to Sholves (10:1), Sheeple may be less productive and instead cower in fear. That said, Sheeple and Sholves can still marry.

Sholves, unlike the Sheeple, form deeper bonds and as such marriage is permanent. This can be a massive boon as partners can support themselves in battle effectively, but also a detriment as after gaining or losing a partner, Sholves will not remarry. This creates an interesting relationship with Sheeple, as they are prone to remarriage and multiple partners, and as such a Sholf that marries a Sheeple may seek to constantly affirm their love with gifts and acts of kindness. Marrying a Sholf and Sheeple results in one of the two being born randomly.

Thematically, the Sholves serve as a decent middle ground between the Wolves and Sheeple, and may even reflect the "typical player" more than the Wolf. While the Sheeple live contentedly and on simple impulses in an almost apathetic indiffernece without strong morals, the Wolves are beyond morals and their delusions of power and fear of loss leads to another form of nilishtic apathy to conform to their changing ambition. Between these two, Sholves represent a standard between the simple-minded idealism of the Sheeple and the paranoia-driven pessimism of the Wolves. Their sense of duty, honor, and justice creates natural dilemnas, a collision of their more base survival instincts (Sheeple) and higher-level concepts (Wolves) resulting in a moral frustration and dilemna.

#### Wolves

![Wolf Design][wolf-char]

| ATTR | VAL                                                                                                  |
| ---- | ---------------------------------------------------------------------------------------------------- |
| NAME | Wolves - Purebloods - Royal Wolves - Nobles                                                          |
| ROLE | Commander - Leader - Hero                                                                            |
| DIET | Meat - Sheeple - Demiwolves                                                                          |
| AEST | Sharp Ears - Sharp Eyes - Wolf Tail - Visible Fangs - Darkened Eyes - Large Stature - Dull Color     |
| CHAR | Intelligent - Powerful - Persuasive - Manipulative - Paranoid - Ambitious - (largely player defined) |
| METL | Gold                                                                                                 |

Thematically, the wolves represent the player, their wit and decision making. As advanced AI is not planned for the initial product, wolves are nigh exclusively players. The world is seen through them, and without them, they cannot interact with the world.

The apex predator, the Wolves are generally powerful beings who can individually take on several other creatures. Indeed, it is not uncommon to hear of lone Wolves, travelling about working or surviving on their own. However, this wastes their intelligence and ability to lead, and thus most Wolves of age take a few sheep with which they can then grow a colony and kingdom -- even a single Sheep and Wolf can begin a colony. 

As a result of their intelligence and ambition, Wolves are often paranoid, hence why they often wage war against one another. While it is not entirely uncommon for Wolves to group up against an objective or enemy, it is rare that this is done with a dual leadership of one populace, and the general nilhism and lack of true morals unlike the Wolvlets lends itself to potential backstabbing.


## Artificial Intelligence
### General AI
### Auxillary AI
### Friendly AI
### Roaming Enemies
### "Player" Enemies
Not high priority, as a decent implementation of a fair "player-esque" AI may be beyond our scope and capabilities for now.

## Technical

### Target Hardware
* PC Exclusive (for now)
* Cross Platform? (Windows|Linux|Apple)
* Mouse and Keyboard - customizable keybindings

### Development Software
* Unity: Combines most individual elements to allow easier project allocation.
* C#: The programming language of choice to handle scripting.
* Blender: 3D Modelling
* Audacity: Sound Editing
* ??: Sound Design/Creation? Reaper?
* ??: Music Design/Creation? Reaper?
* Gimp: Texturing
* Leonardo: Art Design Drawings
* Markdown: Communication Language
* Git: Source Control
* GitHub: Online Repository Hosting
* Sourcetree: Source Contorl GUI
* VSCode: Code Editor/pseudo-IDE

### Network\Interplayer Connectivity

## Other
### Options
### Replaying|Saves
* The player shall be able to save their world state to a file, which can then be loaded by any copy of the game to produce the world exactly. This includes both the world state as well as specific interactions that were occuring at save.
* Ideally, randomly generated maps will be accessible, as well as map tools for custom maps. These are not held in high priority, however.
### Easter Eggs

[BodyRatios-img]: Images/BodyRatios.jpg
[BodyRatios-link]: https://i.pinimg.com/originals/05/49/53/0549535f52b6e87bd092205b4f544103.jpg
[wolf-1]: Images/WolfConcept-0.png
[sheeple-1]: Images/SheepleConcept-0.png

<style>
h2:after {
  content: ' ';
  display: block;
  border: 1px solid rgba(128,128,128,0.2);
  width: 70%;
}

h3 {
  text-align: center;
  /* text-decoration: underline; */
}

img {
  border-radius: 15px;
  border: 2px solid rgba(128,128,128,0.2);
  display: block;
  margin-left: auto;
  margin-right: auto;
  width: 60%;
}

</style>