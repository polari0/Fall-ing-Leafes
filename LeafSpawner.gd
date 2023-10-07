extends Node2D

var leaf_scene = preload("res://ScenePrefabs/leaf.tscn") 


func _on_spawn_timer_timeout():
	var leaf = leaf_scene.instantiate();
	leaf.position = Vector2(randf_range(-500, 500), randf_range(0, -250));
	add_child(leaf);
