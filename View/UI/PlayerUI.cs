namespace Snek.View.UI
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public class PlayerUI
    {
        public Sprite Sprite { get; set; }

        public PlayerUI(Sprite sprite)
        {
            this.Sprite = sprite;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.Sprite.Image, this.Sprite.Rectangle, Color.White);
        }
    }
}