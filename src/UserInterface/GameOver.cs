using Godot;
using System;

public class GameOver : MarginContainer
{

    public override void _Ready()
    {

    }

    public void OnPlayAgainPressed()
    {
        GetTree().ChangeScene("res://src/Levels/Level.tscn");
    }
}
