using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.IO;

namespace GameBuild
{
    public class cNpc
    {
        Vector2 point1;
        Vector2 point2;
        Vector2 point3;
        Vector2 point4;
        public Rectangle position;
        Rectangle location;
        Rectangle corner1;
        Rectangle corner2;
        Rectangle colRect;
        Vector2 velocity;
        Rectangle patrolRect;
        Rectangle aPosition;
        Rectangle healthPos;

        Texture2D texture;
        Texture2D aTexture;
        public Texture2D healthTexture;

        float maxHealth;
        public float health;
        float healthPct;

        public float speed;
        float attackTimer = 1;
        const float ATTACKTIMER = 1;

        public bool point1Tagged = false, point2Tagged = false, point3Tagged = false, point4Tagged = false;
        public bool canInteract;
        public bool isOnMap;
        public bool hasBeenAdded = false;
        public bool isInteracting = false;
        public bool attackPlayer = false;
        bool addA = false;

        public string name;
        public string mapName;

        public enum patrolType
        {
            upDown,
            leftRight,
            box,
            none
        }
        public patrolType currentPatrolType = new patrolType();

        Color color = new Color(255, 50, 50, 100);
        Color aColor;

        public cDialogue dialogue;

        public cNpc(string mapName, string name, int x, int y, int width, int height, bool up, bool down, bool left, bool right, string spritePath, string portraitPath, bool patrolNone, bool patrolUpDown, bool patrolLeftRight, bool patrolBox, int patrolX, int patrolY, int patrolWidth, int patrolHeight, float speed, Game1 game, string dialoguePath)
        {
            dialogue = new cDialogue(game.Content.Load<Texture2D>(@"npc\portrait\" + portraitPath), game.Content.Load<Texture2D>("textBox"), game, game.spriteFont, dialoguePath, name);
            texture = game.Content.Load<Texture2D>(@"npc\sprite\" + spritePath);

            this.mapName = mapName;
            this.name = name;
            CheckMap(game);

            patrolRect = new Rectangle(patrolX, patrolY, patrolWidth, patrolHeight);
            point1 = new Vector2(patrolX, patrolY);
            point2 = new Vector2(patrolX + patrolWidth, patrolY);
            point3 = new Vector2(patrolX, patrolY + patrolHeight);
            point4 = new Vector2(patrolX + patrolWidth, patrolY + patrolHeight);
            position = new Rectangle(x, y, width - 1, height - 1);
            healthPos = new Rectangle(position.X + 8, position.Y - 15, 48, 10);
            velocity = new Vector2(0, 0);
            health = 200;
            aTexture = game.Content.Load<Texture2D>("A");
            aPosition = new Rectangle(0, 0, aTexture.Width, aTexture.Height);
            aColor = Color.White;
            patrolRect.X = position.X - ((patrolRect.Width / 2) - (position.Width / 2));
            patrolRect.Y = position.Y - ((patrolRect.Height / 2) - (position.Height / 2));
            colRect = position;
            if (patrolLeftRight)
            {
                currentPatrolType = patrolType.leftRight;
            }
            if (patrolUpDown)
            {
                currentPatrolType = patrolType.upDown;
            }
            if (patrolBox)
            {
                currentPatrolType = patrolType.box;
            }
            if (patrolNone)
            {
                currentPatrolType = patrolType.none;
            }

            maxHealth = 200;

            this.speed = speed;
        }

        public void CheckMap(Game1 game)
        {
            if (mapName == (game.map.mapName.Remove(game.map.mapName.Length - 1)))
            {
                isOnMap = true;
            }
            else
                isOnMap = false;
        }

        public void Attack(Game1 game, GameTime gameTime, H_Map.TileMap tiles)
        {
            
            if (game.character.position.Y < position.Y)
            {
                location.Y += (int)-speed * 2;
                corner1 = tiles.GetTileRectangleFromPosition(location.X, location.Y + (position.Height / 2));
                corner2 = tiles.GetTileRectangleFromPosition(location.X + texture.Width, location.Y + (position.Height / 2));
            }
            if (game.character.position.Y > position.Y)
            {
                location.Y += (int)speed * 2;
                corner1 = tiles.GetTileRectangleFromPosition(location.X, location.Y + texture.Height);
                corner2 = tiles.GetTileRectangleFromPosition(location.X + texture.Width, location.Y + texture.Height);
            }
            if (!IsCollision(tiles, corner1) && !IsCollision(tiles, corner2))
            {
                position.Y = location.Y;
                colRect = position;
            }
            if (game.character.position.X < position.X)
            {
                location.X += (int)-speed * 2;
                location.Y = position.Y;
                corner1 = tiles.GetTileRectangleFromPosition(location.X, location.Y + (position.Height / 2));
                corner2 = tiles.GetTileRectangleFromPosition(location.X, location.Y + texture.Height);
            }
            if (game.character.position.X > position.X)
            {
                location.Y = position.Y;
                location.X += (int)speed * 2;
                corner1 = tiles.GetTileRectangleFromPosition(location.X + texture.Width, location.Y + (position.Height / 2));
                corner2 = tiles.GetTileRectangleFromPosition(location.X + texture.Width, location.Y + texture.Height);
            }
            if (!IsCollision(tiles, corner1) && !IsCollision(tiles, corner2))
            {
                position.X = location.X;
                colRect = position;
            }
            float elapsed = (float)gameTime.ElapsedGameTime.TotalSeconds;
            if (game.character.position.Intersects(position))
            {

                attackTimer -= elapsed;
                if (attackTimer <= 0)
                {
                    game.character.health -= 15;
                    attackTimer = ATTACKTIMER;
                }
                
            }
        }

        public bool IsCollision(H_Map.TileMap tiles, Rectangle location)
        {
            Point tileIndex = tiles.GetTileIndexFromVector(new Vector2(location.X, location.Y));
            return (!tiles.interactiveLayer[tileIndex.X, tileIndex.Y].isPassable);
        }

        public void Update(cCharacter player, H_Map.TileMap tiles, Game1 game, GameTime gameTime)
        {
            #region things to update every frame, positions
            aPosition.X = position.X - (position.Width / 2);
            aPosition.Y = position.Y - (position.Height / 2);
            corner1 = new Rectangle(colRect.X, colRect.Y, colRect.Width, colRect.Height);
            corner2 = new Rectangle(colRect.X, colRect.Y, colRect.Width, colRect.Height);
            Rectangle location = new Rectangle(position.X, position.Y, position.Width, position.Height);
            position.X += (int)velocity.X;
            position.Y += (int)velocity.Y;
            healthPos.X = position.X + 8;
            healthPos.Y = position.Y - 15;
            healthPos.Width = 48;
            healthPos.Height = 10;
            for (int x = 0; x < game.map.mapWidth; x++)
            {
                for (int y = 0; y < game.map.mapHeight; y++)
                {
                    if (position.Intersects(game.map.interactiveLayer[x, y].textureRectangle))
                    {
                        if (!game.map.interactiveLayer[x, y].isPassable)
                        {
                            Console.WriteLine("INTERSECTING");
                        }
                    }
                }
            }
            #endregion
            CheckMap(game);

            healthPct = (health / maxHealth) * 100;
                if (healthPct <= 37)
                {
                    healthTexture = game.Content.Load<Texture2D>("health25");
                }
                if (healthPct > 37 && healthPct <= 62)
                {
                    healthTexture = game.Content.Load<Texture2D>("health50");
                }
                if (healthPct > 62 && healthPct <= 87)
                {
                    healthTexture = game.Content.Load<Texture2D>("health75");
                }
                if (healthPct > 87)
                {
                    healthTexture = game.Content.Load<Texture2D>("health100");
                }
                if (healthPct <= 0)
                {
                    healthTexture = game.Content.Load<Texture2D>("healthEmpty");
                }
                if (attackPlayer)
                {
                    canInteract = false;
                    Attack(game, gameTime, tiles);
                }
            if (game.currentGameState == Game1.GameState.PLAY)
            {
                if (currentPatrolType != patrolType.none)
                {
                    Patrol();
                }
            }

            #region Dialogue update stuff
            if (game.currentGameState == Game1.GameState.INTERACT)
            {
                dialogue.Update();
                if (!dialogue.isTalking && isInteracting == true)
                {
                    game.currentGameState = Game1.GameState.PLAY;
                    isInteracting = false;
                }
            }
            #endregion

            #region Player Interaction
            if (isOnMap)
            {
                if (position.Intersects(player.interactRect) && !attackPlayer)
                {
                    canInteract = true;
                    if (!isInteracting)
                    {
                        if (!addA)
                        {
                            aColor.A -= 10;
                            aColor.B += 10;
                            aColor.R -= 10;
                            aColor.G += 10;
                        }
                        if (aColor.A <= 50)
                        {
                            addA = true;
                        }
                        if (addA)
                        {
                            aColor.A += 10;
                            aColor.R += 10;
                            aColor.B -= 10;
                            aColor.G -= 10;
                        }
                        if (aColor.A >= 240)
                        {
                            addA = false;
                        }
                    }
                    else
                    {
                        this.dialogue.isTalking = true;
                    }
                }
                else
                {
                    canInteract = false;
                }
            }
            
            #endregion
        }

        public void Patrol()
        {
            switch (currentPatrolType)
            {
                case patrolType.upDown:
                    #region points
                    point1 = new Vector2(patrolRect.X + (patrolRect.Width / 2) - 8, patrolRect.Y);
                    point2 = new Vector2(patrolRect.X + (patrolRect.Width / 2) - 8, patrolRect.Y + patrolRect.Height);
                    #endregion
                    #region up/down
                    if (!point1Tagged)
                    {
                        if (point1.Y < position.Y)
                        {
                            velocity.Y = -speed;
                        }
                        if (point1.Y > position.Y)
                        {
                            velocity.Y = speed;
                        }

                        //if (point1.X > position.X)
                        //{
                        //    velocity.X = speed;
                        //}
                        //if (point1.X < position.X)
                        //{
                        //    velocity.X = -speed;
                        //}
                        //if (position.X == point1.X)
                        //{
                            velocity.X = 0;
                        //}


                        if (position.Y <= point1.Y)
                        {
                            point1Tagged = true;
                            point2Tagged = false;
                        }
                    }


                    if (point1Tagged && !point2Tagged)
                    {
                        if (point2.Y > position.Y)
                        {
                            velocity.Y = speed;
                        }
                        if (point2.Y < position.Y)
                        {
                            velocity.Y = -speed;
                        }


                        //if (point2.X > position.X)
                        //{
                        //    velocity.X = speed;
                        //}
                        //if (point2.X < position.X)
                        //{
                        //    velocity.X = -speed;
                        //}
                        //if (position.X == point2.X)
                        //{
                            velocity.X = 0;
                        //}


                        if (position.Y >= point2.Y - position.Height)
                        {
                            point1Tagged = false;
                            point2Tagged = true;
                        }
                    }

                    #endregion
                    break;
                case patrolType.leftRight:
                    #region points
                    point1 = new Vector2(patrolRect.X, patrolRect.Y + (patrolRect.Height / 2));
                    point2 = new Vector2(patrolRect.X + patrolRect.Width, patrolRect.Y + (patrolRect.Height / 2));
                    #endregion
                    #region left/right
                    if (!point1Tagged)
                    {
                        //if (position.Y == point1.Y)
                        //{
                            velocity.Y = 0;
                        //}
                        //if (point1.Y > position.Y)
                        //{
                        //    velocity.Y = speed;
                        //}
                        //if (point1.Y < position.Y)
                        //{
                        //    velocity.Y = -speed;
                        //}
                        if (point1.X > position.X)
                        {
                            velocity.X = speed;
                        }
                        if (point1.X < position.X)
                        {
                            velocity.X = -speed;
                        }
                    }
                    if (position.X <= point1.X)
                    {
                        point1Tagged = true;
                        point2Tagged = false;
                    }

                    if (point1Tagged && !point2Tagged)
                    {
                        //if (position.Y == point2.Y)
                        //{
                            velocity.Y = 0;
                        //}
                        //if (point2.Y > position.Y)
                        //{
                        //    velocity.Y = speed;
                        //}
                        //if (point2.Y < position.Y)
                        //{
                        //    velocity.Y = -speed;
                        //}
                        if (point2.X > position.X)
                        {
                            velocity.X = speed;
                        }
                        if (point2.X < position.X)
                        {
                            velocity.X = -speed;
                        }
                    }
                    if (position.X >= point2.X - position.Width)
                    {
                        point1Tagged = false;
                        point2Tagged = true;
                    }
                    #endregion
                    break;
                case patrolType.box:
                    #region points
                    point1 = new Vector2(patrolRect.X, patrolRect.Y);
                    point2 = new Vector2(patrolRect.X + patrolRect.Width, patrolRect.Y);
                    point3 = new Vector2(patrolRect.X + patrolRect.Width, patrolRect.Y + patrolRect.Height);
                    point4 = new Vector2(patrolRect.X, patrolRect.Y + patrolRect.Height);
                    #endregion
                    #region box
                    if (!point1Tagged)
                    {
                        if (point1.Y > position.Y)
                        {
                            velocity.Y = speed;
                        }
                        if (point1.Y < position.Y)
                        {
                            velocity.Y = -speed;
                        }
                        if (point1.X > position.X)
                        {
                            velocity.X = speed;
                        }
                        if (point1.X < position.X)
                        {
                            velocity.X = -speed;
                        }
                    }
                    if (position.Y == point1.Y)
                    {
                        point1Tagged = true;
                    }

                    if (point1Tagged && !point2Tagged)
                    {
                        if (point2.Y > position.Y)
                        {
                            velocity.Y = speed;
                            velocity.X = 0;
                        }
                        if (point2.Y < position.Y)
                        {
                            velocity.Y = -speed;
                            velocity.X = 0;
                        }
                        if (point2.X > position.X)
                        {
                            velocity.X = speed;
                            velocity.Y = 0;
                        }
                        if (point2.X < position.X)
                        {
                            velocity.X = -speed;
                            velocity.Y = 0;
                        }
                    }
                    if (position.X == point2.X - position.Width)
                    {
                        point2Tagged = true;
                    }

                    if (point2Tagged && !point3Tagged)
                    {
                        if (point3.X > position.X)
                        {
                            velocity.X = speed;
                            velocity.Y = 0;
                        }
                        if (point3.X < position.X)
                        {
                            velocity.X = -speed;
                            velocity.Y = 0;
                        }
                        if (point3.Y > position.Y)
                        {
                            velocity.Y = speed;
                            velocity.X = 0;
                        }
                        if (point3.Y < position.Y)
                        {
                            velocity.Y = -2;
                            velocity.X = 0;
                        }
                    }
                    if (position.Y == point3.Y - position.Height)
                    {
                        point3Tagged = true;
                    }

                    if (point3Tagged && !point4Tagged)
                    {
                        if (point4.Y > position.Y)
                        {
                            velocity.Y = 2;
                            velocity.X = 0;
                        }
                        if (point4.Y < position.Y)
                        {
                            velocity.Y = -2;
                            velocity.X = 0;
                        }
                        if (point4.X > position.X)
                        {
                            velocity.X = 2;
                            velocity.Y = 0;
                        }
                        if (point4.X < position.X)
                        {
                            velocity.X = -2;
                            velocity.Y = 0;
                        }
                    }
                    if (position.X == point1.X && point3Tagged)
                    {
                        point1Tagged = false;
                        point2Tagged = false;
                        point3Tagged = false;
                        point4Tagged = false;
                        velocity.X = 0;
                        velocity.Y = -2;
                    }
                    #endregion
                    break;
                case patrolType.none:
                    #region points
                //    point1 = new Vector2(patrolRect.X, patrolRect.Y);
                //    Rectangle area = new Rectangle((int)point1.X - 32, (int)point1.Y - 32, 64, 64);
                //    #endregion
                //    #region one spot
                //    if (!position.Intersects(area))
                //    {
                //        if (position.Y > point1.Y)
                //        {
                //            velocity.Y = -speed;
                //        }
                //        else if (position.Y < point1.Y)
                //        {
                //            velocity.Y = speed;
                //        }
                //        if (position.X < point1.X)
                //        {
                //            velocity.X = speed;
                //        }
                //        else if (position.X > point1.X)
                //        {
                //            velocity.X = -speed;
                //        }
                //    }
                //    else
                //    {
                //        velocity.X = 0;
                //        velocity.Y = 0;
                //    }

                    #endregion
                  break;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (isOnMap)
            {
                if (health > 0)
                {
                    spriteBatch.Draw(texture, position, color);
                    spriteBatch.Draw(texture, patrolRect, new Color(20, 20, 20, 100));
                    
                    
                }
                if (healthTexture != null)
                {
                    spriteBatch.Draw(healthTexture, healthPos, Color.White);
                }
            }
        }

        public void DrawA(SpriteBatch spriteBatch)
        {
            if (isOnMap)
            {
                if (health > 0)
                {
                    if (canInteract)
                    {
                        spriteBatch.Draw(aTexture, aPosition, aColor);
                    }
                }
            }
        }
    }
}