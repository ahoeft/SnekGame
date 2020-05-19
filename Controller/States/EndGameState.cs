
namespace Snek.Controller.States
{
    using View.Renderers;
    using Model;

    public class EndGameState : State
    {
        public EndGameState(State nextState)
            :base(nextState) { }

        public override void Execute()
        {
            Garden.gameOver = true;
        }
    }
}