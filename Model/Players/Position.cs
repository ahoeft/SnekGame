namespace Snek.Model.Players {
    public class Position {
        private int x;
        private int y;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
    
}