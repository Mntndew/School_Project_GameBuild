using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using GameBuild.Pathfinding;

namespace GameBuild.Npc
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
        public Rectangle combatRectangle;
        Vector2 point1;
        Vector2 point2;
        Vector2 point3;
        Vector2 point4;
        Vector2[] path;
        Vector2 randomWalkTarget;
        public Rectangle bumpRectangle;//for mini bots :) they bump into eachother

        Texture2D debugTile;
        public Texture2D walkSprite;
        Texture2D aTexture;
        public Texture2D healthTexture;

        public string name;
        public string mapName;

        float healthBarWidth;
        float maxHealth;
        public float health;
        public float healthPct;
        public float speed;
        public float SPEED;
        public float attackTimer = 500f;
        float pathTimer = 200f;
        const float ATTACKTIMER = 2000f;//milliseconds
        const float PATHTIMER = 1000f;//milliseconds
        float MOBPATHTIMER = PATHTIMER;
        float pathTimerMod;
        int pathIndex;
        bool followPath;
        public double robotAngle;

        public bool point1Tagged = false, point2Tagged = false, point3Tagged = false, point4Tagged = false;
        public bool canInteract;
        public bool countedInteractRect;//so that you cant interact with two npcs at once
        public bool hasBeenAdded = false;
        public bool isInteracting = false;
        public bool attackPlayer = false;
        public bool mob;
        public bool bossMob;
        public bool up, down, left, right;
        bool addA = false;
        bool hasPath = false;
        bool hasTarget;
        public bool reached = true;//for waypoint
        public bool vulnerable;

        public enum patrolType
        {
            upDown,
            leftRight,
            box,
            none
        }

        public Key key;

        patrolType currentPatrolType = new patrolType();

        public cDialogue dialogue;
        List<DamageEffect> damageEffectList = new List<DamageEffect>();
        AnimationComponent animation;

        Random rand = new Random();

        const int WALK_UP = 0;
        const int WALK_RIGHT = 1;
        const int WALK_DOWN = 2;
        const int WALK_LEFT = 3;
        bool walking = false;

        Color color = new Color(255, 255, 255, 255);
        Color aColor;

        int damage;
        int minDamage;//for mobs
        int maxDamage;
        int hitChance;
        int chance;
        #endregion

        public Npc(string mapName, string name, int x, int y, int width, int height, bool up, bool down, bool left, bool right,
            string spritePath, string portraitPath, bool patrolNone, bool patrolUpDown, bool patrolLeftRight,
            bool patrolBox, int patrolX, int patrolY, int patrolWidth, int patrolHeight, float speed, Game1 game, string dialoguePath, string keyName)
        {
            position = new Rectangle(x, y, width - 16, height - 16);
            this.name = name;
            this.mapName = mapName;
            this.speed = speed;
            this.up = up;
            this.down = down;
            this.left = left;
            this.right = right;
            minDamage = 2;
            maxDamage = 15;
            combatRectangle = new Rectangle(position.X - 128, position.Y - 128, 256, 256);
            patrolRect = new Rectangle(patrolX, patrolY, patrolWidth, patrolHeight);
            aTexture = game.Content.Load<Texture2D>(@"Npc\A");
            aPosition = new Rectangle(0, 0, aTexture.Width, aTexture.Height);
            health = 200;
            maxHealth = health;
            this.speed = speed;
            this.SPEED = speed;
            dialogue = new cDialogue(game.Content.Load<Texture2D>(@"npc\portrait\" + portraitPath), game.textBox, game, game.spriteFont, dialoguePath, name);
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

            if (!patrolBox && !patrolUpDown && !patrolLeftRight)
            {
                currentPatrolType = patrolType.none;
            }

            aColor = Color.White;
            animation = new AnimationComponent(2, 4, 50, 71, 175, Microsoft.Xna.Framework.Point.Zero);
            mob = false;

            dialogue.dialogueManager.ReachedExit += ExitedDialogue;
            if (keyName != "nokey")
            {
                key = new Key(Rectangle.Empty, keyName, game.keyTexture, this.mapName, game);
            }
        }

        public Npc(Rectangle position, Texture2D walkSprite, Game1 game, string mapName,
            float timerMod, bool attackPlayer, int health, int minDamage, int maxDamage, int hitChance, bool vulnerable)
        {
            this.mapName = mapName;
            this.position = position;
            this.walkSprite = walkSprite;
            this.attackPlayer = attackPlayer;
            this.health = health;
            this.minDamage = minDamage;
            this.maxDamage = maxDamage;
            this.hitChance = hitChance;
            this.vulnerable = vulnerable;
            combatRectangle = new Rectangle(position.X - 128, position.Y - 128, 256, 256);
            pathTimerMod = timerMod;
            healthTexture = game.Content.Load<Texture2D>(@"Game\health100");
            debugTile = game.Content.Load<Texture2D>(@"Player\emptySlot");
            speed = 1;
            maxHealth = health;
            MOBPATHTIMER = rand.Next(2000, 10000) * timerMod;
            mob = true;
            currentPatrolType = patrolType.none;
            animation = new AnimationComponent(2, 4, 50, 71, 175, Microsoft.Xna.Framework.Point.Zero);
            this.SPEED = speed;
            key = null;
        }

        public bool IsOnMap()
        {
            if (Game1.map.mapName.Remove(Game1.map.mapName.Length - 1) == mapName)
            {
                return true;
            }
            else
                return false;
        }

        public void GoTo(Vector2 targetPoint, bool isWaypoint, GameTime gameTime)//manages findpath and followpath
        {
            float elapsed = (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            pathTimer -= elapsed;
            if (pathTimer <= 0)
            {
                FindPath(targetPoint);
                if (mob)
                {
                    if (!attackPlayer)
                    {
                        MOBPATHTIMER = (PATHTIMER * 3) * pathTimerMod;
                        MOBPATHTIMER += rand.Next((int)-(PATHTIMER / 2), (int)PATHTIMER / 2);
                    }
                    else
                        MOBPATHTIMER = PATHTIMER;

                    pathTimer = MOBPATHTIMER;
                }
                else
                    pathTimer = PATHTIMER;
            }
            if (path != null)
            {
                FollowPath(gameTime, isWaypoint);
            }
        }

        private void FindPath(Vector2 targetPoint)
        {
            if ((!Game1.character.dead) || (!hasPath && !Game1.character.dead))
            {
                int[,] map = new int[Game1.map.mapWidth, Game1.map.mapHeight];
                for (int x = 0; x < Game1.map.mapWidth; x++)
                {
                    for (int y = 0; y < Game1.map.mapHeight; y++)
                    {
                        if (Game1.map.interactiveLayer[x, y].isPassable == true)
                        {
                            map[x, y] = 0;
                        }
                        else
                        {
                            map[x, y] = 1;
                        }
                    }
                }
                Pathfinding.Point start = new Pathfinding.Point((position.X + position.Width / 2) / Game1.map.tileWidth, (position.Y + position.Height / 2) / Game1.map.tileHeight);
                Pathfinding.Point end;
                if (!mob || attackPlayer)
                {
                    end = new Pathfinding.Point((int)targetPoint.X / Game1.map.tileWidth, (int)targetPoint.Y / Game1.map.tileHeight);
                }
                else
                    end = new Pathfinding.Point((int)targetPoint.X, (int)targetPoint.Y);

                path = PathFinder.GetVectorPath(PathFinder.FindPath(map, start, end), Game1.map.tileWidth, Game1.map.tileHeight);

                hasPath = true;
                followPath = true;
                pathIndex = path.Length - 1;
            }
        }

        private void FollowPath(GameTime gameTime, bool isWaypoint)
        {
            if ((path.Length == 1 && path[0].X == -32 && path[0].Y == -32) || position.Intersects(Game1.character.positionRectangle))
            {
                followPath = false;
                hasPath = false;
            }
            else
            {
                followPath = true;
            }
            if (isWaypoint)
            {
                if (Math.Abs(path[0].X - position.X) <= 32 && Math.Abs(path[0].Y - position.Y) <= 32)
                {
                    reached = true;
                }
            }
            if (hasPath && pathIndex < path.Length && followPath)
            {
                Rectangle prevLocation = position;
                if (Math.Abs((position.X + position.Width / 2) - path[pathIndex].X) < 10 && Math.Abs((position.Y + position.Height / 2) - path[pathIndex].Y) < 10)
                {
                    pathIndex--;
                    if (pathIndex < 0)
                    {
                        hasPath = false;
                        pathIndex = 0;
                        followPath = false;
                    }
                }
                if (followPath)
                {
                    if (path[pathIndex].X < position.X + position.Width / 2)
                    {
                        MoveLeft(ref position);
                    }
                    else if (path[pathIndex].X > position.X + position.Width / 2)
                    {
                        MoveRight(ref position);
                    }
                    if (path[pathIndex].Y < position.Y + position.Height / 2)
                    {
                        MoveUp(ref position);
                    }
                    else if (path[pathIndex].Y > position.Y + position.Height / 2)
                    {
                        MoveDown(ref position);
                    }
                }
            }
        }

        private void RandomMovement(GameTime gameTime)
        {
            GetTargetLocation();
            if (hasTarget)
            {
                GoTo(randomWalkTarget, false, gameTime);
            }
        }

        private void GetTargetLocation()
        {
            hasTarget = false;
            randomWalkTarget = new Vector2(rand.Next(0, 30), rand.Next(0, 30));

            if (randomWalkTarget.X > 0 && randomWalkTarget.X < Game1.map.mapWidth && randomWalkTarget.Y > 0 && randomWalkTarget.Y < Game1.map.mapHeight)
            {
                if (Game1.map.interactiveLayer[(int)randomWalkTarget.X, (int)randomWalkTarget.Y].isPassable)
                {
                    hasTarget = true;
                }
                else
                    GetTargetLocation();
            }
            else
                GetTargetLocation();
        }

        public void Attack(Game1 game, GameTime gameTime)
        {
            Rectangle location = position;
            float elapsed = (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            walking = false;
            if (bossMob)
            {
                if (Game1.character.positionRectangle.X > position.X)
                {
                    position.X += (int)speed * 2;
                }
                if (Game1.character.positionRectangle.X < position.X)
                {
                    position.X += (int)-speed * 2;
                }
                if (Game1.character.positionRectangle.Y > position.Y)
                {
                    position.Y += (int)speed * 2;
                }
                if (Game1.character.positionRectangle.Y < position.Y)
                {
                    position.Y += (int)-speed * 2;
                }
            }
            if (Game1.character.positionRectangle.Intersects(position) && IsOnMap() && !Game1.character.dead && !bossMob)
            {
                if (attackTimer <= 0)
                {
                    {
                        damage = game.damageObject.dealDamage(minDamage, maxDamage);
                        damageEffectList.Add(new DamageEffect(damage, game, new Vector2(Game1.character.positionRectangle.X, Game1.character.positionRectangle.Y), new Color(255, 0, 0, 255), "npc"));
                        Game1.character.health -= damage;
                        Game1.character.Hit();
                        Vector2 pos = new Vector2(location.X, location.Y);
                    Vector2 direction = Game1.character.position - pos;
                    direction.Normalize();
                    Game1.character.Push(direction, 12);
                    attackTimer = ATTACKTIMER;
                    Game1.character.Disable();  
                    }
                }
                followPath = false;
            }
            else
            {
                if (Game1.character.positionRectangle.Intersects(position) && !Game1.character.dead)
                {
                    if (attackTimer <= 0)
                    {
                        chance = rand.Next(1, 100);
                        if (chance <= hitChance)
                        {
                            damage = game.damageObject.dealDamage(minDamage, maxDamage);
                            damageEffectList.Add(new DamageEffect(damage, game, new Vector2(Game1.character.positionRectangle.X, Game1.character.positionRectangle.Y), new Color(255, 0, 0, 255), "npc"));
                            Game1.character.health -= damage;
                            Game1.character.Hit();
                            chance = 101;
                            attackTimer = ATTACKTIMER;
                        }
                    }
                }
            }

            attackTimer -= elapsed;

            if (IsOnMap() && !bossMob)
            {
                GoTo(new Vector2((Game1.character.positionRectangle.X + (Game1.character.positionRectangle.Width / 2)), (Game1.character.positionRectangle.Y + (Game1.character.positionRectangle.Height / 2))), false, gameTime);
            }
        }

        //fucking swag
        #region Swaggy movement functions
        private void MoveUp(ref Rectangle location)
        {
            location.Y += (int)-(speed * 2);
            combatRectangle.Y += (int)-(speed * 2);
            if (!animation.IsAnimationPlaying(WALK_UP))
            {
                animation.LoopAnimation(WALK_UP);
            }
            walking = true;
        }

        private void MoveDown(ref Rectangle location)
        {
            location.Y += (int)(speed * 2);
            combatRectangle.Y += (int)(speed * 2);
            if (!animation.IsAnimationPlaying(WALK_DOWN))
            {
                animation.LoopAnimation(WALK_DOWN);
            }
            walking = true;
        }

        private void MoveLeft(ref Rectangle location)
        {
            location.X += (int)-(speed * 2);
            combatRectangle.X += (int)-(speed * 2);
            if (!animation.IsAnimationPlaying(WALK_LEFT))
            {
                animation.LoopAnimation(WALK_LEFT);
            }
            walking = true;
        }

        private void MoveRight(ref Rectangle location)
        {
            location.X += (int)(speed * 2);
            combatRectangle.X += (int)(speed * 2);
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
            #endregion

            bumpRectangle = new Rectangle(position.X + position.Width / 2, position.Y + position.Height / 2, position.Width / 2, position.Height / 2);

            if (name == "Headmaster")
            {
                if (mapName == "Map3_B")
                {
                    if (IsOnMap())
                    {
                        if (!reached)
                        {
                            up = false;
                            down = false;
                            right = false;
                            left = false;
                            GoTo(new Vector2(576, 1152), true, gameTime);
                        }
                        else
                        {
                            down = true;
                        }
                    }
                }
            }
            if (name == "Celine")
            {
                if (mapName == "Map3_B")
                {
                    if (IsOnMap())
                    {
                        if (!reached)
                        {
                            up = false;
                            down = false;
                            right = false;
                            left = false;
                            GoTo(new Vector2(620, 1248), true, gameTime);
                        }
                        else
                        {
                            up = true;
                        }
                    }
                }
            }

            if (mob && !bossMob)
            {
                if (!attackPlayer && IsOnMap())
                {
                    RandomMovement(gameTime);
                }
                else
                    pathTimer = 0;
            }

            for (int i = 0; i < damageEffectList.Count; i++)
            {
                damageEffectList[i].Effect();
            }

            if (attackPlayer)
            {
                canInteract = false;
                Attack(game, gameTime);
            }

            animation.UpdateAnimation(gameTime);

            if (!attackPlayer)
            {
                Patrol(tiles);
            }

            #region Player Interaction
            if (IsOnMap())
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

            if (health <= 0)
            {
                attackPlayer = false;
            }
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
                    walking = false;
                    if (up)
                    {
                        if (!animation.IsAnimationPlaying(WALK_UP))
                        {
                            animation.LoopAnimation(WALK_UP);
                        }
                        walking = true;
                    }
                    if (down)
                    {
                        if (!animation.IsAnimationPlaying(WALK_DOWN))
                        {
                            animation.LoopAnimation(WALK_DOWN);
                        }
                        walking = true;
                    }
                    if (left)
                    {
                        if (!animation.IsAnimationPlaying(WALK_LEFT))
                        {
                            animation.LoopAnimation(WALK_LEFT);
                        }
                        walking = true;
                    }
                    if (right)
                    {
                        if (!animation.IsAnimationPlaying(WALK_RIGHT))
                        {
                            animation.LoopAnimation(WALK_RIGHT);
                        }
                        walking = true;
                    }
                    break;
            }
            if (!walking)
            {
                animation.PauseAnimation();
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (IsOnMap())
            {
                if (health > 0)
                {
                    spriteBatch.Draw(walkSprite, position, animation.GetFrame(), Color.White);
                }
            }
        }

        public void DrawHealth(SpriteBatch spriteBatch)
        {
            if (IsOnMap())
            {
                if (healthTexture != null && health > 0)
                {
                    spriteBatch.Draw(healthTexture, healthPos, Color.White);
                }
            }
        }
        

        public void DrawA(SpriteBatch spriteBatch)
        {
            if (IsOnMap())
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

        private void ExitedDialogue(object sender, DialogueEventArgs e)
        {
            switch (e.exitNumber)
            {
                case 0:
                    isInteracting = false;
                    break;

                case 1:
                    attackPlayer = true;
                    break;

                case 2:
                    if (key != null)
                    {
                        key.position = Game1.character.positionRectangle;
                        Game1.keys.Add(key);
                        key = null;
                    }
                    break;

                case 3:
                    if (name == "Ziva" && Game1.testBoss.health > 0)
                    {
                        Game1.testBoss.attackPlayer = true;
                    }
                    health = 0;
                    break;
                case 4:
                    isInteracting = false;
                    dialogue.isTalking = false;
                    break;
                default:
                    break;
            }
        }
    }
}
