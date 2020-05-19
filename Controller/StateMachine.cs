using System.Collections.Generic;
using Snek.Controller.States;

namespace Snek.Controller
{
    public static class StateMachine 
    {
        public static State CurrentState;
        public static Dictionary<string, State> States = new Dictionary<string, State>();

        private static InitialState initialState;
        private static MoveSnekState moveSnekState;
        private static EndGameState endGameState;

        public static void Initialize () {
            endGameState = new EndGameState(initialState);
            moveSnekState = new MoveSnekState(endGameState);
            initialState = new InitialState(moveSnekState);

            States.Add("InitialState", initialState);
            States.Add("MoveSnekState", moveSnekState);
            States.Add("EndGameState", endGameState);
            CurrentState = initialState;
        }
        public static void ChangeState() {
            CurrentState = CurrentState.NextState;
        }
    }
    
}