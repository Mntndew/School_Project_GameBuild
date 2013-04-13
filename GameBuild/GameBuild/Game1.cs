/*
    ____________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________
   / /                                                                                                                                                                                                                                                                                                                                                                                                                                                  \
  / /        ooOOOOOOOOOOOOOOOOOOOO            ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS            ccCCCCCCCCCCCCCCCCCCCCCCCCCC    iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  llLLLLLLLLLL                            llLLLLLLLLLL                                      aaAAAAAAAAAAAAAAAA            ttTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT  iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII          ooOOOOOOOOOOOOOOOOOOOO          nnNNNNNNNNNN          nnNNNNNNNNNN   \
 / /     ooOOOOOOOOOOOOOOOOOOOOOOOOOOOO      ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS      ccCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC   iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  llLLLLLLLLLL                            llLLLLLLLLLL                                      aaAAAAAAAAAAAAAAAA            ttTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT  iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII      ooOOOOOOOOOOOOOOOOOOOOOOOOOOOO      nnNNNNNNNNNNNN        nnNNNNNNNNNN    \ 
| |  ooOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO  ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS  ccCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC   iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  llLLLLLLLLLL                            llLLLLLLLLLL                                     aaAAAAAAAAAAAAAAAAAA           ttTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT  iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  ooOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO  nnNNNNNNNNNNNN        nnNNNNNNNNNN     |
| |  ooOOOOOOOOOOOO           ooOOOOOOOOOOOO  ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS   ccCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC    iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  llLLLLLLLLLL                            llLLLLLLLLLL                                     aaAAAAAAAAAAAAAAAAAA           ttTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT  iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  ooOOOOOOOOOOOO          ooOOOOOOOOOOOO  nnNNNNNNNNNNNNNN      nnNNNNNNNNNN     |
| |  ooOOOOOOOO                   ooOOOOOOOO  ssSSSSSSSSS                            ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                    aaAAAAAAAAAAAAAAAAAAAA                       ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNNNNNN      nnNNNNNNNNNN     |
| |  ooOOOOOOOO                   ooOOOOOOOO  ssSSSSSSSSS                            ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                    aaAAAAAAAAAAAAAAAAAAAA                       ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNNNNNNNN    nnNNNNNNNNNN     |
| |  ooOOOOOOOO                   ooOOOOOOOO  ssSSSSSSSSS                            ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                   aaAAAAAAAAAAaaAAAAAAAAAA                      ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNNNNNNNN    nnNNNNNNNNNN     |
| |  ooOOOOOOOO                   ooOOOOOOOO  ssSSSSSSSSS                            ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                   aaAAAAAAAAAAaaAAAAAAAAAA                      ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNNNNNNNNNN  nnNNNNNNNNNN     |
| |  ooOOOOOOOO                   ooOOOOOOOO  ssSSSSSSSSS                            ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                  aaAAAAAAAAAA  aaAAAAAAAAAA                     ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNNNNNNNNNN  nnNNNNNNNNNN     |
| |  ooOOOOOOOO                   ooOOOOOOOO  ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS   ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                  aaAAAAAAAAAA  aaAAAAAAAAAA                     ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNNNNNNNNNNNNnnNNNNNNNNNN     |
| |  ooOOOOOOOO                   ooOOOOOOOO  ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                 aaAAAAAAAAAA    aaAAAAAAAAAA                    ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNNnnNNNNNNNNNNNNNNNNNNNN     |
| |  ooOOOOOOOO                   ooOOOOOOOO  ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                 aaAAAAAAAAAA    aaAAAAAAAAAA                    ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNNnnNNNNNNNNNNNNNNNNNNNN     |
| |  ooOOOOOOOO                   ooOOOOOOOO    ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                aaAAAAAAAAAAAAAAAAAAAAAAAAAAAA                   ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNN  nnNNNNNNNNNNNNNNNNNN     |
| |  ooOOOOOOOO                   ooOOOOOOOO                             ssSSSSSSSSS ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                aaAAAAAAAAAAAAAAAAAAAAAAAAAAAA                   ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNN  nnNNNNNNNNNNNNNNNNNN     |
| |  ooOOOOOOOO                   ooOOOOOOOO                             ssSSSSSSSSS ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                               aaAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA                  ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNN    nnNNNNNNNNNNNNNNNN     |
| |  ooOOOOOOOO                   ooOOOOOOOO                             ssSSSSSSSSS ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                               aaAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA                  ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNN    nnNNNNNNNNNNNNNNNN     |
| |  ooOOOOOOOO                   ooOOOOOOOO                             ssSSSSSSSSS ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                              aaAAAAAAAAAA          aaAAAAAAAAAA                 ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNN      nnNNNNNNNNNNNNNN     |
| |  ooOOOOOOOOOOOO           ooOOOOOOOOOOOO    ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS ccCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC    iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  llLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL  llLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL    aaAAAAAAAAAA          aaAAAAAAAAAA                 ttTTTTTTTTTT               iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  ooOOOOOOOOOOOO          ooOOOOOOOOOOOO  nnNNNNNNNNNN      nnNNNNNNNNNNNNNN     |
| |  ooOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO  ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS  ccCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC   iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  llLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL  llLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL   aaAAAAAAAAAA            aaAAAAAAAAAA                ttTTTTTTTTTT               iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  ooOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO  nnNNNNNNNNNN        nnNNNNNNNNNNNN     |
 \ \     ooOOOOOOOOOOOOOOOOOOOOOOOOOOOO      ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS      ccCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC   iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  llLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL  llLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL   aaAAAAAAAAAA            aaAAAAAAAAAA                ttTTTTTTTTTT               iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII      ooOOOOOOOOOOOOOOOOOOOOOOOOOOOO      nnNNNNNNNNNN        nnNNNNNNNNNNNN     /
  \ \       ooOOOOOOOOOOOOOOOOOOOO             ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS            ccCCCCCCCCCCCCCCCCCCCCCCCCCC    iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  llLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL  llLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL  aaAAAAAAAAAA              aaAAAAAAAAAA               ttTTTTTTTTTT               iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII          ooOOOOOOOOOOOOOOOOOOOO          nnNNNNNNNNNN          nnNNNNNNNNNN    /
   \_\___________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________/
*/
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

        public List<Npc> activeNpcs = new List<Npc>();
        public List<Npc> Npcs = new List<Npc>();
        int files = Directory.GetFiles(@"Content\npc\npc\").Length; //number of npcs
        string[] names; // array of all npc names

        List<cWarp> warps = new List<cWarp>();
        int warpFiles = Directory.GetFiles(@"Content\warp\").Length;
        string[] warp;

        Random rand = new Random();

        public static cCharacter character;
        public Damage damageObject;

        public List<Key> keys = new List<Key>();

        //Debugging stuffs
        public Texture2D collisionTex;
        Color collisionColor = new Color(100, 0, 0, 100);

        public static TileMap map;

        public KeyboardState oldState;
        public KeyboardState keyState;

        public Rectangle screen;
        public Texture2D screenTexture;
        public Color screenColor;

        Camera2d camera;

        public static ParticleSystem particleSystem;

        public enum GameState
        {
            PLAY,
            INTERACT,
            PAUSE,
        }

        public GameState currentGameState = new GameState();

        Texture2D debugTile;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.PreferredBackBufferHeight = 720;
            graphics.PreferredBackBufferWidth = 1280;
            currentGameState = GameState.PLAY;
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
            spriteFont = Content.Load<SpriteFont>(@"Game\SpriteFont1");
            damageObject = new Damage();
            screenColor = new Color(0, 0, 0, 0);
            screen = new Rectangle(0, 0, graphics.PreferredBackBufferWidth, graphics.PreferredBackBufferHeight);
            keys.Add(new Key(new Rectangle(320, 320, 16, 16), "key 0", "source", this));
            keys.Add(new Key(new Rectangle(320, 320, 16, 16), "key 1", "target", this));
            particleSystem = new ParticleSystem(2, this);
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
            collisionTex = Content.Load<Texture2D>(@"Game\blackness");
            map = Content.Load<H_Map.TileMap>(@"Map\new map");
            map.tileset = Content.Load<Texture2D>(@"Game\tileset");
            //Console.WriteLine(map.mapName);
            camera = new Camera2d(GraphicsDevice.Viewport, map.mapWidth * map.tileWidth, map.mapHeight * map.tileHeight, 1f);
            LoadWarps();
            LoadNpcs();
            UpdateActiveNpcs();
            debugTile = Content.Load<Texture2D>(@"Player\emptySlot");
            screenTexture = Content.Load<Texture2D>(@"Game\blackness");
        }

        public void LoadNpcs()
        {
            names = new string[files];

            for (int i = 0; i < files; i++)
            {
                names[i] = Directory.GetFiles(@"Content\npc\npc\")[i];
                StreamReader reader = new StreamReader(names[i]);
                Npc npc = new Npc(reader.ReadLine(), reader.ReadLine(), int.Parse(reader.ReadLine()), int.Parse(reader.ReadLine()), int.Parse(reader.ReadLine()), int.Parse(reader.ReadLine()),
                bool.Parse(reader.ReadLine()), bool.Parse(reader.ReadLine()), bool.Parse(reader.ReadLine()), bool.Parse(reader.ReadLine()), reader.ReadLine(), reader.ReadLine(),
                bool.Parse(reader.ReadLine()), bool.Parse(reader.ReadLine()), bool.Parse(reader.ReadLine()), bool.Parse(reader.ReadLine()), int.Parse(reader.ReadLine()),
                int.Parse(reader.ReadLine()), int.Parse(reader.ReadLine()), int.Parse(reader.ReadLine()), int.Parse(reader.ReadLine()), this, reader.ReadLine());
                Npcs.Add(npc);
            }
        }
        
                
        public void UpdateActiveNpcs()
        {
            activeNpcs.Clear();
            for (int i = 0; i < Npcs.Count; i++)
            {
                Npcs[i].CheckMap(this);
                if (Npcs[i].isOnMap)
                {
                    activeNpcs.Add(Npcs[i]);
                    Npcs[i].hasBeenAdded = true;
                }
            }
            for (int i = 0; i < activeNpcs.Count; i++)
            {
                if (!activeNpcs[i].isOnMap)
                {
                    activeNpcs[i].hasBeenAdded = false;
                    activeNpcs.RemoveAt(i);
                }
            }
        }

        public void LoadWarps()
        {
            warp = new string[warpFiles];
            for (int i = 0; i < warpFiles; i++)
            {
                warp[i] = Directory.GetFiles(@"Content\warp\")[i];
                StreamReader reader = new StreamReader(warp[i]);
                cWarp Warp = new cWarp(reader.ReadLine(), int.Parse(reader.ReadLine()), int.Parse(reader.ReadLine()), int.Parse(reader.ReadLine()),
                    int.Parse(reader.ReadLine()), reader.ReadLine(), int.Parse(reader.ReadLine()), int.Parse(reader.ReadLine()), reader.ReadLine(), this);
                reader.Close();
                warps.Add(Warp);
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
            UpdateActiveNpcs();
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();
            oldState = keyState;
            keyState = Keyboard.GetState();
            camera.Pos = character.vectorPos;

            if (currentGameState == GameState.PLAY)
            {
                character.Update(this, map, gameTime, oldState, GraphicsDevice);
            }
            foreach (cWarp warp in warps)
            {
                warp.CheckMap(this);
                if (warp.isOnMap)
                {
                    warp.Update(character, this);
                }
            }

            for (int i = 0; i < keys.Count; i++)
            {
                if (character.position.Intersects(keys[i].position) && map.mapName.Remove(map.mapName.Length - 1) == keys[i].mapName)
                {
                    keys[i].PickUp(character);
                    keys.RemoveAt(i);
                }
            }

            foreach (Npc npc in activeNpcs)
            {
                if (npc.health > 0)
                {
                    if (!npc.isInteracting && npc.isOnMap && !character.showInventory)
                    {
                        npc.Update(character, map, this, gameTime);
                    }
                    npc.UpdateDialogue(this);
                    if (keyState.IsKeyDown(Keys.A) && oldState.IsKeyUp(Keys.A) && npc.canInteract)
                    {
                        if (npc.isInteracting)
                        {
                            npc.isInteracting = false;
                            npc.dialogue.isTalking = false;
                            npc.dialogue.ResetDialogue();
                            currentGameState = GameState.PLAY;
                        }
                        else
                        {
                            npc.isInteracting = true;
                            npc.dialogue.isTalking = true;
                            currentGameState = GameState.INTERACT;
                        }
                    }
                }
            }

            #region Debugging
            if (keyState.IsKeyDown(Keys.Tab))
            {
                for (int i = 0; i < Npcs.Count; i++)
                {
                    //Console.WriteLine(Npcs[i].name);
                }
            }
            #endregion

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            //draws out the world on the default back buffer with all entities 
            GraphicsDevice.SetRenderTarget(null);
            GraphicsDevice.Clear(Color.Black);
            spriteBatch.Begin(SpriteSortMode.Immediate, null, null, null, null, null, camera.GetTransformation());
            map.DrawBackgroundLayer(spriteBatch, new Rectangle(0, 0, 1280, 720));
            map.DrawInteractiveLayer(spriteBatch, new Rectangle(0, 0, 1280, 720));

            for (int i = 0; i < keys.Count; i++)
            {
                if (keys[i].mapName == map.mapName.Remove(map.mapName.Length - 1))
                {
                    keys[i].Draw(spriteBatch);
                }
            }

            character.Draw(spriteBatch);

            for (int i = 0; i < activeNpcs.Count; i++)
            {
                activeNpcs[i].Draw(spriteBatch);
            }

            map.DrawForegroundLayer(spriteBatch, new Rectangle(0, 0, 1280, 720));
            for (int i = 0; i < activeNpcs.Count; i++)
            {
                activeNpcs[i].DrawA(spriteBatch);
            }
            spriteBatch.DrawString(spriteFont, character.health + "/" + character.maxHealth, new Vector2(character.position.X - 10, character.position.Y - 35), Color.Red);
            //debugging
            for (int i = 0; i < warps.Count; i++)
            {
                if (warps[i].isOnMap)
                {
                    warps[i].Draw(spriteBatch, this);
                }
            }
            //Spritebatch for HUD stuff
            character.DrawHealthBar(spriteBatch, this);
            spriteBatch.End();

            //draws out the light mask over the world, uses multiplication blending to create the effect
            BlendState blendState = new BlendState();
            blendState.ColorSourceBlend = Blend.Zero;
            blendState.ColorDestinationBlend = Blend.SourceColor;
            blendState.AlphaSourceBlend = Blend.Zero;
            blendState.AlphaDestinationBlend = Blend.SourceAlpha;
            spriteBatch.Begin(SpriteSortMode.Immediate, blendState);
            spriteBatch.End();
            float framerate = 1f / (float)gameTime.ElapsedGameTime.TotalSeconds;
            spriteBatch.Begin();
            for (int i = 0; i < activeNpcs.Count; i++)
            {
                if (activeNpcs[i].isOnMap)
                {
                    if (activeNpcs[i].isInteracting)
                    {
                        activeNpcs[i].dialogue.Draw(spriteBatch);
                    }
                    activeNpcs[i].DrawDamage(spriteBatch, this);
                }
            }
            character.inventory.Draw(spriteBatch, this);

            spriteBatch.DrawString(spriteFont, framerate.ToString(), new Vector2(10, 10), Color.Red);
            spriteBatch.End();
            
            //Console.WriteLine(framerate);
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