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
        public bool faceUp = false, faceDown = false, faceLeft = false, faceRight = false;
        public bool attacking = false;
        bool inCombat;
        public bool showInventory;
        public bool dead;

        public int playerHeight = 48; //size of the player sprite in pixels
        public int playerWidth = 48;
        public int damage;

        public float regenAmount;

        public Rectangle position;
        public Rectangle interactRect; //for npcs and stuff
        Rectangle colRect;
        public Vector2 vectorPos; //for camera
        public Rectangle attackRectangle;
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

        public Inventory inventory;
        public List<DamageEffect> damageEffectList = new List<DamageEffect>();

        AnimationComponent animation;

        //Animations
        const int WALK_UP = 0;
        const int WALK_RIGHT = 1;
        const int WALK_DOWN = 2;
        const int WALK_LEFT = 3;
        bool walking = false;

        public cCharacter(Game1 game)
        {
            health = 100;
            maxHealth = health;

            #region Textures
            debugTexture = game.Content.Load<Texture2D>(@"Game\blackness");
            spriteWalkSheet = game.Content.Load<Texture2D>("player/CharaWalkSheet");
            spriteAttackSheet = game.Content.Load<Texture2D>("player/CharaAttackSheet V2");
            shadowBlob = game.Content.Load<Texture2D>("player/shadowTex");
            healthTexture = game.Content.Load<Texture2D>(@"Game\health100");
            #endregion

            #region Rectangles and Vectors
            position = new Rectangle(640, 256, playerWidth, playerWidth);
            interactRect = new Rectangle(position.X - (position.Width / 2), position.Y - (position.Height / 2), position.Width * 2, position.Height * 2);
            vectorPos = new Vector2(position.X, position.Y);
            colRect = new Rectangle();
            attackRectangle = new Rectangle();
            healthPos = new Rectangle();
            #endregion

            hpColor = new Color(200, 200, 200, 255);

            inventory = new Inventory(game);
            animation = new AnimationComponent(3, 4, 72, 96, 100, Point.Zero);
        }

        public void Update(Game1 game, H_Map.TileMap tiles, GameTime gameTime, KeyboardState oldState, GraphicsDevice graphicsDevice)
        {
            #region Things to update every frame, positions and stuff
            if (showInventory)
            {
                inventory.Update(game, gameTime);
            }
            healthPct = (health / maxHealth);
            healthBarWidth = (float)healthTexture.Width * healthPct;
            float elapsed = (float)gameTime.ElapsedGameTime.TotalSeconds;

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
                    damageEffectList.Add(new DamageEffect((int)regenAmount, game, new Vector2(position.X, position.Y - 16), new Color(0, 255, 0, 255), "regen"));
                }
                
                regenTimer = REGENTIMER;
            }
            tile = tiles;
            interactRect.X = position.X - (position.Width / 2);
            interactRect.Y = position.Y - (position.Height / 2);
            Rectangle location = new Rectangle(position.X, position.Y, position.Width, position.Height);
            Rectangle corner1 = new Rectangle(colRect.X, colRect.Y, colRect.Width, colRect.Height);
            Rectangle corner2 = new Rectangle(colRect.X, colRect.Y, colRect.Width, colRect.Height);
            Rectangle halfcorner1 = new Rectangle(colRect.X, colRect.Y, colRect.Width, colRect.Height);
            Rectangle halfcorner2 = new Rectangle(colRect.X, colRect.Y + halfcorner1.Height, colRect.Width, colRect.Height);
            healthPos.X = position.X;
            healthPos.Y = position.Y - 10;
            healthPos.Width = (int)healthBarWidth;
            healthPos.Height = healthTexture.Height;
            vectorPos.X = position.X;
            vectorPos.Y = position.Y;
            if (left)
            {
                attackRectangle.Width = position.Width + (position.Width / 2);
                attackRectangle.Height = 48;
                attackRectangle.X = position.X - (attackRectangle.Width / 2) + 12;
                attackRectangle.Y = position.Y + 5;
            }
            if (right)
            {
                attackRectangle.Width = position.Width + (position.Width / 2);
                attackRectangle.Height = 48;
                attackRectangle.X = position.X;
                attackRectangle.Y = position.Y + 5;
            }
            if (up)
            {
                attackRectangle.Width = position.Width;
                attackRectangle.Height = position.Height + (position.Height / 2);
                attackRectangle.X = position.X;
                attackRectangle.Y = position.Y - (position.Height / 2);
            }
            if (down)
            {
                attackRectangle.Width = position.Width;
                attackRectangle.Height = position.Height  + (position.Height / 2);
                attackRectangle.X = position.X;
                attackRectangle.Y = position.Y;
            }

            animation.UpdateAnimation(gameTime);
            #endregion

            #region walk
            if (up)
            {
                faceUp = true;
                faceRight = false;
                faceLeft = false;
                faceDown = false;
            }
            if (down)
            {
                faceDown = true;
                faceRight = false;
                faceLeft = false;
                faceUp = false;
            }
            if (left)
            {
                faceLeft = true;
                faceRight = false;
                faceUp = false;
                faceDown = false;
            }
            if (right)
            {
                faceRight = true;
                faceUp = false;
                faceLeft = false;
                faceDown = false;
            }

            if (!attacking && !showInventory && cWarp.canWalk && !dead)
            {
                walking = false;
                if (game.keyState.IsKeyDown(Keys.Up))
                {
                    up = true;
                    down = false;
                    left = false;
                    right = false;
                    location.Y -= 4;
                    corner1 = tile.GetTileRectangleFromPosition(location.X, location.Y + (position.Height / 2));
                    corner2 = tile.GetTileRectangleFromPosition(location.X + playerWidth, location.Y + (position.Height / 2));
                    halfcorner1 = tile.GetTileRectangleFromPosition(location.X, location.Y);
                    halfcorner2 = tile.GetTileRectangleFromPosition(location.X, location.Y);
                    if (!animation.IsAnimationPlaying(WALK_UP))
                    {
                        animation.LoopAnimation(WALK_UP);
                    }
                    walking = true;
                }

                if (game.keyState.IsKeyDown(Keys.Down))
                {
                    down = true;
                    up = false;
                    right = false;
                    left = false;
                    location.Y += 4;
                    corner1 = tile.GetTileRectangleFromPosition(location.X, location.Y + playerHeight);
                    corner2 = tile.GetTileRectangleFromPosition(location.X + playerWidth, location.Y + playerHeight);
                    if (!animation.IsAnimationPlaying(WALK_DOWN))
                    {
                        animation.LoopAnimation(WALK_DOWN);
                    }
                    walking = true;
                }

                if (!IsCollision(tiles, corner1) && !IsCollision(tiles, corner2))
                {
                    position.Y = location.Y;
                    colRect = position;
                }

                if (game.keyState.IsKeyDown(Keys.Right))
                {
                    right = true;
                    left = false;
                    up = false;
                    down = false;
                    location.Y = position.Y;
                    location.X += 4;
                    corner1 = tile.GetTileRectangleFromPosition(location.X + playerWidth, location.Y + (position.Height / 2));
                    corner2 = tile.GetTileRectangleFromPosition(location.X + playerWidth, location.Y + playerHeight);
                    if (!animation.IsAnimationPlaying(WALK_RIGHT))
                    {
                        animation.LoopAnimation(WALK_RIGHT);
                    }
                    walking = true;
                }

                if (game.keyState.IsKeyDown(Keys.Left))
                {
                    left = true;
                    right = false;
                    up = false;
                    down = false;
                    location.X -= 4;
                    location.Y = position.Y;
                    corner1 = tile.GetTileRectangleFromPosition(location.X, location.Y + (position.Height / 2));
                    corner2 = tile.GetTileRectangleFromPosition(location.X, location.Y + playerHeight);
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

                if (!IsCollision(tiles, corner1) && !IsCollision(tiles, corner2))
                {
                    position.X = location.X;
                    colRect = position;
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
            if (game.keyState.IsKeyDown(Keys.Z) && game.oldState.IsKeyUp(Keys.Z) && !dead)
            {
                foreach (Npc npc in game.activeNpcs)
                {
                    if (npc.position.Intersects(attackRectangle))
                    {
                        damage = game.damageObject.dealDamage(5, 30);
                        if (npc.health >= 1)
                        {
                            damageEffectList.Add(new DamageEffect(damage, game, new Vector2(npc.position.X, npc.position.Y - 16), new Color(255, 255, 255, 255), "damage"));
                            npc.health -= damage;
                            npc.attackPlayer = true;
                        }
                    }
                }
            }

            for (int i = 0; i < damageEffectList.Count; i++)
            {
                damageEffectList[i].Effect();
            }

            foreach (Npc npc in game.activeNpcs)
            {
                if (npc.health > 0)
                {
                    if (npc.attackPlayer)
                    {
                        inCombat = true;
                    }
                    else
                        inCombat = false;
                }
                else
                {
                    inCombat = false;
                    game.Npcs.Remove(npc);
                }
            }
            #endregion
        }

        public void DeathEffect(Game1 game)
        {
            if (game.screenColor.A < 255)
            {
                game.screenColor.A += 5;
            }
        }

        public bool IsCollision(H_Map.TileMap tiles, Rectangle location)
        {
            Point tileIndex = tiles.GetTileIndexFromVector(new Vector2(location.X, location.Y));
            return (tiles.interactiveLayer[tileIndex.X, tileIndex.Y].isPassable == false);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle shadowPos = new Rectangle(position.X + 8, position.Bottom - shadowBlob.Height / 2, shadowBlob.Width, shadowBlob.Height);
            spriteBatch.Draw(shadowBlob, shadowPos, Color.White);
            spriteBatch.Draw(debugTexture, attackRectangle, new Color(100, 100, 100, 100));
            spriteBatch.Draw(debugTexture, interactRect, new Color(100, 100, 100, 100));
            spriteBatch.Draw(spriteWalkSheet, position, animation.GetFrame(), Color.White);
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
                inventory.Draw(spriteBatch, game);
                for (int i = 0; i < damageEffectList.Count; i++)
                {
                    damageEffectList[i].Draw(spriteBatch, game);
                }
            }
            if (health <= 0)
            {
                DrawDeath(spriteBatch, game);
            }
        }
    }
}
