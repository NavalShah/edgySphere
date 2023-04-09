# edgySphere
This is my first experience programming a 3-D PC game using Unity. It uses C# scripts to execute all the actions. I have also used gitignore to ignore all the .meta files      
I have described the functionality of each C# file below;   
playermovement.cs : A constant forward force is added using FixedUpdate. GetKey is used to apply a force on each side (This can be further oprimized using boolean values in a larger scale project later) but this results in a very slow transition in the direction due to the force required to overcome the existing speed. Thus, I also added a value that directly changes velocity and defaults it to 0. This script also has the functionality to end the game if the player falls of the edge of the field.
