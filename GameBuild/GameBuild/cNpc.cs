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
        Color color = new Color(255, 50, 50, 100);
        public int health;
        public bool up = false, right = false, down = true, left = true;
        public Vector2 dialogueTextPos;
        Vector2 point1;
        Vector2 point2;
        Vector2 point3;
        Vector2 point4;
        public Rectangle position;
        Rectangle corner1;
        Rectangle corner2;
        public Texture2D texture;
        Rectangle colRect;
        public cDialogue dialogue;

        Texture2D aTexture;
        Rectangle aPosition;
        Color aColor;

        public string name;
        public string mapName;
        bool addA = false;
        Random rand = new Random();
        public Vector2 textPos;
        public Vector2 velocity;
        Rectangle patrolRect;
        public bool point1Tagged = false, point2Tagged = false, point3Tagged = false, point4Tagged = false;
        public bool canInteract;
        public float speed;
        public bool oneNpcInRectangle;

        public bool isInteracting = false;

        public enum patrolType
        {
            upDown,
            leftRight,
            box,
            none
        }
        public patrolType currentPatrolType = new patrolType();


        H_Map.TileMap tile;

        public cNpc(string mapName, string name, int x, int y, int width, int height, bool up, bool down, bool left, bool right, string spritePath, string portraitPath, bool patrolNone, bool patrolUpDown, bool patrolLeftRight, bool patrolBox, int patrolX, int patrolY, int patrolWidth, int patrolHeight, float speed, Game1 game)
        {
            dialogue = new cDialogue(game.Content.Load<Texture2D>(@"npc\portrait\" + name), game.Content.Load<Texture2D>("blackness"), game, game.spriteFont);
            texture = game.Content.Load<Texture2D>("blackness");
            this.mapName = mapName;
            this.name = name;
            patrolRect = new Rectangle(patrolX, patrolY, patrolWidth, patrolHeight);
            point1 = new Vector2(patrolX, patrolY);
            point2 = new Vector2(patrolX + patrolWidth, patrolY);
            point3 = new Vector2(patrolX, patrolY + patrolHeight);
            point4 = new Vector2(patrolX + patrolWidth, patrolY + patrolHeight);
            dialogueTextPos = new Vector2(game.textBox.X, game.textBox.Y + 15);
            position = new Rectangle(x, y, width, height);
            velocity = new Vector2(0, 0);
            health = 50;
            aTexture = game.Content.Load<Texture2D>("A");
            aPosition = new Rectangle(0, 0, aTexture.Width, aTexture.Height);
            aColor = Color.White;
            texture = game.Content.Load<Texture2D>("blackness");
            patrolRect.X = position.X - ((patrolRect.Width / 2) - (position.Width / 2));
            patrolRect.Y = position.Y - ((patrolRect.Height / 2) - (position.Height / 2));
            colRect = position;
            textPos = new Vector2();
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

            this.speed = speed;
        }
        public void Update(cCharacter player, H_Map.TileMap tiles, Game1 game)
        {
            #region things to update every frame
            aPosition.X = position.X - (position.Width / 2);
            aPosition.Y = position.Y - (position.Height / 2);
            CheckCollision(tiles);
            corner1 = new Rectangle(colRect.X, colRect.Y, colRect.Width, colRect.Height);
            corner2 = new Rectangle(colRect.X, colRect.Y, colRect.Width, colRect.Height);
            position.X += (int)velocity.X;
            position.Y += (int)velocity.Y;
            textPos.X = position.X + 10;
            textPos.Y = position.Y - 30;
            #endregion

            #region sprites and directional stuff
            #endregion

            #region collision
            if (!IsCollision(tiles, corner1) && !IsCollision(tiles, corner2))
            {
                colRect = position;
            }
            else if (IsCollision(tiles, corner1) || IsCollision(tiles, corner2))
            {
                velocity.X = 0;
                velocity.Y = 0;
            }
            #endregion

            if (currentPatrolType != patrolType.none)
            {
                Patrol();
            }
            

            if (position.Intersects(player.interactRect))
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

        public void Dialogue()
        {
            
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
                        up = true;
                        down = false;
                        right = false;
                        left = false;
                        if (point1.Y < position.Y)
                        {
                            velocity.Y = -speed;
                        }
                        if (point1.Y > position.Y)
                        {
                            velocity.Y = speed;
                        }


                        if (point1.X > position.X)
                        {
                            velocity.X = speed;
                        }
                        if (point1.X < position.X)
                        {
                            velocity.X = -speed;
                        }
                        if (position.X == point1.X)
                        {
                            velocity.X = 0;
                        }


                        if (position.Y <= point1.Y)
                        {
                            point1Tagged = true;
                            point2Tagged = false;
                        }
                        corner1 = tile.GetTileRectangleFromPosition(position.X, position.Y + 24);
                        corner2 = tile.GetTileRectangleFromPosition(position.X + 48, position.Y + 24);
                    }


                    if (point1Tagged && !point2Tagged)
                    {
                        down = true;
                        up = false;
                        right = false;
                        left = false;
                        if (point2.Y > position.Y)
                        {
                            velocity.Y = speed;
                        }
                        if (point2.Y < position.Y)
                        {
                            velocity.Y = -speed;
                        }


                        if (point2.X > position.X)
                        {
                            velocity.X = speed;
                        }
                        if (point2.X < position.X)
                        {
                            velocity.X = -speed;
                        }
                        if (position.X == point2.X)
                        {
                            velocity.X = 0;
                        }


                        if (position.Y >= point2.Y - position.Height)
                        {
                            point1Tagged = false;
                            point2Tagged = true;
                        }
                        corner1 = tile.GetTileRectangleFromPosition(position.X, position.Y + 48);
                        corner2 = tile.GetTileRectangleFromPosition(position.X + 48, position.Y + 48);
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
                        left = true;
                        down = false;
                        right = false;
                        up = false;
                        if (position.Y == point1.Y)
                        {
                            velocity.Y = 0;
                        }
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
                        corner1 = tile.GetTileRectangleFromPosition(position.X, position.Y + 24);
                        corner2 = tile.GetTileRectangleFromPosition(position.X, position.Y + 48);
                    }
                    if (position.X <= point1.X)
                    {
                        point1Tagged = true;
                        point2Tagged = false;
                    }

                    if (point1Tagged && !point2Tagged)
                    {
                        right = true;
                        down = false;
                        up = false;
                        left = false;
                        if (position.Y == point2.Y)
                        {
                            velocity.Y = 0;
                        }
                        if (point2.Y > position.Y)
                        {
                            velocity.Y = speed;
                        }
                        if (point2.Y < position.Y)
                        {
                            velocity.Y = -speed;
                        }
                        if (point2.X > position.X)
                        {
                            velocity.X = speed;
                        }
                        if (point2.X < position.X)
                        {
                            velocity.X = -speed;
                        }
                        corner1 = tile.GetTileRectangleFromPosition(position.X + 48, position.Y + 24);
                        corner2 = tile.GetTileRectangleFromPosition(position.X + 48, position.Y + 48);
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
                        up = true;
                        down = false;
                        right = false;
                        left = false;
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
                        corner1 = tile.GetTileRectangleFromPosition(position.X, position.Y + 24);
                        corner2 = tile.GetTileRectangleFromPosition(position.X + 48, position.Y + 24);
                    }
                    if (position.Y == point1.Y)
                    {
                        point1Tagged = true;
                    }

                    if (point1Tagged && !point2Tagged)
                    {
                        right = true;
                        down = false;
                        up = false;
                        left = false;
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
                        corner1 = tile.GetTileRectangleFromPosition(position.X + 48, position.Y + 24);
                        corner2 = tile.GetTileRectangleFromPosition(position.X + 48, position.Y + 48);
                    }
                    if (position.X == point2.X - position.Width)
                    {
                        point2Tagged = true;
                    }

                    if (point2Tagged && !point3Tagged)
                    {
                        down = true;
                        up = false;
                        right = false;
                        left = false;

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
                        corner1 = tile.GetTileRectangleFromPosition(position.X, position.Y + 48);
                        corner2 = tile.GetTileRectangleFromPosition(position.X + 48, position.Y + 48);
                    }
                    if (position.Y == point3.Y - position.Height)
                    {
                        point3Tagged = true;
                    }

                    if (point3Tagged && !point4Tagged)
                    {
                        left = true;
                        down = false;
                        right = false;
                        up = false;
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
                        corner1 = tile.GetTileRectangleFromPosition(position.X, position.Y + 24);
                        corner2 = tile.GetTileRectangleFromPosition(position.X, position.Y + 48);
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
                    point1 = new Vector2(patrolRect.X, patrolRect.Y);
                    Rectangle area = new Rectangle((int)point1.X - 32, (int)point1.Y - 32, 64, 64);
                    #endregion
                    #region one spot
                    if (!position.Intersects(area))
                    {
                        if (position.Y > point1.Y)
                        {
                            velocity.Y = -speed;
                            up = true;
                        }
                        else if (position.Y < point1.Y)
                        {
                            velocity.Y = speed;
                            down = true;
                        }
                        if (position.X < point1.X)
                        {
                            velocity.X = speed;
                            right = true;
                        }
                        else if (position.X > point1.X)
                        {
                            velocity.X = -speed;
                            left = true;
                        }
                    }
                    else
                    {
                        velocity.X = 0;
                        velocity.Y = 0;
                    }

                    #endregion
                    break;
            }
        }


        public bool IsCollision(H_Map.TileMap tiles, Rectangle location)
        {
            tile = tiles;
            Point tileIndex = tile.GetTileIndexFromVector(new Vector2(location.X, location.Y));
            return (tile.interactiveLayer[(int)tileIndex.X, (int)tileIndex.Y].isPassable == false) || (tile.interactiveLayer[(int)tileIndex.X, (int)tileIndex.Y].isDoor == true);
        }

        public void CheckCollision(H_Map.TileMap tiles)
        {
            tile = tiles;
            Rectangle colRect = position;
            Point tileIndex = tile.GetTileIndexFromVector(new Vector2(colRect.X, colRect.Y));
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (health > 0)
            {
                spriteBatch.Draw(texture, position, color);
                spriteBatch.Draw(texture, patrolRect, new Color(20, 20, 20, 100));
                if (canInteract)
                {
                    spriteBatch.Draw(aTexture, aPosition, aColor);
                }
            }
        }
    }
}