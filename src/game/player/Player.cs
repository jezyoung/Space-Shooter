using Godot;

namespace SpaceShooter.game
{
    public class Player : KinematicBody2D
    {
        [Export()] private NodePath _inputHandlerPath;
        
        private PlayerInputHandler _inputHandler;

        public override void _Ready()
        {
            _inputHandler = GetNode(_inputHandlerPath) as PlayerInputHandler;
        }
    }
}
