using Godot;
using System;

// Code by NyanRay64 =3

// this is the first implementation of the tasks/puzzles from the game, some of this puzzles are made in my own engine
// wich emulate the graphics from an atari 2600, using pascal

public partial class Open : Node
{
	string path = OS.GetExecutablePath().GetBaseDir();
	string exe = string.Empty;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {}
	
	private void run(string executable, bool wait) {
		exe = path + executable;
		OS.Execute(exe, new string[] { });
	}
	
	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) {}
}
