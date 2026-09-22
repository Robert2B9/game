using Godot;
using System;

namespace game.scripts.active
{
	public partial class Player : CharacterBody3D
	{
		private const float StepDistance = 5.0f;
		private const float TurnDegrees = 90.0f;
		
		public override void _UnhandledInput(InputEvent @event)
		{
			if (@event.IsActionPressed("move_forward")) _Move(Vector3.Forward);
			else if (@event.IsActionPressed("move_backward")) _Move(Vector3.Back);
			else if (@event.IsActionPressed("strafe_left")) _Move(Vector3.Left);
			else if (@event.IsActionPressed("strafe_right")) _Move(Vector3.Right);
			else if (@event.IsActionPressed("turn_left")) _Turn(-TurnDegrees);
			else if (@event.IsActionPressed("turn_right")) _Turn(TurnDegrees);
		}

		private void _Move(Vector3 localDirection)
		{
			SetGlobalPosition(GetGlobalPosition() + localDirection * StepDistance);
		}

		private void _Turn(float degrees)
		{
			RotateX(degrees);
		}
	}
}
