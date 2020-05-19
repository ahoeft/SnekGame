namespace snek.Model.Snek
{
    public class Snek
    {
        private int x;
        private int y;
        private int size;

        public int Size { get => size; set => size = value; }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public Snek()
        {
            Size = 1;
            X = 0;
            Y = 0;
        }
    }
}