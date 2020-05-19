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
                snekPlayer.Sprite.Rectangle.X = Garden.player.X; 
                snekPlayer.Sprite.Rectangle.Y = Garden.player.Y; 
                NotificationText = Garden.player.X.ToString() + " " + Garden.player.Y.ToString();
            }
        }
    }
}