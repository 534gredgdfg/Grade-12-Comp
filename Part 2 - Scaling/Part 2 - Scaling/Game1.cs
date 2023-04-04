using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Part_2___Scaling
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Rectangle head, eye1, eye2, blackEye1, blackEye2, mouth, redSpot1, redSpot2, nose;
        Texture2D  whiteBackroundTexture, circleTexture, squareTexture;
        SpriteFont speakingFont;
        int movingEye1 = 200;       
        int movingEye2 = 350;
        int  moved;
        int moving = 1;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

           
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here\

            head = new Rectangle(50, 0, 500, 600);

            eye1 = new Rectangle(200, 150, 60, 50);
            eye2 = new Rectangle(350, 150, 60, 50);

            blackEye1 = new Rectangle(210, 150, 20, 20);
            blackEye2 = new Rectangle(360, 150, 20, 20);

            redSpot1 = new Rectangle(100, 300, 80, 80);
            redSpot2 = new Rectangle(420, 300, 80, 80);

            mouth = new Rectangle(150, 450, 300, 65);
            nose = new Rectangle(275, 250, 50, 100);

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
            speakingFont = Content.Load<SpriteFont>("Text");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            
            movingEye1 += moving;
            movingEye2 += moving;
            moved += 1;
            if (moved >= 40)
            {
                
                moving *= -1;
                moved = 0;
            }


            blackEye1 = new Rectangle(movingEye1, 160, 20, 20);
            blackEye2 = new Rectangle(movingEye2, 160, 20, 20);
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            
            
            _spriteBatch.Draw(circleTexture, head, Color.White);
            _spriteBatch.Draw(circleTexture, eye1, Color.Gray);
            _spriteBatch.Draw(circleTexture, eye2, Color.Gray);

            _spriteBatch.Draw(circleTexture, blackEye1, Color.Black);
            _spriteBatch.Draw(circleTexture, blackEye2, Color.Black);

            _spriteBatch.Draw(circleTexture, redSpot1, Color.Red);
            _spriteBatch.Draw(circleTexture, redSpot2, Color.Red);

            _spriteBatch.Draw(circleTexture, mouth, Color.Gray);
            _spriteBatch.Draw(squareTexture, nose, Color.Gray);

            _spriteBatch.DrawString(speakingFont, "Owen", new Vector2(10, 10), Color.Black);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}