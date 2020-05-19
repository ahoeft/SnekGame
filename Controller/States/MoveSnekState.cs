
namespace Snek.Controller.States
{
    using View.Renderers;
    using Model;
    using Microsoft.Xna.Framework.Input;

    public class MoveSnekState : State
    {
        public MoveSnekState(State nextState)
            :base(nextState) { }

        public override void Execute()
        {
            var keyboard = Keyboard.GetState();
            if(keyboard.IsKeyDown(Keys.Left)) {
                Garden.player.Direction = Direction.Left;
            }
            if(keyboard.IsKeyDown(Keys.Right)) {
                Garden.player.Direction = Direction.Right;
            }
            if(keyboard.IsKeyDown(Keys.Up)) {
                Garden.player.Direction = Direction.Up;
            }
            if(keyboard.IsKeyDown(Keys.Down)) {
                Garden.player.Direction = Direction.Down;
            }

            if(Garden.player.Direction == Direction.Right) {
                Garden.player.X = Garden.player.X + Garden.player.Speed;
            }
            if(Garden.player.Direction == Direction.Left) {
                Garden.player.X = Garden.player.X - Garden.player.Speed;
            }
            if(Garden.player.Direction == Direction.Up) {
                Garden.player.Y = Garden.player.Y - Garden.player.Speed;
            }
            if(Garden.player.Direction == Direction.Down) {
                Garden.player.Y = Garden.player.Y + Garden.player.Speed;
            }
            bool collisionDetected = Garden.player.X > 749 || Garden.player.Y > 549 || Garden.player.X < 1 || Garden.player.Y < 1;
            if (collisionDetected) {
                StateMachine.ChangeState();
            }
        }
    }
}