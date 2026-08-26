# Knight
A `Weapon` class has been provided for you.

Create the following `Knight` class. 

For all of the data:
- decide if it should be a field or a property, and 
- decide upon the appropriate access modifiers

## Data:
---
- `Name`: Read-only string.
- `X`: an int, readable by external classes, privately writable
- `Y`: an int, readable by external classes, privately writable
- `CurrentPosition`: Read-only string. Provides a formatted string 
  representation of the knight's current position (X, Y).
- `MaximumHitPoints`: int, read-only and accessible only within this class.
- `CurrentHitPoints`: int, readable by external classes, 
  privately writable. Ensures that the hit points 
  are within the valid range (0 to MaximumHitPoints).
- `ASCII`: Read-only string. if alive `@"{._.} -{---"` if dead `"{-_-}"`
- `EquippedWeapon`: Weapon, readable and writable by external classes
- `_randomGenerator`: Static random number generator. Readable by this class only
 

## Methods:
- `Constructor`: Takes in name, maximumHitPoints and equippedWeapon
- `MoveLeft`: Decreases the `X`-coordinate of the knight by the specified distance.
- `MoveRight`: Increases the `X`-coordinate of the knight by the specified distance.
- `Attack`: Returns a number between `1` and the strength of the Weapon (inclusive). Hint: `randomGenerator.Next(EquippedWeapon.Strength) + 1`
- `Defend`: There is a 50% chance that the given damage will be taken off the CurrentHitPoints  

# Consider this scenario
I am developing a game and I would like to be able to play as a `Knight` or a `Monster`. In the future, I might want to play as another player (e.g. a `Wizard`).

`Knight`s and `Monster`s are very similar. The key differences are:
- Monster will not have a Weapon
- ASCII: will be different, if alive `@"^(;,;)^"` if dead `@"^(-,,,-)^"`
- Attack: much simpler, just returns 3
- Defend: the given damage is taken off the `CurrentHitPoints`  

Are you tempted to copy and paste the `Knight` class to make a `Monster` class? \
**Don't do it!!!** \
If you are ever copying and pasting code there is **always** a better way.
Plus what if we decide there should be other characters later on, for example, a Wizard.

I hope you are thinking what I am thinking, let's make a 
base class, named `Player`! \
... \
But wait, what is a `Player`? It is a very **abstract** idea. What would the ASCII be for a `Player`? There is no `Player` type in my game, only `Knight`s and `Monster`s. 

So I do not want to be able to instantiate a Player.

**Could we make it a `static` class?**
You cannot instantiate a `static` class. But this would not work, because then everything in the class must be `static`.

**Could we use an interface?**
You cannot instantiate an interface. But then we would lose the constructor and all the implementations of our members.

**Could we have an interface and a class?**
Yes, but then we have no way to be sure that players will inherit and implement both. Also, it is a bit messy.

**Could we create a class structure like so to force that both are used?**
```csharp
IPlayer
BasePlayer
Player: IPlayer, BasePlayer
```
No because Player would need to implement IPlayer

# The Solution: Abstract classes