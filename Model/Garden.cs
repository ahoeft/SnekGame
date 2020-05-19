namespace Snek.Model {
    using Players;

    public static class Garden {
        public static Player player;

        public static void InitializeGarden() {
            player = new Player();
        }
    }

}