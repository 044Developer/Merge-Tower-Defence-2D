# Merge-Tower-Defence-2D

# Unity Developer Test Project

## Unity Version

**Unity 2021.3.21f1**

## Frameworks

**VContainer**

## Gameplay Overview

# Field 

We play on a field of 10 x 10 tiles. 
Where in the middle of this plain we spawn a build area of 2x2 or 3x3 tiles.
Around this building area, we have a road for our enemies, which goes close to our build area with 1 tile offset.
The road for our enemies will be dynamically created on level start.

# Defence Towers

Our defense towers are dice, with a power of 1 to 6.
We can buy only a tower with a power of 1, just drop this tower from the bottom menu on the build area.
To upgrade our dice, we need to merge them with the dice of the same power.
When dice are merged, they upgrade and shoot with new power.
Dices could be merged till they get upgraded to level 6.

The shoot area of each dice will be different, it grows when the dice upgrades.
The shoot area could be displayed as a circle below the clicked dice.

# Enemies

We have 2 types of Enemies:

-Big - slow enemy, with a lot of health and damage.
-Small - fast enemy, with low health and damage.

They run the road until our base and after perform attack action.

There will be different waves of enemies, and the size and count of enemies will be configured in a config file.
