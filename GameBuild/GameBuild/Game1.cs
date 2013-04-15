/*
    ____________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________
   / /                                                                                                                                                                                                                                                                                                                                                                                                                                                  \
  / /        ooOOOOOOOOOOOOOOOOOOOO            ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS            ccCCCCCCCCCCCCCCCCCCCCCCCCCC    iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  llLLLLLLLLLL                            llLLLLLLLLLL                                      aaAAAAAAAAAAAAAAAA            ttTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT  iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII          ooOOOOOOOOOOOOOOOOOOOO          nnNNNNNNNNNN          nnNNNNNNNNNN  \
 / /     ooOOOOOOOOOOOOOOOOOOOOOOOOOOOO      ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS      ccCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC   iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  llLLLLLLLLLL                            llLLLLLLLLLL                                      aaAAAAAAAAAAAAAAAA            ttTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT  iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII      ooOOOOOOOOOOOOOOOOOOOOOOOOOOOO      nnNNNNNNNNNNNN        nnNNNNNNNNNN   \ 
| |  ooOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO  ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS  ccCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC   iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  llLLLLLLLLLL                            llLLLLLLLLLL                                     aaAAAAAAAAAAAAAAAAAA           ttTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT  iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  ooOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO  nnNNNNNNNNNNNN        nnNNNNNNNNNN    |
| |  ooOOOOOOOOOOOO           ooOOOOOOOOOOOO  ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS   ccCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC    iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  llLLLLLLLLLL                            llLLLLLLLLLL                                     aaAAAAAAAAAAAAAAAAAA           ttTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT  iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  ooOOOOOOOOOOOO          ooOOOOOOOOOOOO  nnNNNNNNNNNNNNNN      nnNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO  ssSSSSSSSSS                            ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                    aaAAAAAAAAAAAAAAAAAAAA                       ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNNNNNN      nnNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO  ssSSSSSSSSS                            ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                    aaAAAAAAAAAAAAAAAAAAAA                       ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNNNNNNNN    nnNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO  ssSSSSSSSSS                            ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                   aaAAAAAAAAAAaaAAAAAAAAAA                      ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNNNNNNNN    nnNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO  ssSSSSSSSSS                            ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                   aaAAAAAAAAAAaaAAAAAAAAAA                      ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNNNNNNNNNN  nnNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO  ssSSSSSSSSS                            ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                  aaAAAAAAAAAA  aaAAAAAAAAAA                     ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNNNNNNNNNN  nnNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO  ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS   ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                  aaAAAAAAAAAA  aaAAAAAAAAAA                     ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNNNNNNNNNNNNnnNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO  ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                 aaAAAAAAAAAA    aaAAAAAAAAAA                    ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNNnnNNNNNNNNNNNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO  ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                 aaAAAAAAAAAA    aaAAAAAAAAAA                    ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNNnnNNNNNNNNNNNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO    ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                aaAAAAAAAAAAAAAAAAAAAAAAAAAAAA                   ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNN  nnNNNNNNNNNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO                             ssSSSSSSSSS ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                aaAAAAAAAAAAAAAAAAAAAAAAAAAAAA                   ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNN  nnNNNNNNNNNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO                             ssSSSSSSSSS ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                               aaAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA                  ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNN    nnNNNNNNNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO                             ssSSSSSSSSS ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                               aaAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA                  ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNN    nnNNNNNNNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO                             ssSSSSSSSSS ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                              aaAAAAAAAAAA          aaAAAAAAAAAA                 ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNN      nnNNNNNNNNNNNNNN    |
| |  ooOOOOOOOOOOOO           ooOOOOOOOOOOOO    ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS ccCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC    iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  llLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL  llLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL    aaAAAAAAAAAA          aaAAAAAAAAAA                 ttTTTTTTTTTT               iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  ooOOOOOOOOOOOO          ooOOOOOOOOOOOO  nnNNNNNNNNNN      nnNNNNNNNNNNNNNN    |
| |  ooOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO  ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS  ccCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC   iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  llLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL  llLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL   aaAAAAAAAAAA            aaAAAAAAAAAA                ttTTTTTTTTTT               iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  ooOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO  nnNNNNNNNNNN        nnNNNNNNNNNNNN    |
 \ \     ooOOOOOOOOOOOOOOOOOOOOOOOOOOOO      ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS      ccCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC   iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  llLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL  llLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL   aaAAAAAAAAAA            aaAAAAAAAAAA                ttTTTTTTTTTT               iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII      ooOOOOOOOOOOOOOOOOOOOOOOOOOOOO      nnNNNNNNNNNN        nnNNNNNNNNNNNN    /
  \ \       ooOOOOOOOOOOOOOOOOOOOO             ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS            ccCCCCCCCCCCCCCCCCCCCCCCCCCC    iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  llLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL  llLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL  aaAAAAAAAAAA              aaAAAAAAAAAA               ttTTTTTTTTTT               iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII          ooOOOOOOOOOOOOOOOOOOOO          nnNNNNNNNNNN          nnNNNNNNNNNN   /
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

        Random rand = new Random();

        Color collisionColor = new Color(100, 0, 0, 100);
        public Color screenColor;

        public KeyboardState oldState;
        public KeyboardState keyState;
        MouseState mouse;

        public Rectangle screen;

        Rectangle malePos;
        //these are for choosing a gender.
        Rectangle femalePos;

        public Texture2D textBox;
        Texture2D debugTile;
        public Texture2D screenTexture;
        public Texture2D collisionTex;
        Texture2D male;
        Texture2D female;

        public static ParticleSystem particleSystem;
        public static TileMap map;
        Camera2d camera;
        public List<Key> keys = new List<Key>();
        public static cCharacter character;
        public Damage damageObject;
        public static Game.WarpManager warpManager = new Game.WarpManager();
        public List<Npc> activeNpcs = new List<Npc>();
        public List<Npc> Npcs = new List<Npc>();
        public List<Orb> orbs = new List<Orb>();

        int files = Directory.GetFiles(@"Content\npc\npc\").Length; //number of npcs
        int warpFiles = Directory.GetFiles(@"Content\Warp\").Length;

        string[] warp;
        string[] names; // array of all npc names
        string gender = "male";

        public enum GameState
        {
            PLAY,
            INTERACT,
            PAUSE,
            GENDER,
        }

        public GameState currentGameState = new GameState();

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
            particleSystem = new ParticleSystem();
            spriteFont = Content.Load<SpriteFont>(@"Game\SpriteFont1");
            damageObject = new Damage();
            screenColor = new Color(0, 0, 0, 0);
            screen = new Rectangle(0, 0, graphics.PreferredBackBufferWidth, graphics.PreferredBackBufferHeight);
            keys.Add(new Key(new Rectangle(320, 320, 16, 16), "key 0", "source", this));
            keys.Add(new Key(new Rectangle(320, 320, 16, 16), "key 1", "target", this));
            malePos = new Rectangle(0, 0, graphics.PreferredBackBufferWidth / 2, graphics.PreferredBackBufferHeight);
            femalePos = new Rectangle(graphics.PreferredBackBufferWidth / 2, 0, graphics.PreferredBackBufferWidth / 2, graphics.PreferredBackBufferHeight);
            if (gender != null)
            {
                character = new cCharacter(this, gender);
            }
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
            map = Content.Load<H_Map.TileMap>(@"Map\Testing Ground");
            map.tileset = Content.Load<Texture2D>(@"Game\tileset");
            textBox = Content.Load<Texture2D>(@"Game\textBox");
            camera = new Camera2d(GraphicsDevice.Viewport, map.mapWidth * map.tileWidth, map.mapHeight * map.tileHeight, 1f);
            UpdateActiveNpcs();
            debugTile = Content.Load<Texture2D>(@"Player\emptySlot");
            screenTexture = Content.Load<Texture2D>(@"Game\blackness");
            male = Content.Load<Texture2D>(@"Player\Male");
            female = Content.Load<Texture2D>(@"Game\blackness");
            //LoadWarps();
            warpManager.UpdateList();
            LoadNpcs();
        }

        public void LoadNpcs()
        {
            names = new string[files];

            for (int i = 0; i < files; i++)
            {
                names[i] = Directory.GetFiles(@"Content\npc\npc\")[i];
                StreamReader reader = new StreamReader(names[i]);
                Npc npc = new Npc(reader.ReadLine(), reader.ReadLine(), int.Parse(reader.ReadLine()), int.Parse(reader.ReadLine()), int.Parse(reader.ReadLine()), int.Parse(reader.ReadLine()),
                reader.ReadLine(), reader.ReadLine(), reader.ReadLine(), reader.ReadLine(), reader.ReadLine(), reader.ReadLine(),
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

        //public void LoadWarps()
        //{
        //    warp = new string[warpFiles];
        //    for (int i = 0; i < warpFiles; i++)
        //    {
        //        warp[i] = Directory.GetFiles(@"Content\Warp\")[i];
        //        StreamReader reader = new StreamReader(warp[i]);
        //        cWarp Warp = new cWarp(reader.ReadLine(), int.Parse(reader.ReadLine()), int.Parse(reader.ReadLine()), int.Parse(reader.ReadLine()),
        //            int.Parse(reader.ReadLine()), reader.ReadLine(), int.Parse(reader.ReadLine()), int.Parse(reader.ReadLine()), reader.ReadLine(), this);
        //        reader.Close();
        //        warps.Add(Warp);
        //    }
        //}

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
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();
            mouse = Mouse.GetState();
            if (gender == null)
            {
                ChooseGender();
            }
            warpManager.Update(this);
            if (keyState.IsKeyDown(Keys.Space))
            {
                orbs.Add(new Orb(new Rectangle(256, 256, 8, 8)));
            }

            for (int i = 0; i < orbs.Count; i++)
            {
                orbs[i].Update();
                if (orbs[i].color.A == 0f)
                {
                    orbs.RemoveAt(i);
                }
            }

            if (gender != null)
            {
                particleSystem.Update(gameTime);
                UpdateActiveNpcs();
                oldState = keyState;
                keyState = Keyboard.GetState();
                camera.Pos = character.vectorPos;

                if (currentGameState == GameState.PLAY)
                {
                    character.Update(this, map, gameTime, oldState, GraphicsDevice);
                }

                //for (int i = 0; i < warp.Length; i++)
                //{
                //    warps[i].CheckMap(this);
                //    if (warps[i].isOnMap)
                //    {
                //        warps[i].Update(character, this);
                //    }
                //}

                for (int i = 0; i < keys.Count; i++)
                {
                    if (character.position.Intersects(keys[i].position) && map.mapName.Remove(map.mapName.Length - 1) == keys[i].mapName)
                    {
                        keys[i].PickUp(character);
                        keys.RemoveAt(i);
                    }
                }

                for (int i = 0; i < Npcs.Count; i++)
                {
                    if (Npcs[i].health > 0)
                    {
                        if (!Npcs[i].isInteracting && Npcs[i].isOnMap && !character.showInventory)
                        {
                            Npcs[i].Update(character, map, this, gameTime);
                        }
                        Npcs[i].UpdateDialogue(this);
                        if (keyState.IsKeyDown(Keys.A) && oldState.IsKeyUp(Keys.A) && Npcs[i].canInteract)
                        {
                            if (Npcs[i].isInteracting)
                            {
                                Npcs[i].isInteracting = false;
                                Npcs[i].dialogue.isTalking = false;
                                Npcs[i].dialogue.ResetDialogue();
                                currentGameState = GameState.PLAY;
                            }
                            else
                            {
                                Npcs[i].isInteracting = true;
                                Npcs[i].dialogue.isTalking = true;
                                currentGameState = GameState.INTERACT;
                            }
                        }
                    }
                }
            }
            base.Update(gameTime);
        }

        public void ChooseGender()
        {
            mouse = Mouse.GetState();
            Rectangle mousePos = new Rectangle(mouse.X, mouse.Y, 1, 1);
            if (mousePos.Intersects(femalePos))
            {
                if (mouse.LeftButton == ButtonState.Pressed)
                {
                    gender = "female";
                }
            }
            if (mousePos.Intersects(malePos))
            {
                if (mouse.LeftButton == ButtonState.Pressed)
                {
                    gender = "male";
                }
            }
            if (gender != null)
            {
                character = new cCharacter(this, gender);
                currentGameState = GameState.PLAY;
            }
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
            if (gender != null)
            {
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
            for (int i = 0; i < orbs.Count; i++)
            {
                spriteBatch.Draw(Content.Load<Texture2D>(@"Particle\particle"), orbs[i].position, orbs[i].color);
            }
            particleSystem.Draw(spriteBatch);
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
            spriteBatch.DrawString(spriteFont, character.health + "/" + character.maxHealth, new Vector2(character.position.X - 10, character.position.Y - 35), new Color(200, 10, 10, 200));
            //debugging
            //for (int i = 0; i < warps.Count; i++)
            //{
            //    if (warps[i].isOnMap)
            //    {
            //        warps[i].Draw(spriteBatch, this);
            //    }
            //}
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
            //for (int i = 0; i < warps.Count; i++)
            //{
            //    if (!warps[i].hasKey)
            //    {
            //        warps[i].DrawDialogue(spriteBatch);
            //    }
            //}
            spriteBatch.End();
            }

            if (gender == null)
            {
                spriteBatch.Begin();
                spriteBatch.Draw(male, new Rectangle(0, 0, male.Width / 2, male.Height / 2), Color.White);
                spriteBatch.Draw(female, new Rectangle(graphics.PreferredBackBufferWidth / 2, 0, female.Width / 2, female.Height / 2), Color.White);
                spriteBatch.DrawString(spriteFont, "Choose a gender, please.", new Vector2((graphics.PreferredBackBufferWidth / 2) - 20 * 6.38f, 6), new Color(200, 200, 200));
                spriteBatch.End();
            }
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