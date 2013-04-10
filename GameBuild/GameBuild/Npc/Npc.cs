using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using GameBuild.Pathfinding;

namespace GameBuild
{
    public class Npc
    {
        #region shit load of variables
        public Rectangle position;
        public Rectangle healthPos;
        Rectangle patrolRect;
        Rectangle aPosition;
        Rectangle corner1;
        Rectangle corner2;
        Rectangle colRect;
        Vector2 point1;
        Vector2 point2;
        Vector2 point3;
        Vector2 point4;
        Vector2[] path;

        Texture2D debugTile;
        Texture2D walkSprite;
        Texture2D aTexture;
        public Texture2D healthTexture;

        string name;
        string mapName;

        float healthBarWidth;
        float maxHealth;
        public float health;
        public float healthPct;
        public float speed;
        float attackTimer = 1000f;
        float pathTimer = 1000f;
        const float ATTACKTIMER = 1000f;//milliseconds
        const float PATHTIMER = 1000f;//milliseconds
        int pathIndex;
        bool followPath;

        public bool point1Tagged = false, point2Tagged = false, point3Tagged = false, point4Tagged = false;
        public bool canInteract;
        public bool isOnMap;
        public bool hasBeenAdded = false;
        public bool isInteracting = false;
        public bool attackPlayer = false;
        bool addA = false;
        bool hasPath = false;

        public enum patrolType
        {
            upDown,
            leftRight,
            box,
            none
        }

        patrolType currentPatrolType = new patrolType();

        public cDialogue dialogue;
        List<DamageEffect> damageEffectList = new List<DamageEffect>();

        AnimationComponent animation;
        const int WALK_UP = 0;
        const int WALK_RIGHT = 1;
        const int WALK_DOWN = 2;
        const int WALK_LEFT = 3;
        bool walking = false;

        Color color = new Color(255, 255, 255, 255);
        Color aColor;

        int damage;
        #endregion

        public Npc(string mapName, string name, int x, int y, int width, int height, bool up, bool down, bool left, bool right, string spritePath, string portraitPath, bool patrolNone, bool patrolUpDown, bool patrolLeftRight, bool patrolBox, int patrolX, int patrolY, int patrolWidth, int patrolHeight, float speed, Game1 game, string dialoguePath)
        {
            position = new Rectangle(x, y, width, height);
            this.name = name;
            this.mapName = mapName;
            this.speed = speed;

            patrolRect = new Rectangle(patrolX, patrolY, patrolWidth, patrolHeight);

            aTexture = game.Content.Load<Texture2D>(@"Npc\A");
            aPosition = new Rectangle(0, 0, aTexture.Width, aTexture.Height);

            health = 200;
            maxHealth = health;
            this.speed = speed;

            dialogue = new cDialogue(game.Content.Load<Texture2D>(@"npc\portrait\" + portraitPath), game.Content.Load<Texture2D>(@"Game\textBox"), game, game.spriteFont, dialoguePath, name);
            walkSprite = game.Content.Load<Texture2D>(@"npc\sprite\" + spritePath);
            debugTile = game.Content.Load<Texture2D>(@"Player\emptySlot");
            healthTexture = game.Content.Load<Texture2D>(@"Game\health100");

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

            currentPatrolType = patrolType.box;

            aColor = Color.White;

            animation = new AnimationComponent(2, 4, 50, 71, 175, Microsoft.Xna.Framework.Point.Zero);
        }

        public Npc(Rectangle position, Texture2D walkSprite)
        {
            this.position = position;
            this.walkSprite = walkSprite;
        }

        public void CheckMap(Game1 game)
        {
            if (mapName == (Game1.map.mapName.Remove(Game1.map.mapName.Length - 1)))
            {
                isOnMap = true;
            }
            else
                isOnMap = false;
        }

        public void Attack(Game1 game, GameTime gameTime, H_Map.TileMap tiles)
        {
            Rectangle location = position;
            float elapsed = (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            walking = false;
            
            if (!IsCollision(tiles, corner1) && !IsCollision(tiles, corner2))
            {
                position.X = location.X;
                colRect = position;
            }

            attackTimer -= elapsed;
            pathTimer -= elapsed;

            if ((pathTimer <= 0 && !Game1.character.dead) || (!hasPath && !Game1.character.dead))
            {
                int[,] map = new int[Game1.map.mapWidth, Game1.map.mapHeight];
                for (int x = 0; x < Game1.map.mapWidth; x++)
                {
                    for (int y = 0; y < Game1.map.mapHeight; y++)
                    {
                        if (Game1.map.interactiveLayer[x,y].isPassable == true)
                        {
                            map[x, y] = 0;
                        }
                        else
                        {
                            map[x, y] = 1;
                        }
                    }
                }
                Pathfinding.Point start = new Pathfinding.Point(position.X / Game1.map.tileWidth, position.Y / Game1.map.tileHeight);
                Pathfinding.Point end = new Pathfinding.Point(Game1.character.position.X / Game1.map.tileWidth, Game1.character.position.Y / Game1.map.tileHeight);

                path = PathFinder.GetVectorPath(PathFinder.FindPath(map, start, end), Game1.map.tileWidth, Game1.map.tileHeight);
                hasPath = true;
                followPath = true;
                pathTimer = PATHTIMER;
            }

            if (Game1.character.position.Intersects(position) && Game1.map.mapName.Remove(Game1.map.mapName.Length - 1) == mapName && !Game1.character.dead)
            {
                if (attackTimer <= 0)
                {
                    damage = game.damageObject.dealDamage(3, 20);
                    damageEffectList.Add(new DamageEffect(damage, game, new Vector2(Game1.character.position.X, Game1.character.position.Y), new Color(255, 0, 0, 255), "npc"));
                    Game1.character.health -= damage;
                    Game1.particleSystemManager.particleSystem[0].Add(Game1.character.position.X + (Game1.character.position.Width / 2), Game1.character.position.Y + 32, 4, 4, damage, -4, 4, 0, 2, 0.2f, 1, 1, false, false, true);
                    attackTimer = ATTACKTIMER;
                }
                followPath = false;
            }

            if ((path.Length == 1 && path[0].X == -32 && path[0].Y == -32))
            {
                followPath = false;
                hasPath = false;
            }
            else
            {
                followPath = true;
            }

            if (hasPath && pathIndex < path.Length && followPath)
            {
                Rectangle prevLocation = location;
                if (Math.Abs(location.X - path[pathIndex].X) < 10 && Math.Abs(location.Y - path[pathIndex].Y) < 10)
                {
                    pathIndex++;
                    if (pathIndex >= path.Length)
                    {
                        hasPath = false;
                        pathIndex = 0;
                        followPath = false;
                    }
                }
                if (followPath)
                {
                    if (path[pathIndex].X < location.X)
                    {
                        MoveLeft(ref location);
                    }
                    else if (path[pathIndex].X > location.X)
                    {
                        MoveRight(ref location);
                    }
                    if (path[pathIndex].Y < location.Y)
                    {
                        MoveUp(ref location);
                    }
                    else if (path[pathIndex].Y > location.Y)
                    {
                        MoveDown(ref location);
                    }
                }
            }
            Console.WriteLine(followPath);
            position = location;
        }


        //fucking swag
        #region Swaggy movement functions
        private void MoveUp(ref Rectangle location)
        {
            location.Y += (int)-(speed * 2);
            if (!animation.IsAnimationPlaying(WALK_UP))
            {
                animation.LoopAnimation(WALK_UP);
            }
            walking = true;
        }

        private void MoveDown(ref Rectangle location)
        {
            location.Y += (int)(speed * 2);
            if (!animation.IsAnimationPlaying(WALK_DOWN))
            {
                animation.LoopAnimation(WALK_DOWN);
            }
            walking = true;
        }

        private void MoveLeft(ref Rectangle location)
        {
            location.X += (int)-(speed * 2);
            location.Y = position.Y;
            if (!animation.IsAnimationPlaying(WALK_LEFT))
            {
                animation.LoopAnimation(WALK_LEFT);
            }
            walking = true;
        }

        private void MoveRight(ref Rectangle location)
        {
            location.Y = position.Y;
            location.X += (int)(speed * 2);
            if (!animation.IsAnimationPlaying(WALK_RIGHT))
            {
                animation.LoopAnimation(WALK_RIGHT);
            }
            walking = true;
        } 
        #endregion

        public bool IsCollision(H_Map.TileMap tiles, Rectangle location)
        {
            Microsoft.Xna.Framework.Point tileIndex = tiles.GetTileIndexFromVector(new Vector2(location.X, location.Y));
            return (!tiles.interactiveLayer[tileIndex.X, tileIndex.Y].isPassable);
        }

        public void UpdateDialogue(Game1 game)
        {
            if (game.currentGameState == Game1.GameState.INTERACT)
            {
                dialogue.Update();
                if (!dialogue.isTalking && isInteracting == true)
                {
                    game.currentGameState = Game1.GameState.PLAY;
                    isInteracting = false;
                }
            }
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
            healthPos.Width = (int)healthBarWidth;
            healthPos.Height = 10;
            healthPct = (health / maxHealth);
            healthBarWidth = (float)healthTexture.Width * healthPct;
            CheckMap(game);
            #endregion

            for (int i = 0; i < damageEffectList.Count; i++)
            {
                damageEffectList[i].Effect();
            }

            if (attackPlayer)
            {
                canInteract = false;
                Attack(game, gameTime, tiles);
            }

            animation.UpdateAnimation(gameTime);

            if (!walking)
            {
                animation.PauseAnimation();
            }

            if (!attackPlayer)
            {
                Patrol(tiles);
            }

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
                    #region logic
                    walking = false;
                    point1 = new Vector2(patrolRect.X + (patrolRect.Width / 2), patrolRect.Y);
                    point2 = new Vector2(patrolRect.X + (patrolRect.Width / 2), patrolRect.Y + patrolRect.Height);
                    if (point1.Y < position.Y && !point1Tagged)
                    {
                        location.Y += (int)-speed;
                        corner1 = tiles.GetTileRectangleFromPosition(location.X, location.Y + (position.Height / 2));
                        corner2 = tiles.GetTileRectangleFromPosition(location.X + position.Width, location.Y + (position.Height / 2));
                        if (!IsCollision(tiles, corner1) && !IsCollision(tiles, corner2))
                        {
                            position.Y = location.Y;
                            colRect = position;
                        }
                        if (!animation.IsAnimationPlaying(WALK_UP))
                        {
                            animation.LoopAnimation(WALK_UP);
                        }
                        walking = true;
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
                        corner2 = tiles.GetTileRectangleFromPosition(location.X + position.Width, location.Y + (position.Height / 2));
                        if (!IsCollision(tiles, corner1) && !IsCollision(tiles, corner2))
                        {
                            position.Y = location.Y;
                            colRect = position;
                        }
                        if (!animation.IsAnimationPlaying(WALK_DOWN))
                        {
                            animation.LoopAnimation(WALK_DOWN);
                        }
                        walking = true;
                        if ((position.Y + position.Height) == point2.Y)
                        {
                            point2Tagged = true;
                            point1Tagged = false;
                        }
                    }
                    #endregion
                    break;
                case patrolType.leftRight:
                    #region logic
                    point1 = new Vector2(patrolRect.X, patrolRect.Y + (patrolRect.Height / 2));
                    point2 = new Vector2(patrolRect.X + patrolRect.Width, patrolRect.Y + (patrolRect.Height / 2));
                    if (point1.X < position.X && !point1Tagged)
                    {
                        walking = false;
                        location.X += (int)-speed;
                        location.Y = position.Y;
                        corner1 = tiles.GetTileRectangleFromPosition(location.X, location.Y + (position.Height / 2));
                        corner2 = tiles.GetTileRectangleFromPosition(location.X, location.Y + position.Height);
                        if (!IsCollision(tiles, corner1) && !IsCollision(tiles, corner2))
                        {
                            position.X = location.X;
                            colRect = position;
                        }
                        if (!animation.IsAnimationPlaying(WALK_LEFT))
                        {
                            animation.LoopAnimation(WALK_LEFT);
                        }
                        walking = true;
                        if (position.X == point1.X)
                        {
                            point2Tagged = false;
                            point1Tagged = true;
                        }
                    }

                    if (point2.X > position.X && !point2Tagged)
                    {
                        walking = false;
                        location.X += (int)speed;
                        location.Y = position.Y;
                        corner1 = tiles.GetTileRectangleFromPosition(location.X, location.Y + (position.Height / 2));
                        corner2 = tiles.GetTileRectangleFromPosition(location.X, location.Y + position.Height);
                        if (!IsCollision(tiles, corner1) && !IsCollision(tiles, corner2))
                        {
                            position.X = location.X;
                            colRect = position;
                        }
                        if (!animation.IsAnimationPlaying(WALK_RIGHT))
                        {
                            animation.LoopAnimation(WALK_RIGHT);
                        }
                        walking = true;
                        if ((position.X + position.Width) == point2.X)
                        {
                            point2Tagged = true;
                            point1Tagged = false;
                        }
                    }
                    #endregion
                    break;
                case patrolType.box:
                    #region logic
                    point1 = new Vector2(patrolRect.X, patrolRect.Y);
                    point2 = new Vector2(patrolRect.X + patrolRect.Width, patrolRect.Y);
                    point3 = new Vector2(patrolRect.X + patrolRect.Width, patrolRect.Y + patrolRect.Height);
                    point4 = new Vector2(patrolRect.X, patrolRect.Y + patrolRect.Height);
                    walking = false;
                    if (!point1Tagged)
                    {
                        if (point1.X < position.X)
                        {
                            location.X += (int)-speed;
                            location.Y = position.Y;
                            corner1 = tiles.GetTileRectangleFromPosition(location.X, location.Y + (position.Height / 2));
                            corner2 = tiles.GetTileRectangleFromPosition(location.X, location.Y + position.Height);
                        }
                        if (!IsCollision(tiles, corner1) && !IsCollision(tiles, corner2))
                        {
                            position.X = location.X;
                            colRect = position;
                        }
                        if (!animation.IsAnimationPlaying(WALK_RIGHT))
                        {
                            animation.LoopAnimation(WALK_RIGHT);
                        }
                        walking = true;
                        if (point1.X == position.X)
                        {
                            point1Tagged = true;
                        }
                    }

                    if (point1Tagged && !point2Tagged)
                    {
                        location.X += (int)speed;
                        location.Y = position.Y;
                        corner1 = tiles.GetTileRectangleFromPosition(location.X, location.Y + (position.Height / 2));
                        corner2 = tiles.GetTileRectangleFromPosition(location.X, location.Y + position.Height);
                        if (!IsCollision(tiles, corner1) && !IsCollision(tiles, corner2))
                        {
                            position.X = location.X;
                            colRect = position;
                        }
                        if (animation.IsAnimationPlaying(WALK_RIGHT))
                        {
                            animation.LoopAnimation(WALK_RIGHT);
                        }
                        walking = true;
                        if (position.X + position.Width == point2.X)
                        {
                            point2Tagged = true;
                        }
                    }

                    if (point2Tagged && !point3Tagged)
                    {
                        location.Y += (int)speed;
                        corner1 = tiles.GetTileRectangleFromPosition(location.X, location.Y + position.Height);
                        corner2 = tiles.GetTileRectangleFromPosition(location.X + position.Width, location.Y + position.Height);
                        if (!IsCollision(tiles, corner1) && !IsCollision(tiles, corner2))
                        {
                            position.Y = location.Y;
                            colRect = position;
                        }
                        if (!animation.IsAnimationPlaying(WALK_DOWN))
                        {
                            animation.LoopAnimation(WALK_DOWN);
                        }
                        walking = true;
                        if (position.Y + position.Height == point3.Y)
                        {
                            point3Tagged = true;
                        }
                    }

                    if (point3Tagged && !point4Tagged)
                    {
                        location.X += (int)-speed;
                        location.Y = position.Y;
                        corner1 = tiles.GetTileRectangleFromPosition(location.X, location.Y + (position.Height / 2));
                        corner2 = tiles.GetTileRectangleFromPosition(location.X, location.Y + position.Height);
                        if (!IsCollision(tiles, corner1) && !IsCollision(tiles, corner2))
                        {
                            position.X = location.X;
                            colRect = position;
                        }
                        if (!animation.IsAnimationPlaying(WALK_LEFT))
                        {
                            animation.LoopAnimation(WALK_LEFT);
                        }
                        walking = true;

                        if (position.X == point1.X && point3Tagged)
                        {
                            point4Tagged = true;
                        }
                    }

                    if (point4Tagged)
                    {
                        location.Y += (int)-speed;
                        location.X = position.X;
                        corner1 = tiles.GetTileRectangleFromPosition(location.X, location.Y + position.Height);
                        corner2 = tiles.GetTileRectangleFromPosition(location.X + position.Width, location.Y + position.Height);
                        if (!IsCollision(tiles, corner1) && !IsCollision(tiles, corner2))
                        {
                            position.Y = location.Y;
                            colRect = position;
                        }
                        if (!animation.IsAnimationPlaying(WALK_UP))
                        {
                            animation.LoopAnimation(WALK_UP);
                        }
                        walking = true;
                        if (position.Y == point1.Y)
                        {
                            point1Tagged = false;
                            point2Tagged = false;
                            point3Tagged = false;
                            point4Tagged = false;
                        }
                    }
                    #endregion

                    break;
                case patrolType.none:
                    break;
            }
            if (!walking)
            {
                animation.PauseAnimation();
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (isOnMap)
            {
                if (health > 0)
                {
                    spriteBatch.Draw(walkSprite, position, animation.GetFrame(), Color.White);
                    if (path != null)
                    {
                        for (int i = 0; i < path.Length; i++)
                        {
                            //spriteBatch.Draw(debugTile, path[i], Color.Pink);
                        }
                    }
                    
                    //spriteBatch.Draw(walkSprite, patrolRect, new Color(20, 20, 20, 100));
                }
                if (healthTexture != null && health > 0)
                {
                    spriteBatch.Draw(healthTexture, healthPos, Color.White);
                }
                if (path != null)
                {
                    for (int i = 0; i < path.Length; i++)
                    {
                        //spriteBatch.Draw(debugTile, path[i], new Color(200, 200, 200, 200));
                    }
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

        public void DrawDamage(SpriteBatch spriteBatch, Game1 game)
        {
            for (int i = 0; i < damageEffectList.Count; i++)
            {
                if (health > 0)
                {
                    damageEffectList[i].Draw(spriteBatch, game);
                }
            }
        }
    }
}
