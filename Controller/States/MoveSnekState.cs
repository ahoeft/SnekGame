
namespace Snek.Controller.States
{
    using View.Renderers;
    using Model;

    public class MoveSnekState : State
    {
        public MoveSnekState(State nextState)
            :base(nextState) { }

        public override void Execute()
        {
            if(Garden.player.Direction == Direction.Right) {
                Garden.player.X = Garden.player.X + Garden.player.Speed;
            }
            if(Garden.player.Direction == Direction.Left) {
                Garden.player.X = Garden.player.X - Garden.player.Speed;
            }
            if(Garden.player.Direction == Direction.Up) {
                Garden.player.X = Garden.player.Y - Garden.player.Speed;
            }
            if(Garden.player.Direction == Direction.Down) {
                Garden.player.X = Garden.player.Y + Garden.player.Speed;
            }
            bool collisionDetected = Garden.player.X > 799 || Garden.player.Y > 599 || Garden.player.X < 1 || Garden.player.Y < 1;
            if (collisionDetected) {
                StateMachine.ChangeState();
            }
        }
    }
}