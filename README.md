# 🔎 Maze Town
This is a simple C# Unity repository which is a maze game where the player has to find the exit while dodging obstacles that are dropping from the sky.

## Demo
https://github.com/xKarinSan/mazetown/assets/47315402/0184a785-b8a9-46e7-9e32-56bed908eac4


## Directory
``` bash
housetour (root of the project)
├- Assets
  ├- GameObjects 
    ├- Maze 
      ├- General 
      ├- Maps 
      ├- Markers
      ├- Paths 
    ├- Characters 
  ├- Materials 
  ├- Scenes
  ├- Scripts
    ├- General
    ├- Map 
    ├- Projectiles 
    ├- Player 
```
### More info on the directory
**NOTE: More info for each given folder below**

```Assets```
- ```GameObjects```: Where most of the prefabs will be at
  - ```Maze```: Prefabs that are used to build the maze in this project
    - ```General```: Smaller 'blocks' that were used to build the maze
    - ```Maps```: A sample of a maze map
    - ```Markers```: Markers for the maze (start & end point)
    - ```Paths```: Different types of maze cells
  - ```Characters```: This is where any character prefabs will be at
  - ```Projectiles```: This where the projectile prefabs will be at (for players and enemy mobs)
  - ```Materials```: Materials used across various GameObjects
  - ```Scenes```: Where scenes are stored; usually for different screens
  - ```Scripts```: Where the C# codes are located at
    - ```General```: Scripts that are used across any GameObject
    - ```Map```: Scripts that will be used within the map
    - ```Projectiles```: Scripts that are used for any projectiles/obstacles
    - ```Player```: Scripts that are used for the player

## Setup
1. Clone this repository
2. Run this project inside Unity (make sure to use the latest version whenever possible).
3. Have fun!

## Rules
- Reach the exit of the maze before you run out of lives
- You lose 1 life when you hit an obstacle

## Controls
1. Mouse movement to view various maps
2. WASD to move.
