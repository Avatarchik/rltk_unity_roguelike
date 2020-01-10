# Introduction
The goal of this tutorial is pretty much to create a Unity version of TheBracket's [excellent roguelike tutorial in Rust](https://bfnightly.bracketproductions.com/rustbook/chapter_1.html). For the most part I will be trying to re-create each part of the original tutorial - except in Unity. 

This tutorial assumes a decent knowledge of how to work with Unity and a some 
experience with C# or programming in general. If you've never coded before then 
this is probably not a good place to start. I will generally not be explaining 
non-Unity related C# code.

With that being said I will also be using Unity's ECS and Jobs systems. These 
are relatively new so I will try to give an overview of what's happening if we 
hit anything too complicated.

## Project Structure
The project is structured so that each example will sit in it's own folder in 
the assets directory. A single Unity project can be quite large on disk so it's not 
recommended to try and create a separate project for each tutorial. Instead we'll 
divide each tutorial up by scene. In the folder for each tutorial you'll find the 
readme for that particular part and a subfolder with a completed example. 

If you want to read the tutorials locally you'll probably want some kind of MD reader, 
otherwise I would recommend just viewing them on github.

If you want to start from a fresh project you'll need to ensure you have RLTK, 
whether installed in your assets folder or via the package manager. You can see 
details on how to do that 
[in the RLTK repository](https://github.com/sarkahn/rltk_unity#how-to-get-it).

Now without further ado you can start the first tutorial in [Part 1 - Hello World](Part1/Part1-HelloWorld.md).