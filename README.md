This is A 3-D game called "Edgy Sphere", made using Unity and C#
=======

This is my first time programming a 3-D PC game using Unity. It uses C# scripts to execute all the actions. I have also used gitignore to ignore all the .meta files

Basic Overview: This is a 3 dimensional game. It involves a player character that can be controlled using WASD keys. The player's goal is to reach an endpoint and advance to the next level. C# is used to apply force and other physics actions. At the same time, most of the heavy lifting is done by Unity to add various materials as well as graphics in later levels. It is also useful in adding physics objects and toggling the amount of force the player will receive along with the velocity change.

The functionality of each C# file is described below;   

playermovement.cs : A constant forward force is added using FixedUpdate. GetKey is used to apply a force on each side (This can be further oprimized using boolean values in a larger scale project later) but this results in a very slow transition in the direction due to the force required to overcome the existing speed. Thus, I also added a value that directly changes velocity and defaults it to 0. This script also has the functionality to end the game if the player falls of the edge of the field.

followplayer.cs : This anchors the camera to the player block. Although, the camera should not be falling with the player of the edge. Thus, the offset is added.

Score.cs : This keeps track of the players score by displaying text in context to the player's y position.

PlayerCollision.cs : This notifies unity when the player collides with an obstacle and restarts the level.

GameManager.cs : This ensures that the game restarts when a player collides with the object as well as handling various misc functions.

EndTrigger.cs : This acts as a trigger when the player passes the endpoint for a level. This tells Unity to play the next level animation.

Nextlevel.cs : It pushes the scene forward by one to load next scene.

StartGame.cs, Credits.cs : These start and end the game.
