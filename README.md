# INFR 3110 Make Up Assignment
---
### Name : John Philip Underwood
### Student Number : 100982375
---
# Object Oriented Programming
---
### Description
<!-- Briefly describe the classes, their relationships, and how object-oriented
programming principles are demonstrated in your implementation. -->
The Singleton base class derives the GameManager and FruitManager classes, as the game manager generally handles game state related tasks, and the fruit manager only calls on the fruit spawner. They make them global singular instances. 
The Spawner class is the template class that derrives the FruitSpawner and PlayerSpawner classes, with the FruitSpawener using polymorphism by having to pick 1/3 items to spawn in a random range of coordinates, while the player spawner simply respawns the player in game upon hitting R on death.
The SnakeController and Fruit scripts are by themselves.
## UML Diagram
<!-- Attach your UML diagram here -->
---
# Singleton Pattern
---
### Purpose
<!-- Explain why the Singleton pattern is appropriate for this particular system.
-->
Game Manager handles tracking score, high score, and allowing the player to respawn. Fruit Manager handles calling on the fruit spawner script. The Game Manager needs only one instance of itself to track everything in game, and the Fruit Manager needs to be the only Singleton to handle spawning in the fruits so it doesnt' clutter up the functionality of the Game Manager so it can focus on other things in tracking score and game states.
### Implementation
<!--Describe how the Singleton pattern is implemented in your project. -->
The Singleton class is created first, so the GameManager and FruitManager class derrive off it as instances. 
---
# Factory Pattern
---
### Purpose
<!-- Explain why the Factory pattern is appropriate for this particular system. -->
The Factory pattern is best used for spawning in entities without the script calling on it being concerned of its behavior. So, providing abstraction.
### Implementation
<!-- Describe how the Factory pattern is implemented in your project. -->
The FruitSpawner has public references for the 3 different items to spawn in in a random range of 0-2 to pick from to determine what it uses and spawns it in when called. The PlayerSpawner is used when the Game Manager calls on it to respawn the player. 
---
# References
---
<!-- Identify sources used to create any gameplay logic or programming pattern
implementations. -->
https://docs.unity.com/en-us/engine/6000.6/script-reference/unityengine/random/range
https://discussions.unity.com/t/random-is-is-ambiguous-reference-between-unity-random-and-system-random/796856
