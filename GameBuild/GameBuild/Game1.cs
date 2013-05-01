/*
    ____________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________
   / /                                                                                                                                                                                                                                                                                                                                                                                                                                                  \
  / /        ooOOOOOOOOOOOOOOOOOOOO            ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS            ccCCCCCCCCCCCCCCCCCCCCCCCCCC    iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  llLLLLLLLLLL                            llLLLLLLLLLL                                      aaAAAAAAAAAAAAAAAA            ttTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT  iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII          ooOOOOOOOOOOOOOOOOOOOO          nnNNNNNNNNNN          nnNNNNNNNNNN  \
 / /     ooOOOOOOOOOOOOOOOOOOOOOOOOOOOO       ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS      ccCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC   iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  llLLLLLLLLLL                            llLLLLLLLLLL                                      aaAAAAAAAAAAAAAAAA            ttTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT  iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII      ooOOOOOOOOOOOOOOOOOOOOOOOOOOOO      nnNNNNNNNNNNNN        nnNNNNNNNNNN   \ 
| |  ooOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO   ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS  ccCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC   iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  llLLLLLLLLLL                            llLLLLLLLLLL                                     aaAAAAAAAAAAAAAAAAAA           ttTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT  iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  ooOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO  nnNNNNNNNNNNNN        nnNNNNNNNNNN    |
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
using GameBuild.Audio;

namespace GameBuild
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        public GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public static SpriteFont spriteFont;
        public static SpriteFont debugFont;

        Random rand = new Random();

        //for the forest scene
        Texture2D forest;
        cDialogue forestDialogue;
        Texture2D forestCharacter;
        Texture2D forestCybot;

        Color collisionColor = new Color(100, 0, 0, 100);
        public Color screenColor;

        public KeyboardState oldState;
        public KeyboardState keyState;
        MouseState mouse;

        public Rectangle screen;

        //choose gender
        Rectangle malePos;
        Rectangle femalePos;
        bool maleSelected;
        bool femaleSelected;

        public Texture2D keyTexture;
        public static Texture2D textBox;
        Texture2D debugTile;
        public Texture2D screenTexture;
        public Texture2D collisionTex;
        Texture2D male;
        Texture2D female;

        public static ParticleSystem particleSystem;
        public static TileMap map;
        public static Camera2d camera;
        public static List<Key> keys = new List<Key>();
        public static cCharacter character;
        public Damage damageObject;
        public static Game.WarpManager warpManager;
        public List<Npc.Npc> activeNpcs = new List<Npc.Npc>();
        public List<Npc.Npc> Npcs = new List<Npc.Npc>();
        public List<Npc.Npc> Mobs = new List<Npc.Npc>();
        public static Npc.Boss testBoss;
        public static Menu.Menu menu;
        public static Menu.StartMenu startMenu;
        public static Game.Items.Ribbon ribbon;

        MusicPlayer music;

        int files = Directory.GetFiles(@"Content\npc\npc\").Length; //number of npcs
        int warpFiles = Directory.GetFiles(@"Content\Warp\").Length;

        //Fade transition effect
        Texture2D fadeOverlay;
        Color fadeColor;
        public bool transition;
        bool increaseAlpha;
        GameState nextState;

        Rectangle screenRectangle = new Rectangle(0, 0, 1280, 720);

        string[] names; // array of all npc names
        string gender = null;

        public enum GameState
        {
            PLAY,
            INTERACT,
            PAUSE,
            GENDER,
            FOREST,
            STARTMENU,
        }

        public static GameState currentGameState = new GameState();

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.PreferredBackBufferHeight = 720;
            graphics.PreferredBackBufferWidth = 1280;
            currentGameState = GameState.STARTMENU;
            nextState = GameState.GENDER;
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
            ribbon = new Game.Items.Ribbon(new Rectangle(210, 570, 25, 19), "Ribbon", Content.Load<Texture2D>(@"Game\ribbon"), "Map2_A", this);
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
            map = Content.Load<H_Map.TileMap>(@"Map\Map2_A");
            map.tileset = Content.Load<Texture2D>(@"Game\tileset");
            textBox = Content.Load<Texture2D>(@"Game\textBox");
            camera = new Camera2d(GraphicsDevice.Viewport, map.mapWidth * map.tileWidth, map.mapHeight * map.tileHeight, 1f);
            UpdateActiveNpcs();
            debugTile = Content.Load<Texture2D>(@"Player\emptySlot");
            screenTexture = Content.Load<Texture2D>(@"Game\blackness");
            male = Content.Load<Texture2D>(@"Game\male");
            female = Content.Load<Texture2D>(@"Game\female");
            warpManager = new Game.WarpManager(this);
            warpManager.UpdateList(map.mapName);
            keyTexture = Content.Load<Texture2D>(@"Game\key");
            LoadNpcs();
            debugFont = Content.Load<SpriteFont>(@"Game\SpriteFont1");

            //forest shit
            forest = Content.Load<Texture2D>(@"Game\forest");
            forestCybot = Content.Load<Texture2D>(@"Npc\sprite\forestCybot");
            forestDialogue = new cDialogue(Content.Load<Texture2D>(@"Npc\portrait\Cybot"), textBox, this, spriteFont, "First cybot encounter", "Ziva");
            forestDialogue.isTalking = true;
            forestDialogue.dialogueManager.ReachedExit += new ExitEventHandler(ForestSceneExit);
            fadeOverlay = Content.Load<Texture2D>(@"Game\blackness");
            fadeColor = new Color(0, 0, 0, 0);
            increaseAlpha = true;

            startMenu = new Menu.StartMenu(Content.Load<Texture2D>(@"Game\Startmenu\playSelect"),
                Content.Load<Texture2D>(@"Game\Startmenu\playDeselect"),
                Content.Load<Texture2D>(@"Game\Startmenu\exitSelect"),
                    Content.Load<Texture2D>(@"Game\Startmenu\exitDeselect"));

            AddMobs();

            music = new MusicPlayer();
            music.Songs.Add(Content.Load<Song>(@"Audio\Songs\School basic song 1"));
            music.Songs.Add(Content.Load<Song>(@"Audio\Songs\School basic song 2"));
            music.Songs.Add(Content.Load<Song>(@"Audio\Songs\School basic song 3"));
            music.Songs.Add(Content.Load<Song>(@"Audio\Songs\School basic song 4"));
            music.Songs.Add(Content.Load<Song>(@"Audio\Songs\School basic song 5"));
            music.Songs.Add(Content.Load<Song>(@"Audio\Songs\School basic song 6"));
            music.Songs.Add(Content.Load<Song>(@"Audio\Songs\School basic song 7"));
            //music.Play(0);
        }

        void ForestSceneExit(object sender, DialogueEventArgs e)
        {
            forestDialogue.isTalking = false;
            nextState = GameState.PLAY;
            transition = true;
        }

        public void AddMobs()
        {
            for (int i = 0; i < 5; i++)
            {
                Mobs.Add(new Npc.Npc(256 + (i * 100 + rand.Next(-64, 64)), 1800, 48, 48, Content.Load<Texture2D>(@"Npc\sprite\Nurse"), this, "Map1_A", i + 1 * 0.5f, false, 50, 1, 5, 1, true));
                Mobs.Add(new Npc.Npc(256 + (i * 100 + rand.Next(-64, 64)), 1500, 48, 48, Content.Load<Texture2D>(@"Npc\sprite\Nurse"), this, "Map1_A", i + 1 * 0.5f, false, 50, 1, 5, 1, true));
            }
            for (int i = 0; i < 5; i++)
            {
                Mobs.Add(new Npc.Npc(256 + (i * 100 + rand.Next(-64, 64)), 1800, 48, 48, Content.Load<Texture2D>(@"Npc\sprite\Nurse"), this, "Map3_A", i + 1 * 0.5f, false, 50, 1, 5, 1, true));
                Mobs.Add(new Npc.Npc(256 + (i * 100 + rand.Next(-64, 64)), 1500, 48, 48, Content.Load<Texture2D>(@"Npc\sprite\Nurse"), this, "Map3_A", i + 1 * 0.5f, false, 50, 1, 5, 1, true));
            }
            for (int i = 0; i < 5; i++)
            {
                Mobs.Add(new Npc.Npc(256 + (i * 100 + rand.Next(-64, 64)), 1800, 48, 48, Content.Load<Texture2D>(@"Npc\sprite\Nurse"), this, "Map3_B", i + 1 * 0.5f, false, 50, 1, 5, 1, true));
                Mobs.Add(new Npc.Npc(256 + (i * 100 + rand.Next(-64, 64)), 1500, 48, 48, Content.Load<Texture2D>(@"Npc\sprite\Nurse"), this, "Map3_B", i + 1 * 0.5f, false, 50, 1, 5, 1, true));
            }
        }


        public void LoadNpcs()
        {
            names = new string[files];

            for (int i = 0; i < files; i++)
            {
                names[i] = Directory.GetFiles(@"Content\npc\npc\")[i];
                StreamReader reader = new StreamReader(names[i]);
                Npc.Npc npc = new Npc.Npc(reader.ReadLine(), reader.ReadLine(), int.Parse(reader.ReadLine()), int.Parse(reader.ReadLine()), int.Parse(reader.ReadLine()), int.Parse(reader.ReadLine()),
                bool.Parse(reader.ReadLine()), bool.Parse(reader.ReadLine()), bool.Parse(reader.ReadLine()), bool.Parse(reader.ReadLine()), reader.ReadLine(), reader.ReadLine(),
                bool.Parse(reader.ReadLine()), bool.Parse(reader.ReadLine()), bool.Parse(reader.ReadLine()), bool.Parse(reader.ReadLine()), int.Parse(reader.ReadLine()),
                int.Parse(reader.ReadLine()), int.Parse(reader.ReadLine()), int.Parse(reader.ReadLine()), int.Parse(reader.ReadLine()), this, reader.ReadLine(), reader.ReadLine(), reader.ReadLine());
                Npcs.Add(npc);
            }
        }

        public void UpdateActiveNpcs()
        {
            activeNpcs.Clear();
            for (int i = 0; i < Npcs.Count; i++)
            {
                if (Npcs[i].IsOnMap() && !Npcs[i].bossMob && !Npcs[i].mob && Npcs[i].health > 0)
                {
                    activeNpcs.Add(Npcs[i]);
                }
            }
            for (int i = 0; i < activeNpcs.Count; i++)
            {
                if (!activeNpcs[i].IsOnMap() || activeNpcs[i].health <= 0)
                {
                    //activeNpcs.RemoveAt(i);
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

            if (!transition)
            {
                if (currentGameState == GameState.STARTMENU)
                {
                    startMenu.Update(this);
                }
                else if (currentGameState == GameState.FOREST)
                {
                    forestDialogue.Update();
                }

                if (keyState.IsKeyDown(Keys.Escape) && oldState.IsKeyUp(Keys.Escape) && (currentGameState == GameState.PLAY || currentGameState == GameState.PAUSE || currentGameState == GameState.INTERACT))
                {
                    if (!menu.paused)
                    {
                        menu.paused = true;
                    }
                    else
                        menu.paused = false;
                }
                if (menu.paused)
                {
                    menu.Update(this);
                }
                if (gender != null && !menu.paused)
                {
                    warpManager.Update(this, gameTime);
                    UpdateActiveNpcs();
                    if (testBoss.IsOnMap())
                    {
                        testBoss.Update(this, gameTime);
                    }
                    particleSystem.Update(gameTime);
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
                    if (character.positionRectangle.Intersects(ribbon.position) && ribbon.IsOnMap() && !ribbon.added)
                    {
                        ribbon.PickUp(character);
                    }
                    character.npcsInRectangle = 0;
                    for (int i = 0; i < activeNpcs.Count; i++)
                    {
                        if (activeNpcs[i].position.Intersects(character.interactRect))
                        {
                            character.npcsInRectangle++;
                        }
                    }

                    for (int i = 0; i < Npcs.Count; i++)
                    {
                        Npcs[i].UpdateDialogue(this);
                    }

                    for (int i = 0; i < activeNpcs.Count; i++)
                    {
                        if (!activeNpcs[i].isInteracting && activeNpcs[i].IsOnMap() && !character.showInventory)
                        {
                            activeNpcs[i].Update(character, map, this, gameTime);
                        }

                        activeNpcs[i].UpdateDialogue(this);

                        if (keyState.IsKeyDown(Keys.A) && oldState.IsKeyUp(Keys.A) && activeNpcs[i].canInteract && !activeNpcs[i].mob && !character.inCombat && character.npcsInRectangle < 2)
                        {
                            if (activeNpcs[i].isInteracting)
                            {
                                activeNpcs[i].isInteracting = false;
                                activeNpcs[i].dialogue.isTalking = false;
                                activeNpcs[i].dialogue.ResetDialogue();
                                currentGameState = GameState.PLAY;
                            }
                            else
                            {
                                Console.WriteLine(activeNpcs[i].speed);
                                activeNpcs[i].isInteracting = true;
                                activeNpcs[i].dialogue.isTalking = true;
                                currentGameState = GameState.INTERACT;
                            }
                        }
                        if (activeNpcs[i].health <= 0)
                        {
                            if (activeNpcs[i].key != null)
                            {
                                activeNpcs[i].key.position = activeNpcs[i].position;
                                activeNpcs[i].key.position.Width = activeNpcs[i].key.texture.Width;
                                activeNpcs[i].key.position.Height = activeNpcs[i].key.texture.Height;
                                activeNpcs[i].key.label.position.X = activeNpcs[i].key.position.X;
                                activeNpcs[i].key.label.position.Y = activeNpcs[i].key.position.Y - (activeNpcs[i].key.label.position.Height + 2);
                                keys.Add(activeNpcs[i].key);
                                activeNpcs[i].key = null;
                            }
                        }
                    }
                    for (int i = 0; i < Mobs.Count; i++)
                    {
                        Mobs[i].Update(character, map, this, gameTime);
                        if (Mobs[i].remove)
                        {
                            Mobs.RemoveAt(i);
                        }
                    }
                }
            }
            else
            {
                Transition(5);
            }

            music.Update(gameTime);

            base.Update(gameTime);
        }

        public void ChooseGender()
        {
            if (!transition && currentGameState == GameState.GENDER)
            {
                if (keyState.IsKeyDown(Keys.Right) && oldState.IsKeyUp(Keys.Right))
                {
                    if (!maleSelected && !femaleSelected)
                    {
                        femaleSelected = true;
                        maleSelected = false;
                    }
                    else if (femaleSelected)
                    {
                        maleSelected = true;
                        femaleSelected = false;
                    }
                    else if (maleSelected)
                    {
                        femaleSelected = true;
                        maleSelected = false;
                    }
                }
                if (keyState.IsKeyDown(Keys.Left) && oldState.IsKeyUp(Keys.Left))
                {
                    if (!maleSelected && !femaleSelected)
                    {
                        maleSelected = true;
                        femaleSelected = false;
                    }
                    else if (femaleSelected)
                    {
                        maleSelected = true;
                        femaleSelected = false;
                    }
                    else if (maleSelected)
                    {
                        femaleSelected = true;
                        maleSelected = false;
                    }
                }
                if (femaleSelected)
                {
                    male = Content.Load<Texture2D>(@"Game\male");
                    female = Content.Load<Texture2D>(@"Game\femaleSelected");
                    if (keyState.IsKeyDown(Keys.Enter))
                    {
                        gender = "female";
                        activeNpcs.Add(new Npc.Npc("Map1_A", "Informer", 590, 640, 59, 64, false, false, false, false, @"Player\maleSheet", @"Player\Male", false, false, false, false, 0, 0, 0, 0, 0, this, "informer", "nokey", null));
                        forestCharacter = Content.Load<Texture2D>(@"Player\forestFemale");
                    }
                }
                if (maleSelected)
                {
                    male = Content.Load<Texture2D>(@"Game\maleSelected");
                    female = Content.Load<Texture2D>(@"Game\female");
                    if (keyState.IsKeyDown(Keys.Enter))
                    {
                        gender = "male";
                        Npcs.Add(new Npc.Npc("Map1_A", "Informer", 750, 130, 50, 64, false, false, false, false, @"Player\femalewalk", @"Player\female", false, false, false, false, 0, 0, 0, 0, 0, this, "informer", "nokey", null));
                        forestCharacter = Content.Load<Texture2D>(@"Player\forestMale");
                    }
                }
                if (gender != null)
                {
                    character = new cCharacter(this, gender);
                    testBoss = new Npc.Boss(new Rectangle(16 * 64, 7 * 64, 64, 64), this, "Map4_C");
                    UpdateActiveNpcs();
                    nextState = GameState.FOREST;
                    transition = true;
                }
            }
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            if (currentGameState == GameState.STARTMENU)
            {
                startMenu.Draw(spriteBatch); //calls it's own .Begin()
            }
            else if (currentGameState == GameState.GENDER)
            {
                spriteBatch.Begin();
                spriteBatch.Draw(male, new Rectangle(-40, 0, male.Width / 2, male.Height / 2), Color.White);
                spriteBatch.Draw(female, new Rectangle(graphics.PreferredBackBufferWidth - female.Width / 2, 0, female.Width / 2, female.Height / 2), Color.White);
                spriteBatch.DrawString(spriteFont, "Choose a gender, please.", new Vector2((graphics.PreferredBackBufferWidth / 2) - 20 * 6.38f, 6), new Color(200, 200, 200));
                spriteBatch.End();
            }
            else if (currentGameState == GameState.FOREST)
            {
                spriteBatch.Begin();
                spriteBatch.Draw(forest, new Rectangle(0, 0, 1280, 720), Color.White);
                spriteBatch.Draw(forestCharacter, new Rectangle(600, 400, 42, 69), Color.White);
                spriteBatch.Draw(forestCybot, new Rectangle(700, 400, forestCybot.Width, forestCybot.Height), Color.White);
                forestDialogue.Draw(spriteBatch);
                spriteBatch.End();
            }
            else
            {
                spriteBatch.Begin(SpriteSortMode.Immediate, null, SamplerState.PointClamp, null, null, null, camera.GetTransformation());
                map.DrawBackgroundLayer(spriteBatch, new Rectangle(0, 0, 1280, 720));
                particleSystem.Draw(spriteBatch);
                character.Draw(spriteBatch);
                map.DrawInteractiveLayer(spriteBatch, new Rectangle(0, 0, 1280, 720));
                if (ribbon.IsOnMap() && !ribbon.added)
                {
                    ribbon.Draw(spriteBatch);
                }
                for (int i = 0; i < Mobs.Count; i++)
                {
                    if (Mobs[i].IsOnMap())
                    {
                        Mobs[i].Draw(spriteBatch);
                    }
                }
                for (int i = 0; i < activeNpcs.Count; i++)
                {
                    activeNpcs[i].Draw(spriteBatch);
                }
                if (testBoss.IsOnMap())
                {
                    testBoss.Draw(spriteBatch);
                }
                for (int i = 0; i < keys.Count; i++)
                {
                    if (keys[i].mapName == map.mapName.Remove(map.mapName.Length - 1))
                    {
                        keys[i].Draw(spriteBatch);
                    }
                }
                map.DrawForegroundLayer(spriteBatch, new Rectangle(0, 0, 1280, 720));
                for (int i = 0; i < activeNpcs.Count; i++)
                {
                    activeNpcs[i].DrawHealth(spriteBatch);
                }

                if (testBoss.IsOnMap())
                {
                    testBoss.DrawMobs(spriteBatch);
                }
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
                for (int i = 0; i < keys.Count; i++)
                {
                    if (keys[i].mapName == map.mapName.Remove(map.mapName.Length - 1))
                    {
                        keys[i].DrawLabel(spriteBatch);
                        spriteBatch.DrawString(spriteFont, keys[i].key, new Vector2(keys[i].position.X, keys[i].position.Y - (keys[i].label.position.Height + 2)), new Color(20, 20, 20, 255));
                    }
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
                warpManager.Draw(spriteBatch, this);
                spriteBatch.End();
                if (character.health <= 0)
                {
                    spriteBatch.Begin();
                    character.DrawDeath(spriteBatch, this);
                    spriteBatch.End();
                }
            }

            spriteBatch.Begin();
            spriteBatch.Draw(fadeOverlay, screenRectangle, fadeColor);
            spriteBatch.End();
            //menu
            menu.Draw(spriteBatch);
            base.Draw(gameTime);
        }

        private void Transition(byte speed)
        {
            if (increaseAlpha)
            {
                fadeColor.A += speed;
                if (fadeColor.A >= 255)
                {
                    increaseAlpha = false;
                    currentGameState = nextState;
                }
            }
            else
            {
                fadeColor.A -= speed;
                if (fadeColor.A <= 0)
                {
                    transition = false;
                    increaseAlpha = true;
                }
            }
        }
    }
}
