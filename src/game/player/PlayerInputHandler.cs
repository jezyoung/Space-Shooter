using Godot;

namespace SpaceShooter.game
{
    public class PlayerInputHandler : Node
    {
        public float HorizontalInput { get; private set; }
        public float VerticalInput { get; private set; }

        public override void _PhysicsProcess(float delta)
        {
            CheckForHorizontalInput();
            CheckForVerticalInput();
        }
        
        private void CheckForHorizontalInput() =>
            HorizontalInput = Input.GetActionStrength("forward") - Input.GetActionStrength("backward");
        private void CheckForVerticalInput() =>
            VerticalInput = Input.GetActionStrength("down") - Input.GetActionStrength("up");
    }
}