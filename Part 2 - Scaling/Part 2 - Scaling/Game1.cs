using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Part_2___Scaling
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Rectangle head, eye1, eye2, blackEye1, blackEye2, mouth;
        Texture2D  whiteBackroundTexture, circleTexture, squareTexture;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
           
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here\
            head = new Rectangle(0, 0, 600, 600);

            eye1 = new Rectangle(150, 150, 50, 50);
            eye2 = new Rectangle(350, 150, 50, 50);

            blackEye1 = new Rectangle(160, 150, 20, 20);
            blackEye2 = new Rectangle(360, 150, 20, 20);

            mouth = new Rectangle(150, 400, 300, 40);

            _graphics.PreferredBackBufferWidth = 600; // Sets the width of the window
            _graphics.PreferredBackBufferHeight = 600; // Sets the height of the window
            _graphics.ApplyChanges(); // Applies the new dimensions
            
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            circleTexture = Content.Load<Texture2D>("circle");
            squareTexture = Content.Load<Texture2D>("rectangle");
            whiteBackroundTexture = Content.Load<Texture2D>("white+square");
            
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
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(whiteBackroundTexture, new Rectangle(0, 0, 600, 600), Color.White);
            
            _spriteBatch.Draw(circleTexture, head, Color.Red);
            _spriteBatch.Draw(circleTexture, eye1, Color.White);
            _spriteBatch.Draw(circleTexture, eye2, Color.White);

            _spriteBatch.Draw(circleTexture, blackEye1, Color.Black);
            _spriteBatch.Draw(circleTexture, blackEye2, Color.Black);

            _spriteBatch.Draw(squareTexture, mouth, Color.White);

            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}