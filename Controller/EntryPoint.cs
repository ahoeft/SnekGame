namespace Snek
{
    public static class EntryPoint {
        public static SnekGame game;
        static void Main() {
            using(game = new SnekGame())
                game.Run();
        }
    }
}