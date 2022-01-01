using SpaceShooter.tools.FSM;

namespace SpaceShooter.game
{
    public class PlayerState: State
    {
        protected Player player;
        protected PlayerStatemachine playerFSM;
        protected PlayerData playerData;
        protected string animName;

        public PlayerState(Player player, PlayerStatemachine playerFSM, PlayerData playerData, string animName)
        {
            this.player = player;
            this.playerFSM = playerFSM;
            this.playerData = playerData;
            this.animName = animName;
        }

        public override void Enter()
        {
            base.Enter();
            // GD.Print(animName);
            // player.AnimationFinished = false;
            // player.Animator.Play(animName);
        }

        public override void PhysicsUpdate(float delta)
        {
            base.PhysicsUpdate(delta);
        }
    }
}