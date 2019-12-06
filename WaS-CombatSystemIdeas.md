# Combat Mechanics

## Simple DPS Model
There is no true "defense" aside from some abilities. Simply, enemies attack each other. No real "hitstun", just damaging each other till someone dies. Multipliers, modifiers, and army composition are crucial points. Skill comes in preparation and use of units in a battle.

The cons of this system is that it does usually lead to a very defined meta (and maybe one or two counter-metas) and its combat is somewhat "lackluster" -- point and click. This does have the benefit on putting all skill on strategy (preparation) and tactics (unit management), but can also be somewhat dull and "uninvolved". Indeed, one of the big points of such elements as the Wolf is to re-engage more action-y elements with these battles-- why are RTS's so lackluster in small-scale battles when other games can have an entire game on 2v2?

### Examples
* League of Legends
* Command and Conquer
* Warcraft
* Halo Wars

## Simplified Fighting System
* Stamina/Posture System
* "Weighty Units" -- Units take up noticeable space, body blocking

### Core Components
* Melee - Fast mixup moves, does not kill but good at wearing down stamina
  * Jab: Fast, Interuptor, Close Range, Uncharged 
  * Punch: Main Melee, Counters Jab on Startup, Good Stamina Damage
  * Uppercut: Slow and Unreliable, Counterable by Punch, Used to Mixup Punch Timing occasionally
* Weapon Attack - Generally Kill Moves or heavily damaging, but reactable and counterable
  * Stab (uncharged weapon attack): Stab, Very Block Stam-Drain
  * Slash (charged weapon attack): Stab, great against blocking opponents
  * Soft-Feint to Pommel (acts like punch): weak against block, great stam dmg on opened opponent (punishes parry attempts)
* Ready/Blocking (same button as feint)
  * Hold Sword Up to Block Attacks
  * Startup Deflects (less stamina cost than blocking)
  * Releasing Parries (200ms startup to parry, 100ms release, requires read), high risk; releasing block can be scary
  * Kill Moves from weapons take from Stamina Instead
  * 
* Neutral Restores Stamina the Fastest (from posture)
  * 

### Stamina
* Short-Term Energy
* Loosely, "Health" of character -- loosing it often allows enemies to kill you.
* The posture and stance of the character tells you their stamina (trembling, hunched over, tongue out, etc. indicate low stamina)
* Magic also comes from stamina.
* Regenerates rather fast from posture

### Posture
* Measures long-term wellbeing.
* Each component is refilled by different parameters.
* Pools for each are not equal -- water empties quickly and is quick to refill, sleep takes time to refill and empty
* Used to refill stamina
* Necessary for multiple fights.
* Pulls from all elements equally when replenishing stamina.
* If an element is empty before the others, the unit can "persevere" on the other components, but at 4 times the cost 
  * Say they lack sleep and just exerted themselves, needing to replenish stamina. It will drain the food and water as normal, then for whatever amount of sleep is needed, the water and food are converted over, albeit at a 4 times cost. 
  * This conversion rate increases over time as that element remains empty. It also is not instantly reset upon some replenish, only over time is the conversion rate slowly lowered. This allows over exertion, but you'll have to make up for it later in a sense.
* The greater the posture, the greater the stamina refill rate, based on the least-filled element (another benefit of maintaining all elements).

#### Water - Hydration
#### Food - Hunger
#### Sleep - Awareness

#### Relax - Entertainment (NOT IMPLEMENTED)
* Perhaps a consideration for future.
* Can allow psyche elements and tactics; loyalty



### Submit or Kill?
At least two ways to defeat an opponent: kill them or make them surrender. Killing them allows them to be consumed and is generally an easier option. Additionally you can knok them out, taking them prisoner or killing them. Lastly you can turn them (from knockout to imprisonment or)

### Inverted Darksouls: Reactable Defense
Against AI, the player can almost always dominate. The AI uses various defenses, but the more active ones (at least for lesser troops) are reactable -- that is, you can counter them by watching their movements.

Trained units have unreactable defenses they can mixup, like the player, and as such require predictions. Higher "skilled" units, after a certain level, can also react to the defenses of weaker units. A 5-star CQC can ALWAYS beat a 1-star without taking a hit in a 1v1. This is done by increasing reaction speed variable over their levels(?)







## Joystick "Slasher"
In the vein of joystick shooters, albeit more close ranged.

Emphasizes...
* Movement
* Attacking

Less emphasis on tactical play, strategy and planning may still play a significant part.

### Line-Stabs and Arc-Swings

## Full Fighting System
Have written about, but is waaay too much for this game. Basically, implement a full fighting-game system, combined with transferring from 3D to 2D based on distance. Each limb is tied to a button (a la Tekken) and movement and strings are tied to them. 

## Lock-On System
A la For Honor and somewhat Souls.

* Simple vs Directioned (ie Right Attack vs Right to Left or Right to Top Attacks)

* Lock-On to a Target

## Pseudo Turn-Based System?



## Derpy Model
A physics-based system with "derpy" movements by applying vectors to limbs and allowing them to carry the body strictly. Attacks are vector-based in either applying damage or they knock each other about and perhaps off the map.

Could be applied to only sheep to contrast their derpiness with more finesse from the wolves.


### Examples
* Human Fall Flat
* Gang Beasts