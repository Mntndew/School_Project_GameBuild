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
        public GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public SpriteFont spriteFont;
        public static SpriteFont debugFont;

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

        public Texture2D keyTexture;
        public Texture2D textBox;
        Texture2D debugTile;
        public Texture2D screenTexture;
        public Texture2D collisionTex;
        Texture2D male;
        Texture2D female;
        Texture2D[] keyTextures;

        public static ParticleSystem particleSystem;
        public static TileMap map;
        Camera2d camera;
        public static List<Key> keys = new List<Key>();
        public static cCharacter character;
        public Damage damageObject;
        public static Game.WarpManager warpManager = new Game.WarpManager();
        public List<Npc.Npc> activeNpcs = new List<Npc.Npc>();
        public List<Npc.Npc> Npcs = new List<Npc.Npc>();
        public List<Npc.Npc> Mobs = new List<Npc.Npc>();
        public List<Orb> orbs = new List<Orb>();
        public static Npc.Boss testBoss;
        public static Menu.Menu menu;

        int files = Directory.GetFiles(@"Content\npc\npc\").Length; //number of npcs
        int warpFiles = Directory.GetFiles(@"Content\Warp\").Length;

        string[] names; // array of all npc names
        string gender = null;

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
            malePos = new Rectangle(0, 0, graphics.PreferredBackBufferWidth / 2, graphics.PreferredBackBufferHeight);
            femalePos = new Rectangle(graphics.PreferredBackBufferWidth / 2, 0, graphics.PreferredBackBufferWidth / 2, graphics.PreferredBackBufferHeight);
            menu = new Menu.Menu(this);
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
            map = Content.Load<H_Map.TileMap>(@"Map\Map1_A");
            map.tileset = Content.Load<Texture2D>(@"Game\tileset");
            textBox = Content.Load<Texture2D>(@"Game\textBox");
            camera = new Camera2d(GraphicsDevice.Viewport, map.mapWidth * map.tileWidth, map.mapHeight * map.tileHeight, 1f);
            UpdateActiveNpcs();
            debugTile = Content.Load<Texture2D>(@"Player\emptySlot");
            screenTexture = Content.Load<Texture2D>(@"Game\blackness");
            male = Content.Load<Texture2D>(@"Player\Male");
            female = Content.Load<Texture2D>(@"Game\blackness");
            warpManager.UpdateList(map.mapName);
            keyTexture = Content.Load<Texture2D>(@"Game\key");
            LoadKeys();
            LoadNpcs();
            debugFont = Content.Load<SpriteFont>(@"Game\SpriteFont1");
            AddMobs();
        }

        public void AddMobs()
        {
            for (int i = 0; i < 5; i++)
            {
                Mobs.Add(new Npc.Npc(new Rectangle(256 + (i * 100), 1800, 48, 48), Content.Load<Texture2D>(@"Npc\sprite\Headmaster"), this, "Map1_A", i + 1 * 0.5f, false, 50, 1, 5, 1, true));
            }
            for (int i = 0; i < 5; i++)
            {
                Mobs.Add(new Npc.Npc(new Rectangle(256 + (i * 100), 1800, 48, 48), Content.Load<Texture2D>(@"Npc\sprite\Headmaster"), this, "Map3_A", i + 1 * 0.5f, false, 50, 1, 5, 1, true));
            }
            for (int i = 0; i < 5; i++)
            {
                Mobs.Add(new Npc.Npc(new Rectangle(256 + (i * 100), 1800, 48, 48), Content.Load<Texture2D>(@"Npc\sprite\Headmaster"), this, "Map3_B", i + 1 * 0.5f, false, 50, 1, 5, 1, true));
            }
        }

        public void LoadKeys()
        {
            keyTextures = new Texture2D[2];
            for (int i = 0; i < keyTextures.Length; i++)
            {
                keyTextures[i] = Content.Load<Texture2D>(@"Game\key");
            }
            keys.Add(new Key(new Rectangle(320, 320, keyTextures[0].Width, keyTextures[0].Height), "key 0", keyTextures[0], "Testing Ground", this));
        }

        public void LoadNpcs()
        {
            names = new string[files];

            for (int i = 0; i < files; i++)
            {
                names[i] = Directory.GetFiles(@"Content\npc\npc\")[i];
                StreamReader reader = new StreamReader(names[i]);
                Npc.Npc npc = new Npc.Npc(reader.ReadLine(), reader.ReadLine(), int.Parse(reader.ReadLine()), int.Parse(reader.ReadLine()), int.Parse(reader.ReadLine()), int.Parse(reader.ReadLine()),
                reader.ReadLine(), reader.ReadLine(), reader.ReadLine(), reader.ReadLine(), reader.ReadLine(), reader.ReadLine(),
                bool.Parse(reader.ReadLine()), bool.Parse(reader.ReadLine()), bool.Parse(reader.ReadLine()), bool.Parse(reader.ReadLine()), int.Parse(reader.ReadLine()),
                int.Parse(reader.ReadLine()), int.Parse(reader.ReadLine()), int.Parse(reader.ReadLine()), int.Parse(reader.ReadLine()), this, reader.ReadLine(), reader.ReadLine());
                Npcs.Add(npc);
            }
        }

        public void UpdateActiveNpcs()
        {
            activeNpcs.Clear();
            for (int i = 0; i < Npcs.Count; i++)
            {
                if (Npcs[i].IsOnMap())
                {
                    activeNpcs.Add(Npcs[i]);
                    Npcs[i].hasBeenAdded = true;
                }
            }
            for (int i = 0; i < activeNpcs.Count; i++)
            {
                if (!activeNpcs[i].IsOnMap())
                {
                    activeNpcs[i].hasBeenAdded = false;
                    activeNpcs.RemoveAt(i);
                }
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
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();
            mouse = Mouse.GetState();
            if (gender == null)
            {
                ChooseGender();
            }

            oldState = keyState;
            keyState = Keyboard.GetState();
            if (keyState.IsKeyDown(Keys.Escape) && oldState.IsKeyUp(Keys.Escape))
            {
                if (!menu.paused)
                {
                    menu.paused = true;
                }
                else
                    menu.paused = false;
            }
            if (gender != null && !menu.paused)
            {
                warpManager.Update(this);
                if (keyState.IsKeyDown(Keys.Space))
                {
                    orbs.Add(new Orb(new Rectangle(256, 256, 8, 8)));
                }
                if (testBoss.IsOnMap())
                {
                    testBoss.Update(this, gameTime);
                }
                particleSystem.Update(gameTime);
                UpdateActiveNpcs();

                camera.Pos = character.position;

                if (currentGameState == GameState.PLAY)
                {
                    character.Update(this, map, gameTime, oldState, GraphicsDevice);
                }

                for (int i = 0; i < keys.Count; i++)
                {
                    if (character.positionRectangle.Intersects(keys[i].position) && map.mapName.Remove(map.mapName.Length - 1) == keys[i].mapName)
                    {
                        keys[i].PickUp(character);
                        keys.RemoveAt(i);
                    }
                }

                for (int i = 0; i < Npcs.Count; i++)
                {
                    if (Npcs[i].health > 0)
                    {
                        if (!Npcs[i].isInteracting && Npcs[i].IsOnMap() && !character.showInventory)
                        {
                            Npcs[i].Update(character, map, this, gameTime);
                        }
                        Npcs[i].UpdateDialogue(this);
                        if (keyState.IsKeyDown(Keys.A) && oldState.IsKeyUp(Keys.A) && Npcs[i].canInteract && !Npcs[i].mob && character.inCombat == false)
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

                for (int i = 0; i < Mobs.Count; i++)
                {
                    Mobs[i].Update(character, map, this, gameTime);
                    if (Mobs[i].health <= 0)
                    {
                        Mobs.RemoveAt(i);
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
                testBoss = new Npc.Boss(new Rectangle(7 * 64, 6 * 64, 64, 64), this, "Map4_C");
                currentGameState = GameState.PLAY;
            }
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            if (gender != null)
            {
                spriteBatch.Begin(SpriteSortMode.Immediate, null, SamplerState.PointClamp, null, null, null, camera.GetTransformation());
                map.DrawBackgroundLayer(spriteBatch, new Rectangle(0, 0, 1280, 720));
                map.DrawInteractiveLayer(spriteBatch, new Rectangle(0, 0, 1280, 720));

                for (int i = 0; i < keys.Count; i++)
                {
                    if (keys[i].mapName == map.mapName.Remove(map.mapName.Length - 1))
                    {
                        if (keys[i].mapName == map.mapName.Remove(map.mapName.Length - 1))
                        {
                            keys[i].Draw(spriteBatch);
                        }
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
                for (int i = 0; i < Mobs.Count; i++)
                {
                    if (Mobs[i].IsOnMap())
                    {
                        Mobs[i].Draw(spriteBatch);
                    }
                }
                if (testBoss.IsOnMap())
                {
                    testBoss.Draw(spriteBatch);
                }
                map.DrawForegroundLayer(spriteBatch, new Rectangle(0, 0, 1280, 720));
                if (testBoss.IsOnMap())
                {
                    testBoss.DrawMobs(spriteBatch);
                }
                warpManager.Draw(spriteBatch, this);
                for (int i = 0; i < activeNpcs.Count; i++)
                {
                    activeNpcs[i].DrawA(spriteBatch);
                }
                if (testBoss.IsOnMap())
                {
                    testBoss.DrawDamage(spriteBatch, this);
                    for (int i = 0; i < testBoss.projectiles.Count; i++)
                    {
                        testBoss.projectiles[i].DrawParticles(spriteBatch);
                    }
                }
                spriteBatch.DrawString(spriteFont, character.health + "/" + character.maxHealth, new Vector2(character.position.X - 10, character.position.Y - 35), new Color(200, 10, 10, 200));
                character.DrawHealthBar(spriteBatch, this);

                for (int i = 0; i < activeNpcs.Count; i++)
                {
                    activeNpcs[i].DrawDamage(spriteBatch, this);
                }
                spriteBatch.End();

                spriteBatch.Begin();
                for (int i = 0; i < activeNpcs.Count; i++)
                {
                    if (activeNpcs[i].IsOnMap())
                    {
                        if (activeNpcs[i].isInteracting)
                        {
                            activeNpcs[i].dialogue.Draw(spriteBatch);
                        }
                    }
                }
                character.inventory.Draw(spriteBatch, this);

                if (testBoss.IsOnMap())
                {
                    testBoss.DrawHealth(spriteBatch);
                }

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
            else
            {
                if (character.health <= 0)
                {
                    spriteBatch.Begin();
                    character.DrawDeath(spriteBatch, this);
                    spriteBatch.End();
                }
            }

            //menu
            menu.Draw(spriteBatch);
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