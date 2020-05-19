namespace Snek.Controller.States
{
    using View.Renderers;
    using Model;

    public class InitialState : State
    {
        public InitialState(State nextState)
            :base(nextState) { }

        public override void Execute()
        {
            Garden.InitializeGarden();
        }
    }
}