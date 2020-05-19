namespace Snek.View.Renderers {
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;
    using UI;
    using Model;

    public class MonoGameRenderer : AbstractRenderer {
        private ContentManager Content = EntryPoint.game.Content;
        private SpriteBatch SpriteBatch;
        private PlayerUI snekPlayer;
        private SpriteFont font;
        public string NotificationText;

        public MonoGameRenderer()
        {
            this.snekPlayer = UIInitializer.CreatePlayerUI(Content);
            this.font = Content.Load<SpriteFont>("Font");
            this.NotificationText = "It Begins.";
        }

        public override void DrawScreen()
        {
            this.SpriteBatch = EntryPoint.game.SpriteBatch;
            snekPlayer.Draw(SpriteBatch);
            SpriteBatch.DrawString(font, NotificationText,new Vector2(105,105), Color.Black);
            MovePlayer();
        }

        public override void MovePlayer()
        {
            if(Garden.gameOver) {
                NotificationText = "Game Over!";
            } else {
                snekPlayer.Head.Rectangle.X = Garden.player.SnakeHead.X; 
                snekPlayer.Head.Rectangle.Y = Garden.player.SnakeHead.Y; 
                snekPlayer.Tail.Rectangle.X = Garden.player.SnakeTail.X; 
                snekPlayer.Tail.Rectangle.Y = Garden.player.SnakeTail.Y; 
                NotificationText = Garden.player.SnakeHead.X.ToString() + " " + Garden.player.SnakeHead.Y.ToString();
            }
        }
    }
}