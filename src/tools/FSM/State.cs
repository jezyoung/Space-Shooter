using Godot;

namespace SpaceShooter.tools.FSM
{
    public class State
    {
        protected float startTime;

        public virtual void Enter()
        {
            startTime = OS.GetTicksUsec();
        }

        public virtual void Exit()
        {
            
        }

        public virtual void LogicUpdate(float delta)
        {
            
        }

        public virtual void PhysicsUpdate(float delta)
        {
            
        }
        
    }
}