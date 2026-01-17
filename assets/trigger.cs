using Godot;
using System;

// Code by NyanRay64 =3

public partial class trigger : Area2D
{
	private bool nearby = false;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {
		BodyEntered += OnBodyEntered;
		BodyExited += OnBodyExited;
	}

	private void OnBodyEntered(Node body) {
		if (body.Name == "Player") {
			nearby = true;
			GD.Print("player nearby");
		}
	}
	
	private void OnBodyExited(Node body) {
		if (body.Name == "Player") {
			nearby = false;
		}
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
