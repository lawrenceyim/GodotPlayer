using Godot;
using System;

public partial class PlayerInputHandler : Node, IInputHandler {
	[Export] PlayerMovement playerMovement;
	
	public override void _Ready() {

	}

	public override void _Process(double delta) {
		HandleInput();
	}

	public void HandleInput() {
		Vector2 movementVector = new Vector2(0, 0);
		if (Input.IsActionPressed("MoveLeft")) {
			movementVector.X -= 1;
		}
		if (Input.IsActionPressed("MoveRight")) {
			movementVector.X += 1;
		}
		if (Input.IsActionPressed("MoveUp")) {
			movementVector.Y -= 1;
		}
		if (Input.IsActionPressed("MoveDown")) {
			movementVector.Y += 1;
		}
		playerMovement.MoveByVector2(movementVector);
	}
}
