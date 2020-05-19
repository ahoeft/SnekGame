namespace Snek
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;
    using Controller;
    using View.Renderers;

    public class SnekGame : Game
    {
        public GraphicsDeviceManager graphics;
        public SpriteBatch SpriteBatch;
        public MonoGameRenderer Renderer;
        
        public double Elapsed;

        public SnekGame()
        {
            Renderer = new MonoGameRenderer();
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            graphics.PreferredBackBufferHeight = 600;
            graphics.PreferredBackBufferWidth = 800;
        }

        protected override void Initialize()
        {
            StateMachine.Initialize();
            StateMachine.ChangeState();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            SpriteBatch = new SpriteBatch(GraphicsDevice);
        }

        protected override void Update(GameTime gameTime)
        {
            Elapsed = (double) gameTime.ElapsedGameTime.TotalSeconds;
            StateMachine.CurrentState.Execute();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            SpriteBatch.Begin();
            StateMachine.CurrentState.Draw(Renderer);
            SpriteBatch.End();
            base.Draw(gameTime);
        }
    }
}