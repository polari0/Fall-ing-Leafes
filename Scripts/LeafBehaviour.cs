using Godot;
using System;

public partial class LeafBehaviour : RigidBody2D
{

	private Vector2 leafDropDireaction;
	private float leafDropDirX;
	private float leafDropDirY;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		leafDropDireaction = new Vector2(0, 1f);
		base.AddConstantForce(leafDropDireaction);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.

	public override void _PhysicsProcess(double delta)
	{
		base._PhysicsProcess(delta);
	}

	private void _on_body_entered(Node body)
	{
		if (body.IsInGroup("Wind"))
		{
			GD.Print("WHY");
		}
	}

}






