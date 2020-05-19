namespace Snek.Model.Players
{
    public class Player
    {
        private int size;
        private Direction direction;
        private int speed;
        private Position snakeHead;
        private Position snakeTail;

        public int Size { get => size; set => size = value; }
        public Direction Direction { get => direction; set => direction = value; }
        public int Speed { get => speed; set => speed = value; }
        public Position SnakeHead { get => snakeHead; set => snakeHead = value; }
        public Position SnakeTail { get => snakeTail; set => snakeTail = value; }

        public Player()
        {
            Size = 1;
            SnakeHead = new Position(51, 1);
            SnakeTail = new Position(1, 1);
            Direction = Direction.Right;
            Speed = 1;
        }
    }
}