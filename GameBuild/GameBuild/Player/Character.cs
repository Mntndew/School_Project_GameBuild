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
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace GameBuild
{
    public class Character
    {
        #region shit ton of variables
        public bool up = false, right = false, down = true, left = false;
        public bool attacking = false;
        public bool inCombat;
        public bool showInventory;
        public bool dead;
        public bool cutscene;
        bool isHit = false;
        public bool disabled = false;
        const float DISABLEDTIMER = 600f;
        float disabledTimer = 600f;

        public string gender;

        public int playerHeight = 48; //size of the player sprite in pixels
        public int playerWidth = 48;
        public int damage;
        public int speed;
        public int npcsInRectangle = 0;

        public float regenAmount;

        //Movement/collision vectors and rectangles
        public Rectangle positionRectangle;
        public Rectangle interactRect; //for npcs and stuff
        Rectangle leftSide, rightSide, upSide, downSide;
        public Vector2 position = Vector2.Zero;
        Vector2 acceleration = Vector2.Zero;
        Vector2 velocity = Vector2.Zero;

        public Rectangle attackRectangle;
        public Rectangle warpRectangle;

        Rectangle healthPos;
        public Vector2 bossTarget;//when the boss shoots.. follows the player with less speed...

        public Texture2D spriteSheet;
        public Texture2D shadowBlob;
        Texture2D debugTexture;
        Texture2D healthTexture;
        Texture2D healthBar;

        H_Map.TileMap tile;
        Random rand = new Random();

        public Color color = new Color(255, 255, 255, 255); //blink when player gets hit
        public Color hpColor;

        public float health;
        float healthBarWidth;
        float healthPct;
        public float maxHealth;
        float regenTimer = 1000;
        const float REGENTIMER = 1000;
        float bleedTimer = 3000;
        const float BLEEDTIMER = 3000;
        const float ATTACKTIMER = 600; //in total milliseconds
        float attackTimer = 0f;
        public float targetSpeed = 4;//for boss target
        float splashTimer = 0;
        const float SPLASHTIMER = 0.05f;

        public Inventory inventory;
        public List<DamageEffect> damageEffectList = new List<DamageEffect>();

        public AnimationComponent animation;

        public Player.CharacterWaypointManager waypointManager;

        ParticleSystemEmitter emitter;

        Game.Items.Sword sword;

        //Animations
        const int WALK_UP = 3;
        const int WALK_RIGHT = 0;
        const int WALK_DOWN = 1;
        const int WALK_LEFT = 2;
        const int IDLE_UP = 6;
        const int IDLE_DOWN = 4;
        const int IDLE_LEFT = 7;
        const int IDLE_RIGHT = 5;
        const int ATTACK_UP = 10;
        const int ATTACK_DOWN = 8;
        const int ATTACK_LEFT = 11;
        const int ATTACK_RIGHT = 9;
        bool walking = false;
        #endregion

        public Character(Game1 game, string gender)
        {
            health = 100;
            speed = 4;
            maxHealth = health;
            healthBar = game.Content.Load<Texture2D>(@"Game\Hp bar");
            this.gender = gender;

            #region Textures
            debugTexture = game.Content.Load<Texture2D>(@"Game\blackness");
            if (gender == "male")
            {
                spriteSheet = game.Content.Load<Texture2D>("Player/Sprite/Male/male");
                animation = new AnimationComponent(4, 8, 54, 70, 150, Point.Zero);
            }
            if (gender == "female")
            {
                spriteSheet = game.Content.Load<Texture2D>("Player/Sprite/Female/female");
                animation = new AnimationComponent(4, 8, 54, 70, 150, Point.Zero);
            }

            shadowBlob = game.Content.Load<Texture2D>("player/shadowTex");
            healthTexture = game.Content.Load<Texture2D>(@"Game\health100");
            #endregion

            #region Rectangles and Vectors
            if (gender == "male")
            {
                positionRectangle = new Rectangle(640, 640, 59, 64);
            }
            if (gender == "female")
            {
                positionRectangle = new Rectangle(640, 640, 59, 64);
            }
            position.X = positionRectangle.X;
            position.Y = positionRectangle.Y;
            interactRect = new Rectangle(positionRectangle.X - (positionRectangle.Width / 2), positionRectangle.Y - (positionRectangle.Height / 2), positionRectangle.Width * 2, positionRectangle.Height * 2);

            attackRectangle = new Rectangle();
            warpRectangle = new Rectangle();
            healthPos = new Rectangle();
            #endregion

            hpColor = new Color(200, 200, 200, 255);

            inventory = new Inventory(game);

            emitter = new ParticleSystemEmitter(game);
            Game1.particleSystem.emitters.Add(emitter);
            bossTarget = new Vector2(-128, -128);
            
        }

        public void Update(Game1 game, H_Map.TileMap tiles, GameTime gameTime, KeyboardState oldState, GraphicsDevice graphicsDevice)
        {
            #region Things to update every frame, positions and stuff
            healthPct = (health / maxHealth);
            healthBarWidth = (float)healthTexture.Width * healthPct;
            float elapsed = (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            positionRectangle.X = (int)position.X;
            positionRectangle.Y = (int)position.Y;
            if (showInventory)
            {
                animation.PauseAnimation();
            }

            if (Game1.testBoss.attackPlayer)
            {
                if (!Game1.testBoss.enraged)
                {
                    if (positionRectangle.X + (positionRectangle.Width / 2) - 16 > bossTarget.X)
                    {
                        bossTarget.X += targetSpeed / 1.2f;
                    }
                    if (positionRectangle.X + (positionRectangle.Width / 2) - 16 < bossTarget.X)
                    {
                        bossTarget.X -= targetSpeed / 1.2f;
                    }
                    if (positionRectangle.Y + (positionRectangle.Width / 2) - 16 > bossTarget.Y)
                    {
                        bossTarget.Y += targetSpeed / 1.2f;
                    }
                    if (positionRectangle.Y + (positionRectangle.Width / 2) - 16 < bossTarget.Y)
                    {
                        bossTarget.Y -= targetSpeed / 1.2f;
                    }
                }
                else
                {
                    if (positionRectangle.X + (positionRectangle.Width / 2) - 16 > bossTarget.X)
                    {
                        bossTarget.X += targetSpeed / 1.15f;
                    }
                    if (positionRectangle.X + (positionRectangle.Width / 2) - 16 < bossTarget.X)
                    {
                        bossTarget.X -= targetSpeed / 1.15f;
                    }
                    if (positionRectangle.Y + (positionRectangle.Width / 2) - 16 > bossTarget.Y)
                    {
                        bossTarget.Y += targetSpeed / 1.15f;
                    }
                    if (positionRectangle.Y + (positionRectangle.Width / 2) - 16 < bossTarget.Y)
                    {
                        bossTarget.Y -= targetSpeed / 1.15f;
                    }
                }
            }

            if (isHit)
            {
                Bleed();
                bleedTimer -= elapsed;
            }
            if (bleedTimer <= 0)
            {
                isHit = false;
                bleedTimer = BLEEDTIMER;
            }

            if (health <= 0)
            {
                dead = true;
                DeathEffect(game);
            }

            if (inCombat)
            {
                regenTimer = REGENTIMER;
            }
            else
                regenTimer -= elapsed;

            if (regenTimer <= 0)
            {
                if (health < maxHealth && !inCombat && !dead)
                {
                    regenAmount = rand.Next(3, 7);

                    if (maxHealth - health < regenAmount)
                        regenAmount = maxHealth - health;

                    health += regenAmount;
                    damageEffectList.Add(new DamageEffect((int)regenAmount, game, new Vector2(positionRectangle.X, positionRectangle.Y - 16), new Color(0, 255, 0, 255), "regen"));
                    Regen((int)regenAmount);
                    regenTimer = REGENTIMER;
                }
            }
            tile = tiles;

            if (left)
            {
                attackRectangle.Width = positionRectangle.Width * 2;
                attackRectangle.Height = 54;
                attackRectangle.X = positionRectangle.X - (attackRectangle.Width / 2) + 12;
                attackRectangle.Y = positionRectangle.Y + 5;

                warpRectangle.Width = positionRectangle.Width / 2;
                warpRectangle.Height = 5;
                warpRectangle.X = positionRectangle.X - warpRectangle.Width;
                warpRectangle.Y = positionRectangle.Y + (positionRectangle.Height / 2) + 2;
            }
            if (right)
            {
                attackRectangle.Width = positionRectangle.Width * 2;
                attackRectangle.Height = 54;
                attackRectangle.X = positionRectangle.X;
                attackRectangle.Y = positionRectangle.Y + 5;

                warpRectangle.Width = positionRectangle.Width / 2;
                warpRectangle.Height = 5;
                warpRectangle.X = positionRectangle.X + positionRectangle.Width;
                warpRectangle.Y = positionRectangle.Y + (positionRectangle.Height / 2) + 2;
            }
            if (up)
            {
                attackRectangle.Width = 54;
                attackRectangle.Height = positionRectangle.Height * 2;
                attackRectangle.X = positionRectangle.X;
                attackRectangle.Y = positionRectangle.Y - (positionRectangle.Height / 2);

                warpRectangle.Width = 5;
                warpRectangle.Height = positionRectangle.Height / 2;
                warpRectangle.X = positionRectangle.X + (positionRectangle.Width / 2) + 2;
                warpRectangle.Y = positionRectangle.Y - warpRectangle.Height;
            }
            if (down)
            {
                attackRectangle.Width = 54;
                attackRectangle.Height = positionRectangle.Height * 2;
                attackRectangle.X = positionRectangle.X;
                attackRectangle.Y = positionRectangle.Y;

                warpRectangle.Width = 5;
                warpRectangle.Height = positionRectangle.Height / 2;
                warpRectangle.X = positionRectangle.X + (positionRectangle.Width / 2);
                warpRectangle.Y = positionRectangle.Y + positionRectangle.Height;
            }

            animation.UpdateAnimation(gameTime);
            #endregion
            Console.WriteLine((int)position.Y);
            if (disabled)
            {
                disabledTimer -= elapsed;
                if (disabledTimer <= 0)
                {
                    disabled = false;
                    disabledTimer = DISABLEDTIMER;
                }
            }
            #region walk
            if (!attacking && !showInventory && !dead)
            {
                walking = false;
                if (!disabled)
                {
                    if (game.keyState.IsKeyDown(Keys.Up))
                    {
                        MoveUp(gameTime);
                    }

                    else if (game.keyState.IsKeyDown(Keys.Down))
                    {
                        MoveDown(gameTime);
                    }

                    if (game.keyState.IsKeyDown(Keys.Right))
                    {
                        MoveRight(gameTime);
                    }

                    else if (game.keyState.IsKeyDown(Keys.Left))
                    {
                        MoveLeft(gameTime);
                    }
                }
                try
                {
                    if (Game1.map.backgroundLayer[positionRectangle.X / Game1.map.tileWidth, positionRectangle.Y / Game1.map.tileHeight].tileID == 4
                                || Game1.map.backgroundLayer[positionRectangle.X / Game1.map.tileWidth, positionRectangle.Y / Game1.map.tileHeight].tileID == 8)
                    {
                        CalculateFriction(0.7f);
                    }
                    else
                        CalculateFriction(0.2f);
                }
                catch
                {
                    
                }
                if (waypointManager != null)
                {
                    if (!waypointManager.done)
                    {
                        waypointManager.Update(game, position, gameTime);
                    }
                    else
                    {
                        for (int i = 0; i < game.activeNpcs.Count; i++)
                        {
                            if (game.activeNpcs[i].name == "Celine")
                            {
                                game.activeNpcs[i].dialogue.dialogueManager = new DialogueManager(@"Content\Npc\dialogue\" + game.activeNpcs[i].thirdDialogue + ".txt");
                                game.activeNpcs[i].dialogue.dialogueManager.ReachedExit += game.activeNpcs[i].ExitedDialogue;
                                game.activeNpcs[i].dialogue.GetLines(0);
                                game.activeNpcs[i].isInteracting = true;
                                game.activeNpcs[i].dialogue.isTalking = true;
                                Game1.currentGameState = Game1.GameState.INTERACT;
                            }
                        }
                    }
                }
                
                try
                {
                    if (Game1.map.backgroundLayer[positionRectangle.X / Game1.map.tileWidth, positionRectangle.Y / Game1.map.tileHeight].tileID == 4
                                || Game1.map.backgroundLayer[positionRectangle.X / Game1.map.tileWidth, positionRectangle.Y / Game1.map.tileHeight].tileID == 8)
                    {
                        CalculateFriction(0.7f);
                    }
                    else
                        CalculateFriction(0.2f);

                    SetPosition();

                    if (leftSide.Intersects(tile.GetTileRectangleFromPosition(leftSide.X, leftSide.Y)) && !tile.CheckCellPositionPassable(new Vector2(leftSide.X, leftSide.Y)))
                    {
                        position.X = tile.GetTileRectangleFromPosition(leftSide.X, leftSide.Y).Right;
                        velocity.X = 0;
                    }
                    if (rightSide.Intersects(tile.GetTileRectangleFromPosition(rightSide.X, rightSide.Y)) && !tile.CheckCellPositionPassable(new Vector2(rightSide.X, rightSide.Y)))
                    {
                        position.X = tile.GetTileRectangleFromPosition(rightSide.X, rightSide.Y).Left - positionRectangle.Width;
                        velocity.X = 0;
                    }
                    if (upSide.Intersects(tile.GetTileRectangleFromPosition(upSide.X, upSide.Y)) && !tile.CheckCellPositionPassable(new Vector2(upSide.X, upSide.Y)))
                    {
                        position.Y = tile.GetTileRectangleFromPosition(upSide.X, upSide.Y).Bottom;
                        velocity.Y = 0;
                    }
                    if (downSide.Intersects(tile.GetTileRectangleFromPosition(downSide.X, downSide.Y)) && !tile.CheckCellPositionPassable(new Vector2(downSide.X, downSide.Y)))
                    {
                        position.Y = tile.GetTileRectangleFromPosition(downSide.X, downSide.Y).Top - positionRectangle.Height;
                        velocity.Y = 0;
                    }
                }
                catch
                {
                    velocity.X = 0;
                    velocity.Y = 0;
                }

                //Second side so yo say...
                try
                {
                    if (leftSide.Intersects(tile.GetTileRectangleFromPosition(leftSide.X, leftSide.Bottom)) && !tile.CheckCellPositionPassable(new Vector2(leftSide.X, leftSide.Bottom)))
                    {
                        position.X = tile.GetTileRectangleFromPosition(leftSide.X, leftSide.Bottom).Right;
                        velocity.X = 0;
                    }
                    if (rightSide.Intersects(tile.GetTileRectangleFromPosition(rightSide.X, rightSide.Bottom)) && !tile.CheckCellPositionPassable(new Vector2(rightSide.X, rightSide.Bottom)))
                    {
                        position.X = tile.GetTileRectangleFromPosition(rightSide.X, rightSide.Bottom).Left - positionRectangle.Width;
                        velocity.X = 0;
                    }
                    if (upSide.Intersects(tile.GetTileRectangleFromPosition(upSide.Right, upSide.Y)) && !tile.CheckCellPositionPassable(new Vector2(upSide.Right, upSide.Y)))
                    {
                        position.Y = tile.GetTileRectangleFromPosition(upSide.Right, upSide.Y).Bottom;
                        velocity.Y = 0;
                    }
                    if (downSide.Intersects(tile.GetTileRectangleFromPosition(downSide.Right, downSide.Y)) && !tile.CheckCellPositionPassable(new Vector2(downSide.Right, downSide.Y)))
                    {
                        position.Y = tile.GetTileRectangleFromPosition(downSide.Right, downSide.Y).Top - positionRectangle.Height;
                        velocity.Y = 0;
                    }
                }
                catch
                {
                    velocity.X = 0;
                    velocity.Y = 0;
                }
            }

            #endregion
            if (game.keyState.IsKeyDown(Keys.Tab) && oldState.IsKeyUp(Keys.Tab) && !dead)
            {
                if (showInventory)
                {
                    showInventory = false;
                }
                else
                    showInventory = true;
            }

            if (!animation.IsAnimationPlaying(ATTACK_UP) && !animation.IsAnimationPlaying(ATTACK_DOWN) && !animation.IsAnimationPlaying(ATTACK_LEFT) && !animation.IsAnimationPlaying(ATTACK_RIGHT))
            {
                attacking = false;
            }
            #region Attack
            attackTimer -= elapsed;
            if (sword != null)
            {
                if (game.keyState.IsKeyDown(Keys.Z) && game.oldState.IsKeyUp(Keys.Z) && !dead && attackTimer <= 0)
                {
                    attackTimer = ATTACKTIMER;
                    attacking = true;
                    animation.MaxFrameCount = 1;
                    if (up)
                    {
                        animation.PlayAnimation(ATTACK_UP);
                    }
                    else if (down)
                    {
                        animation.PlayAnimation(ATTACK_DOWN);
                    }
                    else if (left)
                    {
                        animation.PlayAnimation(ATTACK_LEFT);
                    }
                    else if (right)
                    {
                        animation.PlayAnimation(ATTACK_RIGHT);
                    }

                    foreach (Npc.Npc npc in game.activeNpcs)
                    {
                        if (npc.position.Intersects(attackRectangle))
                        {
                            if (npc.health > 0 && npc.IsOnMap() && npc.vulnerable)
                            {
                                damage = game.damageObject.dealDamage(sword.minDamage, sword.maxDamage);
                                damageEffectList.Add(new DamageEffect(damage, game, new Vector2(npc.position.X, npc.position.Y - 16), new Color(255, 255, 255, 255), "player"));
                                npc.health -= damage;
                                npc.attackPlayer = true;
                                npc.attackTimer += 300;
                                Slash(npc.position);
                            }
                        }
                    }
                    if (positionRectangle.Intersects(Game1.testBoss.position))
                    {
                        if (Game1.testBoss.health > 0 && Game1.testBoss.IsOnMap())
                        {
                            damage = game.damageObject.dealDamage(sword.minDamage, sword.maxDamage) * 2;
                            damageEffectList.Add(new DamageEffect(damage, game, new Vector2(Game1.testBoss.position.X, Game1.testBoss.position.Y - 16), new Color(255, 255, 255, 255), "player"));
                            Game1.testBoss.health -= damage;
                            Game1.testBoss.currentPhase = Npc.Boss.phase.sleep;
                        }
                    }
                    for (int i = 0; i < Game1.testBoss.mobs.Count; i++)
                    {
                        if (positionRectangle.Intersects(Game1.testBoss.mobs[i].position))
                        {
                            if (Game1.testBoss.mobs[i].health > 0)
                            {
                                damage = game.damageObject.dealDamage(sword.minDamage, sword.maxDamage);
                                damageEffectList.Add(new DamageEffect(damage, game, new Vector2(Game1.testBoss.mobs[i].position.X, Game1.testBoss.mobs[i].position.Y - 16), new Color(255, 255, 255, 255), "player"));
                                Game1.testBoss.mobs[i].health -= damage;
                                if (Game1.testBoss.mobs[i].health <= 0)
                                {
                                    Game1.testBoss.health -= 1;
                                }
                            }
                        }
                    }
                    for (int i = 0; i < game.Mobs.Count; i++)
                    {
                        if (game.Mobs[i].position.Intersects(attackRectangle))
                        {
                            if (game.Mobs[i].health > 0 && game.Mobs[i].IsOnMap())
                            {
                                damage = game.damageObject.dealDamage(sword.minDamage, sword.maxDamage);
                                damageEffectList.Add(new DamageEffect(damage, game, new Vector2(game.Mobs[i].position.X, game.Mobs[i].position.Y - 16), new Color(255, 255, 255, 255), "player"));
                                game.Mobs[i].health -= damage;
                                game.Mobs[i].attackPlayer = true;
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < damageEffectList.Count; i++)
            {
                damageEffectList[i].Effect();
            }

            inCombat = false;

            for (int i = 0; i < game.activeNpcs.Count; i++)
            {
                if (game.activeNpcs[i].health > 0)
                {
                    if (game.activeNpcs[i].attackPlayer)
                    {
                        inCombat = true;
                    }
                }
            }
            for (int i = 0; i < game.Mobs.Count; i++)
            {
                if (game.Mobs[i].health > 0)
                {
                    if (game.Mobs[i].attackPlayer)
                    {
                        inCombat = true;
                    }
                }
            }
            #endregion

            if (!walking && !attacking)
            {
                animation.MaxFrameCount = 1;
                if (up && !animation.IsAnimationPlaying(IDLE_UP))
                {
                    animation.LoopAnimation(IDLE_UP);
                }
                else if (down && !animation.IsAnimationPlaying(IDLE_DOWN))
                {
                    animation.LoopAnimation(IDLE_DOWN);
                }
                else if (left && !animation.IsAnimationPlaying(IDLE_LEFT))
                {
                    animation.LoopAnimation(IDLE_LEFT);
                }
                else if (right && !animation.IsAnimationPlaying(IDLE_RIGHT))
                {
                    animation.LoopAnimation(IDLE_RIGHT);
                }
            }
        }

        public void MoveUp(GameTime gameTime)
        {
            try
            {
                //effects
                if (Game1.map.backgroundLayer[positionRectangle.X / Game1.map.tileWidth, positionRectangle.Y / Game1.map.tileHeight].tileID == 4
                    || Game1.map.backgroundLayer[positionRectangle.X / Game1.map.tileWidth, positionRectangle.Y / Game1.map.tileHeight].tileID == 8)
                {
                    Splash(gameTime);
                }
                else
                    Walk();
            }
            catch
            {

            }
            up = true;
            down = false;
            left = false;
            right = false;

            ApplyForce(new Vector2(0, -2));

            animation.MaxFrameCount = 3;
            if (!animation.IsAnimationPlaying(WALK_UP))
            {
                animation.LoopAnimation(WALK_UP);
            }
            walking = true;
        }

        public void MoveDown(GameTime gameTime)
        {
            try
            {
                //effects
                if (Game1.map.backgroundLayer[positionRectangle.X / Game1.map.tileWidth, positionRectangle.Y / Game1.map.tileHeight].tileID == 4
                    || Game1.map.backgroundLayer[positionRectangle.X / Game1.map.tileWidth, positionRectangle.Y / Game1.map.tileHeight].tileID == 8)
                {
                    Splash(gameTime);
                }
                else
                    Walk();
            }
            catch
            {

            }
            down = true;
            up = false;
            right = false;
            left = false;

            ApplyForce(new Vector2(0, 2));
            animation.MaxFrameCount = 3;
            if (!animation.IsAnimationPlaying(WALK_DOWN))
            {
                animation.LoopAnimation(WALK_DOWN);
            }
            walking = true;
        }

        public void MoveRight(GameTime gameTime)
        {
            try
            {
                //effects
                if (Game1.map.backgroundLayer[positionRectangle.X / Game1.map.tileWidth, positionRectangle.Y / Game1.map.tileHeight].tileID == 4
                    || Game1.map.backgroundLayer[positionRectangle.X / Game1.map.tileWidth, positionRectangle.Y / Game1.map.tileHeight].tileID == 8)
                {
                    Splash(gameTime);
                }
                else
                    Walk();
            }
            catch
            { 
            
            }
            right = true;
            left = false;
            up = false;
            down = false;

            ApplyForce(new Vector2(2, 0));
            animation.MaxFrameCount = 3;
            if (!animation.IsAnimationPlaying(WALK_RIGHT))
            {
                animation.LoopAnimation(WALK_RIGHT);
            }
            walking = true;
        }

        public void MoveLeft(GameTime gameTime)
        {
            try
            {
                //effects
                if (Game1.map.backgroundLayer[positionRectangle.X / Game1.map.tileWidth, positionRectangle.Y / Game1.map.tileHeight].tileID == 4
                    || Game1.map.backgroundLayer[positionRectangle.X / Game1.map.tileWidth, positionRectangle.Y / Game1.map.tileHeight].tileID == 8)
                {
                    Splash(gameTime);
                }
                else
                    Walk();
            }
            catch
            {

            }

            left = true;
            right = false;
            up = false;
            down = false;

            ApplyForce(new Vector2(-2, 0));
            animation.MaxFrameCount = 3;
            if (!animation.IsAnimationPlaying(WALK_LEFT))
            {
                animation.LoopAnimation(WALK_LEFT);
            }
            walking = true;
        }

        public bool HasItem(string item)
        {
            for (int y = 0; y < inventory.height; y++)
            {
                if (inventory.inventorySlot[0, y].item == item)
                {
                    return true;
                }
            }
            return false;
        }

        public void DeathEffect(Game1 game)
        {
            if (game.screenColor.A < 255)
            {
                game.screenColor.A += 5;
            }
        }

        #region Particle Effects
        public void Hit()
        {
            emitter.Add(positionRectangle.X + 24, positionRectangle.Y + 24, 6, 6, 10, -4, 4, -4, 4, new Color(255, 10, 10), 0.35f, 1, 1, false, false, true);
            isHit = true;
        }

        public void Bleed()
        {
            emitter.Add(positionRectangle.X + 24, positionRectangle.Y + 24, 6, 6, 1, 0, 0, -1, 3, new Color(255, 10, 10), 0.07f, 1, 1, false, false, true);
        }

        public void Regen(int amount)
        {
            emitter.Add(positionRectangle.X + 24, positionRectangle.Y + 24, 6, 6, amount * 2, -4, 4, -4, 4, new Color(10, 240, 10), 0.7f, 1, 1, false, false, false);
        }

        public void Walk()
        {
            emitter.Add(positionRectangle.X + 22, positionRectangle.Y + positionRectangle.Height - 5, 6, 6, 1, -2, 2, -3, -1, new Color(rand.Next(50, 65), rand.Next(35, 50), rand.Next(35, 50), rand.Next(100, 250)), 0.0f, 1, 1, false, false, true);
        }

        public void Splash(GameTime gameTime)
        {
            float elapsed = (float)gameTime.ElapsedGameTime.TotalSeconds;
            splashTimer -= elapsed;
            if (splashTimer <= 0)
            {
                emitter.Add(positionRectangle.X + positionRectangle.Width / 2, positionRectangle.Y + positionRectangle.Height - 15, rand.Next(5, 8), rand.Next(5, 8), 10, -2, 2, -5, 2, new Color(50, 50, 255), 0.2f, 1, 1, false, false, true);
                emitter.Add(positionRectangle.X + positionRectangle.Width / 2, positionRectangle.Y + positionRectangle.Height - 15, rand.Next(5, 8), rand.Next(5, 8), 10, -2, 2, -5, 2, new Color(50, 175, 255), 0.2f, 1, 1, false, false, true);
                emitter.Add(positionRectangle.X + positionRectangle.Width / 2, positionRectangle.Y + positionRectangle.Height - 15, rand.Next(5, 8), rand.Next(5, 8), 10, -2, 2, -5, 2, new Color(200, 200, 200), 0.2f, 1, 1, false, false, true);
                splashTimer = SPLASHTIMER;
            }
        }

        public void Slash(Rectangle enemyPos)
        {
            emitter.Add(enemyPos.X + enemyPos.Width / 2, enemyPos.Y + enemyPos.Height / 2, rand.Next(5, 8), rand.Next(5, 8), 20, -4, 4, -4, 4, new Color(200, 20, 20, 255), 1, 1, 1, false, false, true);
            emitter.Add(enemyPos.X + enemyPos.Width / 2, enemyPos.Y + enemyPos.Height / 2, rand.Next(5, 8), rand.Next(5, 8), 10, -4, 4, -4, 4, new Color(200, 20, 20, 255), 1, 1, 1, false, false, true);
        }
        #endregion

        public void GetSword(Game.Items.Sword sword, Game1 game)
        {
            this.sword = new Game.Items.Sword(sword.swordName, sword.minDamage, sword.maxDamage);
            this.sword.SetSprite(sword.swordName, game);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle shadowPos = new Rectangle(positionRectangle.X + (positionRectangle.Width / 2 - shadowBlob.Width / 2), positionRectangle.Bottom - shadowBlob.Height / 2, shadowBlob.Width, shadowBlob.Height);
            spriteBatch.Draw(shadowBlob, shadowPos, Color.White);
            spriteBatch.Draw(spriteSheet, positionRectangle, animation.GetFrame(), Color.White);
        }

        public void DrawDeath(SpriteBatch spriteBatch, Game1 game)
        {
            spriteBatch.Draw(game.screenTexture, game.screen, game.screenColor);
        }

        public void DrawHealthBar(SpriteBatch spriteBatch, Game1 game)
        {
            if (healthTexture != null)
            {
                spriteBatch.Draw(healthTexture, new Rectangle(healthPos.X, healthPos.Y, healthPos.Width - 2, healthPos.Height), Color.White);
                spriteBatch.Draw(healthBar, new Rectangle(healthPos.X - 7, healthPos.Y - 15, 64, 30), Color.White);
                for (int i = 0; i < damageEffectList.Count; i++)
                {
                    damageEffectList[i].Draw(spriteBatch, game);
                }
            }
        }

        public void Push(Vector2 direction, float force)
        {
            direction *= force;
            ApplyForce(direction);
        }

        private void ApplyForce(Vector2 force)
        {
            acceleration += force;
        }

        private void CalculateFriction(float c)
        {
            if (velocity == Vector2.Zero)
            {
                return;
            }
            Vector2 friction = velocity;
            friction.Normalize();
            float normal = 1; //power of the normal force pushing on the object making it not slip through the floor(not important here)
            float magnitude = c * normal;
            friction *= magnitude - 1;
            ApplyForce(friction);
        }

        private void SetPosition()
        {
            velocity += acceleration;
            if ((velocity.X < 0.5 && velocity.X > -0.5) && (velocity.Y < 0.5 && velocity.Y > -0.5))
            {
                velocity = Vector2.Zero;
            }
            else if (velocity.Length() > 6f && walking)
            {
                velocity = Vector2.Normalize(velocity) * 6;
            }

            position += velocity;
            positionRectangle.X = (int)position.X;
            positionRectangle.Y = (int)position.Y;
            acceleration = Vector2.Zero;

            leftSide = new Rectangle(positionRectangle.X, positionRectangle.Y + 6, 1, positionRectangle.Height - 12);
            rightSide = new Rectangle(positionRectangle.Right, positionRectangle.Y + 6, 1, positionRectangle.Height - 12);
            upSide = new Rectangle(positionRectangle.X + 6, positionRectangle.Y, positionRectangle.Width - 12, 1);
            downSide = new Rectangle(positionRectangle.X + 6, positionRectangle.Bottom, positionRectangle.Width - 12, 1);

            interactRect.X = positionRectangle.X - (positionRectangle.Width / 2);
            interactRect.Y = positionRectangle.Y - (positionRectangle.Height / 2);

            healthPos.X = positionRectangle.X;
            healthPos.Y = positionRectangle.Y - 10;
            healthPos.Width = (int)healthBarWidth;
            healthPos.Height = healthTexture.Height;
        }

        private void ResetPosition()
        {
            positionRectangle.X = 640;
            positionRectangle.Y = 640;
        }

        public void Disable()
        {
            disabled = true;
            disabledTimer = DISABLEDTIMER;
        }
    }
}
