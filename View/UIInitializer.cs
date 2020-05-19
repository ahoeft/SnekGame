
namespace Snek.View.UI {
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;

    public static class UIInitializer {
        public static PlayerUI CreatePlayerUI(ContentManager contentManager) {
            Texture2D head = contentManager.Load<Texture2D>("snakehead");
            Texture2D tail = contentManager.Load<Texture2D>("snaketail");
            Rectangle rectangle1 = new Rectangle(1,1,50,50);
            Rectangle rectangle2 = new Rectangle(51,1,50,50);
            Sprite headSprite = new Sprite(rectangle2, head);
            Sprite tailSprite = new Sprite(rectangle1, tail);
            return new PlayerUI(headSprite, tailSprite);
        }
    }
}