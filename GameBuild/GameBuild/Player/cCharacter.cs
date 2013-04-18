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
    public class cCharacter
    {
        public bool up = false, right = false, down = true, left = false;
        public bool attacking = false;
        bool inCombat;
        public bool showInventory;
        public bool dead;
        bool isHit = false;

        public string gender;

        public int playerHeight = 48; //size of the player sprite in pixels
        public int playerWidth = 48;
        public int damage;

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

        public Texture2D spriteWalkSheet;
        public Texture2D spriteAttackSheet;
        public Texture2D shadowBlob;
        Texture2D debugTexture;
        Texture2D healthTexture;

        H_Map.TileMap tile;
        Random rand = new Random();

        public Color color = new Color(255, 255, 255, 255); //blink when player gets hit
        public Color hpColor;

        public float health;
        float healthBarWidth;
        float healthPct;
        public float maxHealth;
        float regenTimer = 1;
        const float REGENTIMER = 1;
        float bleedTimer = 3;
        const float BLEEDTIMER = 3;
        const float ATTACKTIMER = 500f; //in total milliseconds
        float attackTimer = 500f;

        public Inventory inventory;
        public List<DamageEffect> damageEffectList = new List<DamageEffect>();

        AnimationComponent animation;

        ParticleSystemEmitter emitter;

        //Animations
        const int WALK_UP = 0;
        const int WALK_RIGHT = 1;
        const int WALK_DOWN = 2;
        const int WALK_LEFT = 3;
        bool walking = false;


        public cCharacter(Game1 game, string gender)
        {
            health = 100;
            maxHealth = health;

            this.gender = gender;

            #region Textures
            debugTexture = game.Content.Load<Texture2D>(@"Game\blackness");
            spriteWalkSheet = game.Content.Load<Texture2D>("player/CharaWalkSheet");
            spriteAttackSheet = game.Content.Load<Texture2D>("player/CharaAttackSheet V2");
            shadowBlob = game.Content.Load<Texture2D>("player/shadowTex");
            healthTexture = game.Content.Load<Texture2D>(@"Game\health100");
            #endregion

            #region Rectangles and Vectors
            positionRectangle = new Rectangle(640, 640, playerWidth, playerHeight);
            position.X = positionRectangle.X;
            position.Y = positionRectangle.Y;
            interactRect = new Rectangle(positionRectangle.X - (positionRectangle.Width / 2), positionRectangle.Y - (positionRectangle.Height / 2), positionRectangle.Width * 2, positionRectangle.Height * 2);
            
            attackRectangle = new Rectangle();
            warpRectangle = new Rectangle();
            healthPos = new Rectangle();
            #endregion

            hpColor = new Color(200, 200, 200, 255);

            inventory = new Inventory(game);
            animation = new AnimationComponent(3, 4, 72, 96, 100, Point.Zero);
            emitter = new ParticleSystemEmitter(game);
            Game1.particleSystem.emitters.Add(emitter);
        }

        public void Update(Game1 game, H_Map.TileMap tiles, GameTime gameTime, KeyboardState oldState, GraphicsDevice graphicsDevice)
        {
            #region Things to update every frame, positions and stuff
            healthPct = (health / maxHealth);
            healthBarWidth = (float)healthTexture.Width * healthPct;
            float elapsed = (float)gameTime.ElapsedGameTime.TotalSeconds;
            if (showInventory)
            {
                animation.PauseAnimation();
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
                }
                
                regenTimer = REGENTIMER;
            }
            tile = tiles;

            if (left)
            {
                attackRectangle.Width = positionRectangle.Width + (positionRectangle.Width / 2);
                attackRectangle.Height = 48;
                attackRectangle.X = positionRectangle.X - (attackRectangle.Width / 2) + 12;
                attackRectangle.Y = positionRectangle.Y + 5;

                warpRectangle.Width = positionRectangle.Width / 2;
                warpRectangle.Height = 5;
                warpRectangle.X = positionRectangle.X - warpRectangle.Width;
                warpRectangle.Y = positionRectangle.Y + (positionRectangle.Height / 2) + 2;
            }
            if (right)
            {
                attackRectangle.Width = positionRectangle.Width + (positionRectangle.Width / 2);
                attackRectangle.Height = 48;
                attackRectangle.X = positionRectangle.X;
                attackRectangle.Y = positionRectangle.Y + 5;

                warpRectangle.Width = positionRectangle.Width / 2;
                warpRectangle.Height = 5;
                warpRectangle.X = positionRectangle.X + positionRectangle.Width;
                warpRectangle.Y = positionRectangle.Y + (positionRectangle.Height / 2) + 2;
            }
            if (up)
            {
                attackRectangle.Width = positionRectangle.Width;
                attackRectangle.Height = positionRectangle.Height + (positionRectangle.Height / 2);
                attackRectangle.X = positionRectangle.X;
                attackRectangle.Y = positionRectangle.Y - (positionRectangle.Height / 2);

                warpRectangle.Width = 5;
                warpRectangle.Height = positionRectangle.Height / 2;
                warpRectangle.X = positionRectangle.X + (positionRectangle.Width / 2) + 2;
                warpRectangle.Y = positionRectangle.Y - warpRectangle.Height;
            }
            if (down)
            {
                attackRectangle.Width = positionRectangle.Width;
                attackRectangle.Height = positionRectangle.Height  + (positionRectangle.Height / 2);
                attackRectangle.X = positionRectangle.X;
                attackRectangle.Y = positionRectangle.Y;

                warpRectangle.Width = 5;
                warpRectangle.Height = positionRectangle.Height / 2;
                warpRectangle.X = positionRectangle.X + (positionRectangle.Width / 2);
                warpRectangle.Y = positionRectangle.Y + positionRectangle.Height;
            }

            animation.UpdateAnimation(gameTime);
            #endregion

            #region walk
            
            if (!attacking && !showInventory && !dead)// && cWarp.canWalk
            {
                walking = false;
                if (game.keyState.IsKeyDown(Keys.Up))
                {
                    //effects
                    if (Game1.map.backgroundLayer[positionRectangle.X / Game1.map.tileWidth, positionRectangle.Y / Game1.map.tileHeight].tileID == 4
                        || Game1.map.backgroundLayer[positionRectangle.X / Game1.map.tileWidth, positionRectangle.Y / Game1.map.tileHeight].tileID == 8)
                    {
                        Splash();
                    }
                    else
                        Walk();
                    
                    up = true;
                    down = false;
                    left = false;
                    right = false;

                    ApplyForce(new Vector2(0, -2));

                    if (!animation.IsAnimationPlaying(WALK_UP))
                    {
                        animation.LoopAnimation(WALK_UP);
                    }
                    walking = true;
                }
                else if (game.keyState.IsKeyDown(Keys.Down))
                {
                    //effects
                    if (Game1.map.backgroundLayer[positionRectangle.X / Game1.map.tileWidth, positionRectangle.Y / Game1.map.tileHeight].tileID == 4
                        || Game1.map.backgroundLayer[positionRectangle.X / Game1.map.tileWidth, positionRectangle.Y / Game1.map.tileHeight].tileID == 8)
                    {
                        Splash();
                    }
                    else
                        Walk();

                    down = true;
                    up = false;
                    right = false;
                    left = false;

                    ApplyForce(new Vector2(0, 2));
                    
                    if (!animation.IsAnimationPlaying(WALK_DOWN))
                    {
                        animation.LoopAnimation(WALK_DOWN);
                    }
                    walking = true;
                }

                if (game.keyState.IsKeyDown(Keys.Right))
                {
                    //effects
                    if (Game1.map.backgroundLayer[positionRectangle.X / Game1.map.tileWidth, positionRectangle.Y / Game1.map.tileHeight].tileID == 4 
                        || Game1.map.backgroundLayer[positionRectangle.X / Game1.map.tileWidth, positionRectangle.Y / Game1.map.tileHeight].tileID == 8)
                    {
                        Splash();
                    }
                    else
                        Walk();

                    right = true;
                    left = false;
                    up = false;
                    down = false;


                    ApplyForce(new Vector2(2, 0));

                    if (!animation.IsAnimationPlaying(WALK_RIGHT))
                    {
                        animation.LoopAnimation(WALK_RIGHT);
                    }
                    walking = true;
                }
                else if (game.keyState.IsKeyDown(Keys.Left))
                {
                    //effects
                    if (Game1.map.backgroundLayer[positionRectangle.X / Game1.map.tileWidth, positionRectangle.Y / Game1.map.tileHeight].tileID == 4
                        || Game1.map.backgroundLayer[positionRectangle.X / Game1.map.tileWidth, positionRectangle.Y / Game1.map.tileHeight].tileID == 8)
                    {
                        Splash();
                    }
                    else
                        Walk();

                    left = true;
                    right = false;
                    up = false;
                    down = false;

                    ApplyForce(new Vector2(-2, 0));

                    if (!animation.IsAnimationPlaying(WALK_LEFT))
                    {
                        animation.LoopAnimation(WALK_LEFT); 
                    }
                    walking = true;
                }
                if (!walking)
                {
                    animation.PauseAnimation();
                }

                if (leftSide.Intersects(tile.GetTileRectangleFromPosition(leftSide.X, leftSide.Y)) && !tile.CheckCellPositionPassable(new Vector2(leftSide.X, leftSide.Y)))
                {
                    position.X = tile.GetTileRectangleFromPosition(leftSide.X, leftSide.Y).Right;
                    velocity.X = 0;
                }
                if (rightSide.Intersects(tile.GetTileRectangleFromPosition(rightSide.X, rightSide.Y)) && !tile.CheckCellPositionPassable(new Vector2(rightSide.X, rightSide.Y)))
                {
                    position.X = tile.GetTileRectangleFromPosition(rightSide.X, rightSide.Y).Left;
                    velocity.X = 0;
                }
                if (upSide.Intersects(tile.GetTileRectangleFromPosition(upSide.X, upSide.Y)) && !tile.CheckCellPositionPassable(new Vector2(upSide.X, upSide.Y)))
                {
                    position.Y = tile.GetTileRectangleFromPosition(upSide.X, upSide.Y).Bottom;
                    velocity.Y = 0;
                }
                if (downSide.Intersects(tile.GetTileRectangleFromPosition(downSide.X, downSide.Y)) && !tile.CheckCellPositionPassable(new Vector2(downSide.X, downSide.Y)))
                {
                    position.Y = tile.GetTileRectangleFromPosition(downSide.X, downSide.Y).Top;
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

            #region Attack
            attackTimer -= (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            if (game.keyState.IsKeyDown(Keys.Z) && game.oldState.IsKeyUp(Keys.Z) && !dead && attackTimer <= 0)
            {
                attackTimer = ATTACKTIMER;
                foreach (Npc.Npc npc in game.activeNpcs)
                {
                    if (npc.position.Intersects(attackRectangle))
                    {
                        damage = game.damageObject.dealDamage(5, 30);
                        if (npc.health > 0)
                        {
                            damageEffectList.Add(new DamageEffect(damage, game, new Vector2(npc.position.X, npc.position.Y - 16), new Color(255, 255, 255, 255), "player"));
                            npc.health -= damage;
                            npc.attackPlayer = true;
                        }
                    }
                }
                for (int i = 0; i < game.Mobs.Count; i++)
                {
                    if (game.Mobs[i].position.Intersects(attackRectangle))
                    {
                        damage = game.damageObject.dealDamage(5, 30);
                        if (game.Mobs[i].health > 0)
                        {
                            damageEffectList.Add(new DamageEffect(damage, game, new Vector2(game.Mobs[i].position.X, game.Mobs[i].position.Y - 16), new Color(255, 255, 255, 255), "player"));
                            game.Mobs[i].health -= damage;
                            game.Mobs[i].attackPlayer = true;
                        }
                    }
                }
            }

            for (int i = 0; i < damageEffectList.Count; i++)
            {
                damageEffectList[i].Effect();
            }

            for (int i = 0; i < game.Npcs.Count; i++)
            {
                if (game.Npcs[i].health > 0)
                {
                    if (game.Npcs[i].attackPlayer)
                    {
                        inCombat = true;
                    }
                    else
                        inCombat = false;
                }
                else
                {
                    inCombat = false;
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
                else
                {
                    inCombat = false;
                }
            }
            #endregion
            CalculateFriction();
            SetPosition();
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

        public void Splash()
        {
            emitter.Add(positionRectangle.X + 22, positionRectangle.Y + positionRectangle.Height - 5, rand.Next(5, 8), rand.Next(5, 8), 6, -2, 2, -3, -1, new Color(50, 50, 255), 0.05f, 1, 1, false, false, true);
            emitter.Add(positionRectangle.X + 22, positionRectangle.Y + positionRectangle.Height - 5, rand.Next(5, 8), rand.Next(5, 8), 6, -2, 2, -3, -1, new Color(200, 200, 200), 0.05f, 1, 1, false, false, true);
        }
        #endregion

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle shadowPos = new Rectangle(positionRectangle.X + 8, positionRectangle.Bottom - shadowBlob.Height / 2, shadowBlob.Width, shadowBlob.Height);
            spriteBatch.Draw(shadowBlob, shadowPos, Color.White);
            spriteBatch.Draw(spriteWalkSheet, positionRectangle, animation.GetFrame(), Color.White);
            spriteBatch.Draw(debugTexture, leftSide, Color.Cyan);
            spriteBatch.Draw(debugTexture, rightSide, Color.Cyan);
            spriteBatch.Draw(debugTexture, upSide, Color.Cyan);
            spriteBatch.Draw(debugTexture, downSide, Color.Cyan);
        }

        public void DrawDeath(SpriteBatch spriteBatch, Game1 game)
        {
            spriteBatch.Draw(game.screenTexture, game.screen, game.screenColor);
        }

        public void DrawHealthBar(SpriteBatch spriteBatch, Game1 game)
        {
            if (healthTexture != null)
            {
                spriteBatch.Draw(healthTexture, healthPos, Color.White);
                for (int i = 0; i < damageEffectList.Count; i++)
                {
                    damageEffectList[i].Draw(spriteBatch, game);
                }
            }
        }

        public void Push(Vector2 direction)
        {

        }

        private void ApplyForce(Vector2 force)
        {
            acceleration += force;
        }

        private void CalculateFriction()
        {
            if (velocity == Vector2.Zero)
            {
                return;
            }
            Vector2 friction = velocity;
            friction.Normalize();
            float c = 0.01f; //coefficient of the friction (how slippery a material is)
            float normal = 1; //power of the normal force pushing on the object making it not slip through the floor(not important here)
            float magnitude = c * normal;
            friction *= magnitude-1;
            ApplyForce(friction);
        }

        private void SetPosition()
        {
            velocity += acceleration;
            if ((velocity.X < 0.5 && velocity.X > -0.5) && (velocity.Y < 0.5 && velocity.Y > -0.5))
            {
                velocity = Vector2.Zero;
            }
            else if (velocity.Length() > 8f)
            {
                velocity = Vector2.Normalize(velocity) * 6;
            }

            position += velocity;
            positionRectangle.X = (int)position.X;
            positionRectangle.Y = (int)position.Y;
            acceleration = Vector2.Zero;

            leftSide = new Rectangle(positionRectangle.X, positionRectangle.Y + 2, 1, positionRectangle.Height - 4);
            rightSide = new Rectangle(positionRectangle.Right, positionRectangle.Y + 2, 1, positionRectangle.Height - 4);
            upSide = new Rectangle(positionRectangle.X + 2, positionRectangle.Y, positionRectangle.Width - 4, 1);
            downSide = new Rectangle(positionRectangle.X + 2, positionRectangle.Bottom, positionRectangle.Width - 4, 1);
            Console.WriteLine("X: {0}, Y: {1}", velocity.X, velocity.Y);

            interactRect.X = positionRectangle.X - (positionRectangle.Width / 2);
            interactRect.Y = positionRectangle.Y - (positionRectangle.Height / 2);

            healthPos.X = positionRectangle.X;
            healthPos.Y = positionRectangle.Y - 10;
            healthPos.Width = (int)healthBarWidth;
            healthPos.Height = healthTexture.Height;
        }
    }
}
