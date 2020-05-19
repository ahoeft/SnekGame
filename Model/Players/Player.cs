namespace Snek.Model.Players
{
    public class Player
    {
        private int x;
        private int y;
        private int size;
        private Direction direction;
        private int speed;

        public int Size { get => size; set => size = value; }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public Direction Direction { get => direction; set => direction = value; }
        public int Speed { get => speed; set => speed = value; }

        public Player()
        {
            Size = 1;
            X = 1;
            Y = 1;
            Direction = Direction.Right;
            Speed = 1;
        }
    }
}