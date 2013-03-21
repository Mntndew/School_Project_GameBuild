using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using H_Map;
using MntnNpc;
using System.IO;

namespace GameBuild
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        //Variable declaration
        public GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public SpriteFont spriteFont;
        
        public List<cNpc> Npcs = new List<cNpc>();

        cLighting testLight = new cLighting(new Rectangle(0, 0, 2000, 2000), 140, 20, new Color(245, 225, 170, 200)); //for ambient lighting 
        RenderTarget2D lightMask; //what he said ^

        Random rand = new Random();

        cCharacter character;

        //Debugging stuffs
        Texture2D collisionTex;
        Color collisionColor = new Color(100, 0, 0, 100);

        public TileMap map;

        public KeyboardState oldState;
        public KeyboardState keyState;

        Camera2d camera;

        int files = Directory.GetFiles(@"Content\npc\npc\").Length; //number of npc files in the npc directory
        string[] names;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.PreferredBackBufferHeight = 720;
            graphics.PreferredBackBufferWidth = 1280;
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            this.IsMouseVisible = true;
            character = new cCharacter(this);
            spriteFont = Content.Load<SpriteFont>("SpriteFont1");
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            collisionTex = Content.Load<Texture2D>("blackness");
            testLight.LoadTexture(Content, "lightTexture");
            lightMask = new RenderTarget2D(GraphicsDevice, GraphicsDevice.PresentationParameters.BackBufferWidth, GraphicsDevice.PresentationParameters.BackBufferHeight);
            map = Content.Load<H_Map.TileMap>("map test");
            map.tileset = Content.Load<Texture2D>("tileset");
            Console.WriteLine(map.mapName);
            camera = new Camera2d(GraphicsDevice.Viewport, map.mapWidth * map.tileWidth, map.mapHeight * map.tileHeight, 1f);
            #region Npc Loading
            names = new string[files];
            for (int i = 0; i < files; i++)
            {
                names[i] = Directory.GetFiles(@"Content\npc\npc\")[i];
                StreamReader reader = new StreamReader(names[i]);
                cNpc npc = new cNpc(reader.ReadLine(), reader.ReadLine(), int.Parse(reader.ReadLine()), int.Parse(reader.ReadLine()), int.Parse(reader.ReadLine()), int.Parse(reader.ReadLine()),
                    bool.Parse(reader.ReadLine()), bool.Parse(reader.ReadLine()), bool.Parse(reader.ReadLine()), bool.Parse(reader.ReadLine()), reader.ReadLine(), reader.ReadLine(),
                    bool.Parse(reader.ReadLine()), bool.Parse(reader.ReadLine()), bool.Parse(reader.ReadLine()), bool.Parse(reader.ReadLine()), int.Parse(reader.ReadLine()),
                    int.Parse(reader.ReadLine()), int.Parse(reader.ReadLine()), int.Parse(reader.ReadLine()), int.Parse(reader.ReadLine()), this);
                reader.Close();
                if (npc.isOnMap)
                {
                    Npcs.Add(npc);
                }
                
                Console.WriteLine(npc.mapName);
            #endregion
            }
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
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
                this.Exit();
            oldState = keyState;
            keyState = Keyboard.GetState();
            testLight.Update(character.position.X, character.position.Y);
            //Update dude
            if (true) //TODO: gamestates for making the game update objects logicly
            {
                character.Update(this, map, gameTime, oldState, GraphicsDevice);
            }
            camera.Pos = character.vectorPos;
            
            //Update NPCs 
            foreach (cNpc npc in Npcs)
            {
                if (npc.isOnMap)
                {
                    if (!npc.isInteracting)
                    {
                        npc.Update(character, map, this);
                    }
                    if (keyState.IsKeyDown(Keys.A) && oldState.IsKeyUp(Keys.A) && npc.canInteract)
                    {
                        if (npc.isInteracting)
                        {
                            npc.isInteracting = false;
                            npc.dialogue.isTalking = false;
                        }
                        else
                        {
                            npc.isInteracting = true;
                            npc.dialogue.isTalking = true;
                        }
                    }
                }
            }
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            //draws the lightmask to a separate render target
            GraphicsDevice.SetRenderTarget(lightMask);
            GraphicsDevice.Clear(Color.Black);
            spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.Additive);
            testLight.Draw(spriteBatch);
            spriteBatch.End();

            //draws out the world on the default back buffer
            GraphicsDevice.SetRenderTarget(null);
            GraphicsDevice.Clear(Color.Black);
            spriteBatch.Begin(SpriteSortMode.Immediate, null, null, null, null, null, camera.GetTransformation());
            map.DrawBackgroundLayer(spriteBatch, new Rectangle(0, 0, 1280, 720));
            map.DrawInteractiveLayer(spriteBatch, new Rectangle(0, 0, 1280, 720));
            character.Draw(spriteBatch);

            foreach (cNpc npc in Npcs)
            {
                //if (npc.isOnMap)
                {
                    npc.Draw(spriteBatch);
                    if (npc.isInteracting)
                    {
                        npc.dialogue.Draw(spriteBatch);
                    }
                    else
                    {
                        spriteBatch.DrawString(spriteFont, "" + npc.name, new Vector2(npc.position.X + (npc.position.Width / 2), npc.position.Y - 10), Color.Red);
                    }
                }
                
            }
            map.DrawForegroundLayer(spriteBatch, new Rectangle(0, 0, 1280, 720));
            spriteBatch.DrawString(spriteFont, "" + character.hp, new Vector2(character.position.X + (character.position.Width / 2), character.position.Y - 10), Color.Red);
            spriteBatch.End();
            // TODO: Add your drawing code here

            //draws out the light mask over the world, uses multiplication blending to create the effect
            BlendState blendState = new BlendState();
            blendState.ColorSourceBlend = Blend.Zero;
            blendState.ColorDestinationBlend = Blend.SourceColor;
            blendState.AlphaSourceBlend = Blend.Zero;
            blendState.AlphaDestinationBlend = Blend.SourceAlpha;
            spriteBatch.Begin(SpriteSortMode.Immediate, blendState);
            spriteBatch.Draw(lightMask, new Vector2(0, 0), Color.White);
            spriteBatch.End();

            float framerate = 1f / (float)gameTime.ElapsedGameTime.TotalSeconds;
            Console.WriteLine(framerate);
            base.Draw(gameTime);
        }
    }
}
#region stuff
/*    

     /MMMMMMMMM\\  \  /  //MMMMMMMMM\
    /NNNNNMMMMMN\\  ||  //NMMMMMNNNNN\
   /NNNNMMMMMMMMN\\ || //NMMMMMMMMNNNN\
  |NNMMMMMMMMMMMMMN\/\/NMMMMMMMMMMMMMNN|
  \NNNNNMMMMMMMMMNNN\/NNNMMMMMMMMNNNNNN/
    \NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN/
      \HHHHHHHHHHHHHHHHHHHHHHHHHHHH/
        \JJJJJJJJJJJJJJJJJJJJJJJJ/
          \LLLLLLLLLLLLLLLLLLLLL/
          |LLLLLLLLLLLLLLLLLLLLL|
         /LLLLLLLLLLLLLLLLLLLLLLL\
       /JJJJJJJJJJJJJJJJJJJJJJJJJJJ\
     /LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL\
    /LLLLLLLLLLLLLJJJJJJJJJLLLLLLLLLLL\
   |LLLLLLLLLLLLLJJJJJJJJJJJLLLLLLLLLLL|
  |:::::::::::::::::::::::::::::::::::::|
  |||||||||||||||||||||||||||||||||||||||
  \ :        |        /\     |        : /
   \:________/       |  |    \________:/
    \                |  |             /
    /|||||||||||||||||\/||||||||||||||\

  */
#endregion