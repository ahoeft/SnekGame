
namespace Snek.View.UI {
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;

    public static class UIInitializer {
        public static PlayerUI CreatePlayerUI(ContentManager contentManager) {
            Texture2D image = contentManager.Load<Texture2D>("snakehead");
            Rectangle rectangle = new Rectangle(0,0,50,50);
            Sprite sprite = new Sprite(rectangle, image);
            return new PlayerUI(sprite);
        }
    }
}