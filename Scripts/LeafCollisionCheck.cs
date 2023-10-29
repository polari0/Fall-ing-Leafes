using Godot;
using System;

public partial class LeafCollisionCheck : Area2D
{
	[Export]
	private int healthLeft = 10;
	[Export]
	private TextEdit healthleftText;

	[Export]
	private Node wind;
	[Export]
	private Panel gameOver;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		healthleftText.Text = healthLeft.ToString();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	private void _on_body_entered(Node2D body)
	{
		if (body.IsInGroup("Leaf"))
		{
			body.SetProcess(false);
			healthLeft--;
			healthleftText.Text= healthLeft.ToString();
			if(healthLeft <= 0) {
				wind.SetProcess(false);
				gameOver.Visible= true;
			}
		}
	}

}


