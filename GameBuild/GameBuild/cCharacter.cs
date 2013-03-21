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
        Game1 game;
        public bool up = false, right = false, down = true, left = false;
        public bool faceUp = false, faceDown = false, faceLeft = false, faceRight = false;
        public bool attacking = false;
        public string oldFace;
        public Rectangle position;
        public Rectangle interactRect;
        public Vector2 vectorPos;
        public Texture2D spriteWalkSheet;
        public Texture2D spriteAttackSheet;
        public Texture2D shadowBlob;
        public Texture2D testTexture;
        cAnimationManager walkAnimations;
        cAnimationManager attackAnimations;
        Rectangle colRect;
        Rectangle frontOf;
        public int hp, mana;
        public Color hpColor;
        public int room;
        /// <summary>
        /// Steel tier items grant strength.
        /// Iron tier items grant strength and intellect.
        /// Leather tier items grant intellect.
        /// Players will also be able to upgrade stats after each level...
        /// More strength = more HP & more melee damage.
        /// More intellect  = more mana & more spell damage.
        /// </summary>
        public int playerHeight = 48; //size of the player sprite in pixels
        public int playerWidth = 48;

        H_Map.TileMap tile;
        public Color color = new Color(255, 255, 255, 255);//creates a new color so that we can easily make the character blink red when he gets hit

        public cCharacter(Game1 games)
        {
            game = games;
            testTexture = game.Content.Load<Texture2D>("blackness");
            spriteWalkSheet = game.Content.Load<Texture2D>("player/CharaWalkSheet");
            spriteAttackSheet = game.Content.Load<Texture2D>("player/CharaAttackSheet V2");
            shadowBlob = game.Content.Load<Texture2D>("player/shadowTex");
            position = new Rectangle(100, 100, playerWidth, playerWidth);
            interactRect = new Rectangle(position.X - (position.Width / 2), position.Y - (position.Height / 2), position.Width * 2, position.Height * 2);
            vectorPos = new Vector2(position.X, position.Y);
            colRect = new Rectangle();
            frontOf = new Rectangle(position.X + (position.Width / 2), position.Y + position.Height, 5, 5);
            walkAnimations = new cAnimationManager(spriteWalkSheet, 3, 4);
            attackAnimations = new cAnimationManager(spriteAttackSheet, 3, 4);
            walkAnimations.AddAnimation(100, true, new Vector2(0, 0), 3, "walkUp", false);
            walkAnimations.AddAnimation(100, true, new Vector2(0, 96), 3, "walkRight", false);
            walkAnimations.AddAnimation(100, true, new Vector2(0, 192), 3, "walkDown", false);
            walkAnimations.AddAnimation(100, true, new Vector2(0, 288), 3, "walkLeft", false);
            attackAnimations.AddAnimation(50, false, new Vector2(0, 0), 3, "attackUp", true);
            attackAnimations.AddAnimation(50, false, new Vector2(0, 96), 3, "attackRight", true);
            attackAnimations.AddAnimation(50, false, new Vector2(0, 192), 3, "attackDown", true);
            attackAnimations.AddAnimation(50, false, new Vector2(0, 288), 3, "attackLeft", true);
            hp = 100;
            hpColor = new Color(200, 200, 200, 255);
        }

        public void Update(Game1 games, H_Map.TileMap tiles, GameTime gameTime, KeyboardState oldState, GraphicsDevice graphicsDevice)
        {
            game = games;
            tile = tiles;
            interactRect.X = position.X - (position.Width / 2);
            interactRect.Y = position.Y - (position.Height / 2);
            Rectangle location = new Rectangle(position.X, position.Y, position.Width, position.Height);
            Rectangle corner1 = new Rectangle(colRect.X, colRect.Y, colRect.Width, colRect.Height);
            Rectangle corner2 = new Rectangle(colRect.X, colRect.Y, colRect.Width, colRect.Height);
            Rectangle halfcorner1 = new Rectangle(colRect.X, colRect.Y, colRect.Width, colRect.Height);
            Rectangle halfcorner2 = new Rectangle(colRect.X, colRect.Y + halfcorner1.Height, colRect.Width, colRect.Height);
            vectorPos.X = position.X;
            vectorPos.Y = position.Y;
            frontOf.X = position.X + (position.Width / 2);
            frontOf.Y = position.Y + position.Height;
            #region walk stuff
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

            if (!attacking)
            {
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
                }

                if (!IsCollision(tiles, corner1) && !IsCollision(tiles, corner2))
                {
                    position.X = location.X;
                    colRect = position;
                }


                if (up)
                {
                    walkAnimations.StartAnimation("walkUp");

                }
                if (down)
                {
                    walkAnimations.StartAnimation("walkDown");
                }
                if (left)
                {
                    walkAnimations.StartAnimation("walkLeft");
                }
                if (right)
                {
                    walkAnimations.StartAnimation("walkRight");
                }

                walkAnimations.UpdateFrame(gameTime);

                if (game.keyState.IsKeyUp(Keys.Up) && game.keyState.IsKeyUp(Keys.Down) && game.keyState.IsKeyUp(Keys.Left) && game.keyState.IsKeyUp(Keys.Right))
                {
                    walkAnimations.StopAnimation();
                }

            #endregion
                //Hp Color for lighting
                hpColor.B = (byte)(hp * 2.55);
                hpColor.G = (byte)(hp * 2.55);
            }
        }

        public bool IsCollision(H_Map.TileMap tiles, Rectangle location)
        {
            tile = tiles;
            Point tileIndex = tile.GetTileIndexFromVector(new Vector2(location.X, location.Y));
            return (tile.interactiveLayer[tileIndex.X, tileIndex.Y].isPassable == false);
        }

        public void AddHp(int amount)
        {
            if (hp < 100)
                hp += amount;
        }
        public void RemoveHp(int amount)
        {
            if (hp > 0)
                hp -= amount;
        }

        public void CheckCollision(H_Map.TileMap tiles, GameTime gameTime)
        {
            tile = tiles;
            Rectangle colRect = position;
            Point tileIndex = tile.GetTileIndexFromVector(new Vector2(colRect.X, colRect.Y));

            if (up)
            {
                colRect.Height += 10;
            }
            else if (left)
            {
                colRect.Width += 10;
            }
            else if (down)
            {
                colRect.Height += 10;
            }
            else if (right)
            {
                colRect.Width += 10;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle shadowPos = new Rectangle(position.X + 8, position.Bottom - shadowBlob.Height / 2, shadowBlob.Width, shadowBlob.Height);
            spriteBatch.Draw(shadowBlob, shadowPos, Color.White);
            spriteBatch.Draw(testTexture, interactRect, new Color(100, 100, 100, 100));
            //spriteBatch.Draw(testTexture, frontOf, new Color(10, 10, 10));
            if (!attacking)
            {
                walkAnimations.Draw(spriteBatch, position);
            }
            else if (attacking)
            {
                attackAnimations.Draw(spriteBatch, position);
            }

        }
    }
}
