using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace Part_1___Intro_to_MonoGame
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        int flyerX = 220;
        int bushX = 0;
        Texture2D dinoTeaxture, raptorTeaxture, volcanoTeaxture, fylerTeaxture, runnerTeaxture, backroundTeaxture, bushTeaxture;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            
            _graphics.PreferredBackBufferWidth = 1200; // Sets the width of the window
            _graphics.PreferredBackBufferHeight = 800; // Sets the height of the window
            _graphics.ApplyChanges(); // Applies the new dimensions
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            

            dinoTeaxture = Content.Load<Texture2D>("dino");
            raptorTeaxture = Content.Load<Texture2D>("raptorDino");
            volcanoTeaxture = Content.Load<Texture2D>("Volcano");
            fylerTeaxture = Content.Load<Texture2D>("flyer");
            runnerTeaxture = Content.Load<Texture2D>("runner");
            backroundTeaxture = Content.Load<Texture2D>("windowsBackround");
            bushTeaxture = Content.Load<Texture2D>("greenBush");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            //Move flying dinosuar
            flyerX -= 1;
            if (flyerX <= -100)
                flyerX = 220;
            base.Update(gameTime);
            //
            
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            
            
            _spriteBatch.Draw(backroundTeaxture, new Vector2(0, 0), Color.White);
            
            
            _spriteBatch.Draw(dinoTeaxture, new Vector2(10, 350), Color.White);
            _spriteBatch.Draw(raptorTeaxture, new Vector2(300, 600), Color.White);           
            _spriteBatch.Draw(fylerTeaxture, new Vector2(flyerX, 10), Color.White);
            _spriteBatch.Draw(volcanoTeaxture, new Vector2(500, 0), Color.White);
            _spriteBatch.Draw(runnerTeaxture, new Vector2(10, 600), Color.White);
            for (int i = -100; i < 1200; i += 120)
            {
                
                _spriteBatch.Draw(bushTeaxture, new Vector2(i, 700), Color.White);
            }

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}