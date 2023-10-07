using Godot;
using System;

public partial class LeafCollisionCheck : Area2D
{
    [Export]
    public int healthLeft = 10;
    [Export]
    public TextEdit healthleftText;


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
		}
	}

}


