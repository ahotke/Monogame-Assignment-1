using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame_Assignment_1
{
    public class Game1 : Game
    {
        Texture2D papa, kyle, pizza_background;

        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            papa = Content.Load<Texture2D>("PapaLouie");
            kyle = Content.Load<Texture2D>("Kyle");
            pizza_background = Content.Load<Texture2D>("Pizza_Background");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.IndianRed);

            // TODO: Add your drawing code here

            _spriteBatch.Begin();
            _spriteBatch.Draw(pizza_background, new Vector2(0, 0), Color.White);
            _spriteBatch.End();

            for (int a = 0; a < 10; a++)
            {

                for (int i = 0; i < 40; i++)
                {

                    _spriteBatch.Begin();
                    _spriteBatch.Draw(papa, new Vector2(0 + i * 40, 0 + a * 50), Color.White);
                    _spriteBatch.Draw(kyle, new Vector2(20 + i * 40, 0 + a * 50), Color.White);
                    _spriteBatch.End();

                    base.Draw(gameTime);
                }

            }
        }
    }
}
