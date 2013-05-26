namespace rpgsim
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;

    public class Game1 : Microsoft.Xna.Framework.Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;

        private Map map = new Map();

        public Game1(OptionsDialog options)
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferHeight = 720;
            graphics.PreferredBackBufferWidth = 1280;
            Content.RootDirectory = "Content";

            float hp, strength, range, speed, x, y;

            hp = float.Parse(options.hpUnit1_Text.Text);
            strength = float.Parse(options.strUnit1_Text.Text);
            range = float.Parse(options.rangeUnit1_Text.Text);
            speed = float.Parse(options.speedUnit1_Text.Text);
            x = int.Parse(options.x_Unit1_Text.Text);
            y = int.Parse(options.y_Unit1_Text.Text);
            var color = (System.Drawing.Color)options.Unit1_Team.SelectedItem;
            map.Add(new Unit(x, y, new Team(new Color(color.R, color.G, color.B)), strength, hp, range, speed));

            hp = float.Parse(options.hpUnit2_Text.Text);
            strength = float.Parse(options.strUnit2_Text.Text);
            range = float.Parse(options.rangeUnit2_Text.Text);
            speed = float.Parse(options.speedUnit2_Text.Text);
            x = int.Parse(options.x_Unit2_Text.Text);
            y = int.Parse(options.y_Unit2_Text.Text);
            color = (System.Drawing.Color)options.Unit2_Team.SelectedItem;
            map.Add(new Unit(x, y, new Team(new Color(color.R, color.G, color.B)), strength, hp, range, speed));

            color = System.Drawing.Color.Red;
            // map.Add(new Unit(200, 200, new Team(new Color(color.R, color.G, color.B)), strength, hp, range, speed));
            map.GenerateTargets();

            this.IsMouseVisible = true;
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
        }

        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
            {
                this.Exit();
            }

            map.Update((float)gameTime.ElapsedGameTime.TotalSeconds);

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            
            spriteBatch.Begin();
            map.Draw(spriteBatch);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
