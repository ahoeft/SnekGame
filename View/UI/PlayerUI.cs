namespace Snek.View.UI
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public class PlayerUI
    {
        public Sprite Head { get; set; }
        public Sprite Tail { get; set; }

        public PlayerUI(Sprite head, Sprite tail)
        {
            this.Head = head;
            this.Tail = tail;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.Head.Image, this.Head.Rectangle, Color.White);
            spriteBatch.Draw(this.Tail.Image, this.Tail.Rectangle, Color.White);
        }
    }
}