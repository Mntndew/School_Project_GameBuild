using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameBuild
{
    public class Npc
    {
        public Rectangle position;
        Rectangle healthPos;
        Rectangle patrolRect;
        Rectangle aPosition;
        Rectangle corner1;
        Rectangle corner2;
        Rectangle colRect;
        Vector2 velocity;
        Vector2 point1;
        Vector2 point2;
        Vector2 point3;
        Vector2 point4;

        Texture2D texture;
        Texture2D aTexture;
        public Texture2D healthTexture;

        string name;
        string mapName;

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

        public enum patrolType
        {
            upDown,
            leftRight,
            box,
            none
        }
        patrolType currentPatrolType = new patrolType();

        public cDialogue dialogue;

        Color color = new Color(255, 255, 255, 255);
        Color aColor;

        public Npc(string mapName, string name, int x, int y, int width, int height, bool up, bool down, bool left, bool right, string spritePath, string portraitPath, bool patrolNone, bool patrolUpDown, bool patrolLeftRight, bool patrolBox, int patrolX, int patrolY, int patrolWidth, int patrolHeight, float speed, Game1 game, string dialoguePath)
        {
            position = new Rectangle(x, y, width, height);

            this.name = name;
            this.mapName = mapName;
            this.speed = speed;

            patrolRect = new Rectangle(patrolX, patrolY, patrolWidth, patrolHeight);

            aTexture = game.Content.Load<Texture2D>("A");
            aPosition = new Rectangle(0, 0, aTexture.Width, aTexture.Height);

            health = 200;
            maxHealth = health;
            this.speed = 1;

            dialogue = new cDialogue(game.Content.Load<Texture2D>(@"npc\portrait\" + portraitPath), game.Content.Load<Texture2D>("textBox"), game, game.spriteFont, dialoguePath, name);
            texture = game.Content.Load<Texture2D>(@"npc\sprite\" + spritePath);

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

            currentPatrolType = patrolType.leftRight;

            aColor = Color.White;
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
            Rectangle location = position;
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
            healthPos.X = position.X + 8;
            healthPos.Y = position.Y - 15;
            healthPos.Width = 48;
            healthPos.Height = 10;
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
            CheckMap(game);
            #endregion

            if (attackPlayer)
            {
                canInteract = false;
                Attack(game, gameTime, tiles);
            }

            Patrol(tiles);

            if (game.currentGameState == Game1.GameState.PLAY && canInteract)
            {
                
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

        public void Patrol(H_Map.TileMap tiles)
        {
            Rectangle location = position;
            switch (currentPatrolType)
            {
                case patrolType.upDown:
                    point1 = new Vector2(patrolRect.X + (patrolRect.Width / 2), patrolRect.Y);
                    point2 = new Vector2(patrolRect.X + (patrolRect.Width / 2), patrolRect.Y + patrolRect.Height);

                    if (point1.Y < position.Y && !point1Tagged)
                    {
                        location.Y += (int)-speed;
                        corner1 = tiles.GetTileRectangleFromPosition(location.X, location.Y + (position.Height / 2));
                        corner2 = tiles.GetTileRectangleFromPosition(location.X + texture.Width, location.Y + (position.Height / 2));
                        if (!IsCollision(tiles, corner1) && !IsCollision(tiles, corner2))
                        {
                            position.Y = location.Y;
                            colRect = position;
                        }
                        if (position.Y == point1.Y)
                        {
                            point2Tagged = false;
                            point1Tagged = true;
                        }
                    }

                    if (point2.Y > position.Y && !point2Tagged)
                    {
                        location.Y += (int)speed;
                        corner1 = tiles.GetTileRectangleFromPosition(location.X, location.Y + (position.Height / 2));
                        corner2 = tiles.GetTileRectangleFromPosition(location.X + texture.Width, location.Y + (position.Height / 2));
                        if (!IsCollision(tiles, corner1) && !IsCollision(tiles, corner2))
                        {
                            position.Y = location.Y;
                            colRect = position;
                        }
                        if ((position.Y + position.Height) == point2.Y)
                        {
                            point2Tagged = true;
                            point1Tagged = false;
                        }
                    }
                    break;
                case patrolType.leftRight:
                    point1 = new Vector2(patrolRect.X, patrolRect.Y + (patrolRect.Height / 2));
                    point2 = new Vector2(patrolRect.X + patrolRect.Width, patrolRect.Y + (patrolRect.Height / 2));

                    if (point1.X < position.X && !point1Tagged)
                    {
                        location.X += (int)-speed;
                        location.Y = position.Y;
                        corner1 = tiles.GetTileRectangleFromPosition(location.X, location.Y + (position.Height / 2));
                        corner2 = tiles.GetTileRectangleFromPosition(location.X, location.Y + texture.Height);

                        if (!IsCollision(tiles, corner1) && !IsCollision(tiles, corner2))
                        {
                            position.X = location.X;
                            colRect = position;
                        }
                        if (position.X == point1.X)
                        {
                            point2Tagged = false;
                            point1Tagged = true;
                        }
                    }

                    if (point2.Y > position.Y && !point2Tagged)
                    {
                        location.X += (int)speed;
                        location.Y = position.Y;
                        corner1 = tiles.GetTileRectangleFromPosition(location.X, location.Y + (position.Height / 2));
                        corner2 = tiles.GetTileRectangleFromPosition(location.X, location.Y + texture.Height);
                        if (!IsCollision(tiles, corner1) && !IsCollision(tiles, corner2))
                        {
                            position.X = location.X;
                            colRect = position;
                        }
                        if ((position.X + position.Width) == point2.X)
                        {
                            point2Tagged = true;
                            point1Tagged = false;
                        }
                    }
                    break;
                case patrolType.box:
                    break;
                case patrolType.none:
                    point1Tagged = true;
                    point2Tagged = true;
                    point3Tagged = true;
                    point4Tagged = true;
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
