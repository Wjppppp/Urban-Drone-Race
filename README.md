# Urban-Drone-Race

## 1. Abstract



## 2. Environment and Building

### 2.1 Environment
Unity 2020.3.22f1(LTS)
Visual Studio 2019
### 2.2 How to Build
Open Unity Editor - Projects - ADD - Import our project - Assets - Scenes - UrbanRace


## 3. Tool Introduction

### 3.1 Unity

[Unity](https://en.wikipedia.org/wiki/Unity_(game_engine)) is a cross-platform game engine developed by Unity Technologies. Unity3D consists of a UnityEngine and a UnityEditor. 

#### 3.1.1 Unity Engine

The engine contains software components for the most common and recurring tasks in game development. The topics covered by the engine include sound, graphics, physics and network functions. The engine supports C#, Boo, and JavaScript for script programming.

#### 3.1.2 Unity Editor

Unity Editor serves as an integrated development environment with a project panel for scripts and other components, a hierarchical object inspector containing the game scene setup and a game preview window (Fig.3.1).

A. The Toolbar
B. The Hierarchy window
C. The Game view
D. The Scene view
E. The Inspector window
F. The Project window
G. The status bar

#### 3.1.3 Unity Game’s structure


#### 3.1.4 Working in Unity

Scene
Scenes are where you work with content in Unity. They are assets that contain all or part of a game or application.
GameObjects
The GameObject is the most important concept in the Unity Editor. Every object in your game is a GameObject
Prefabs
The Prefab Asset acts as a template from which you can create new Prefab instances in the Scene.
Layers
Layers in Unity define which GameObjects can interact with different features and one another.

### 3.2 Mapbox

The project uses Mapbox Unity SDK as the main provider for 3D city maps. 

#### 3.2.1 City Simulator

https://docs.mapbox.com/unity/maps/examples/city-simulator/
This is a scene of a selected coordinate or city’s name with 3D features  such as buildings and terrain with elevation. To visualise a map, this example scene comes ready with the CitySimulatorMap prefab.
Users can change location, image, terrain and map layers in this prefab. The scene can be extended to add any other custom features that you want.

#### 3.2.2 Base Map

///////////////////////////////////////////////////

### 3.3 Blender

The drone models used in this project are manually modelled in Blender 3D from the basic cubes.
red - Outliner
Green - Properties
Yellow - 3D view
Here are some of the models we made using Blender 3D.

## 4. Main functions implemented

### 4.1 Overview

Currently the following features have been implemented:
Map selection
Drone model selection
Drone health decrease with the collision with buildings
Mini-map
Start menu
Checkpoints mode

### 4.2 Script Introduction

StartGame.cs - Controls the start of the game and the display of the interface.
Score.cs - The score begins as zero at the start of the game, refresh throughout the game, and display final score at the end.
TextScore.cs - Show score during the game.
Timer.cs - The countdown starts when the game starts, the game ends when the countdown is zero.
DroneMovementScript.cs - Control the movement of the drone by keyboard.
MiniMapCam.cs - The minimap shows the drone's current location on a 2D map from an orthographic perspective.
MiniMapCityName.cs - Show the name of the current city.
HealthBar.cs - Show the current health of the drone.
DroneHealth.cs - At the beginning of the game, the healthy bar is full. When the drone collides with other objects in the scene, it will lose blood. When the healthy bar is zero, the game ends.
CheckPoint.cs - Three different types of checkpoints randomly generated as the game starts every time, and automatically destroyed as the game ends. The checkpoint will disappear when a drone crosses and changes the score.
ChangeDrone.cs - Change of drone model.
ChangeCity.cs - Change of city model.
BladeRotation.cs - Uav blade rotation animation.
ExitGame.cs - Quit the game.

### 4.3 Controls

Drone can be controlled by using WASD and IJKL keys.

## 5. Resources

https://unity.com/
https://docs.unity3d.com/ScriptReference/index.html
https://docs.unity3d.com/Manual/index.html
https://docs.mapbox.com/unity/maps/guides/
https://www.blender.org/

---------------------------------------------