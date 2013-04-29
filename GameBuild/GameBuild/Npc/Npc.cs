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
        public Rectangle position = new Rectangle(-1000, -1000, 0, 0);
        public Rectangle healthPos;
        Rectangle patrolRect;
        Rectangle aPosition;
        Vector2[] path;
        Vector2 randomWalkTarget;
        public Rectangle bumpRectangle;//for mini bots :) they bump into eachother

        Texture2D debugTile;
        public Texture2D walkSprite;
        Texture2D deathSprite;
        Texture2D aTexture;
        public Texture2D healthTexture;

        public string name;
        public string mapName;
        string sword;

        float healthBarWidth;
        float maxHealth;
        public float health;
        public float healthPct;
        public float speed;
        public float attackTimer = 500f;
        float pathTimer = 200f;
        const float ATTACKTIMER = 2000f;//milliseconds
        const float PATHTIMER = 200f;//milliseconds
        float MOBPATHTIMER = PATHTIMER;
        float pathTimerMod;
        int pathIndex;
        bool followPath;
        public double robotAngle;
        float directionTimer = 1;
        const float DIRECTIONTIMER = 1;

        public bool point1Tagged = false, point2Tagged = false, point3Tagged = false, point4Tagged = false;
        public bool canInteract;
        public bool countedInteractRect;//so that you cant interact with two npcs at once
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
        bool walking;
        public bool remove;

        string secondDialogue;

        public enum patrolType
        {
            upDown,
            leftRight,
            box,
            none
        }

        public Key key;

        public cDialogue dialogue;
        List<DamageEffect> damageEffectList = new List<DamageEffect>();
        AnimationComponent animation;
        AnimationComponent deathAnimation;  

        Random rand = new Random();

        const int WALK_UP = 0;
        const int WALK_RIGHT = 1;
        const int WALK_DOWN = 2;
        const int WALK_LEFT = 3;
        const int IDLE_UP = 4;
        const int IDLE_RIGHT = 5;
        const int IDLE_DOWN = 6;
        const int IDLE_LEFT = 7;
        const int DEATH = 8;

        Color color = new Color(255, 255, 255, 255);
        Color aColor;

        int damage;
        int minDamage;//for mobs
        int maxDamage;
        int hitChance;
        int chance;
        int direction;
        #endregion

        public Npc(string mapName, string name, int x, int y, int width, int height, bool up, bool down, bool left, bool right,
            string spritePath, string portraitPath, bool patrolNone, bool patrolUpDown, bool patrolLeftRight,
            bool patrolBox, int patrolX, int patrolY, int patrolWidth, int patrolHeight, float speed, Game1 game, string dialoguePath, string keyName, string secondDialogue)
        {
            position = new Rectangle(x, y, 50, 71);
            this.name = name;
            this.mapName = mapName;
            this.up = up;
            this.down = down;
            this.left = left;
            this.right = right;
            vulnerable = true;
            minDamage = 2;
            maxDamage = 15;
            patrolRect = new Rectangle(patrolX, patrolY, patrolWidth, patrolHeight);
            aTexture = game.Content.Load<Texture2D>(@"Npc\A");
            aPosition = new Rectangle(0, 0, aTexture.Width, aTexture.Height);
            health = 200;
            maxHealth = health;
            this.speed = speed;
            dialogue = new cDialogue(game.Content.Load<Texture2D>(@"npc\portrait\" + portraitPath), Game1.textBox, game, Game1.spriteFont, dialoguePath, name);
            walkSprite = game.Content.Load<Texture2D>(@"npc\sprite\" + spritePath);
            debugTile = game.Content.Load<Texture2D>(@"Player\emptySlot");
            healthTexture = game.Content.Load<Texture2D>(@"Game\health100");
            aColor = Color.White;
            if (name == "Celine")
            {
                animation = new AnimationComponent(2, 8, 50, 72, 175, Microsoft.Xna.Framework.Point.Zero);
                position.Height = 72;
            }
            else if(name == "Headmaster")
            {
                animation = new AnimationComponent(2, 8, 50, 127, 175, Microsoft.Xna.Framework.Point.Zero);
                sword = "sword1";
                vulnerable = false;
                position.Y -= 60;
                position.Height = 127;
            }
            else if(name == "Lamia")
            {
                animation = new AnimationComponent(2, 4, 100, 76, 175, Microsoft.Xna.Framework.Point.Zero);
                position.Y -= 64;
                position.Height = 64;
                position.Width = 84;
            }
            else if (name == "Laune")
            {
                animation = new AnimationComponent(3, 11, 50, 75, 175, Microsoft.Xna.Framework.Point.Zero);
            }
            else
            {
                animation = new AnimationComponent(2, 4, 50, 71, 175, Microsoft.Xna.Framework.Point.Zero);
            }
            
            mob = false;

            dialogue.dialogueManager.ReachedExit += ExitedDialogue;
            if (keyName != "nokey")
            {
                key = new Key(Rectangle.Empty, keyName, game.keyTexture, this.mapName, game);
            }
            deathAnimation = new AnimationComponent(3, 1, 44, 38, 175, Microsoft.Xna.Framework.Point.Zero);
            deathSprite = game.Content.Load<Texture2D>(@"Npc\deathSprite");
            this.secondDialogue = secondDialogue;
        }

        public Npc(int x, int y, int width, int height, Texture2D walkSprite, Game1 game, string mapName,
            float timerMod, bool attackPlayer, int health, int minDamage, int maxDamage, int hitChance, bool vulnerable)
        {
            this.mapName = mapName;
            position.X = x;
            position.Y = y - 128;
            position.Width = 50;
            position.Height = 71;
            this.walkSprite = walkSprite;
            this.attackPlayer = attackPlayer;
            this.health = 1;
            this.minDamage = minDamage;
            this.maxDamage = maxDamage;
            this.hitChance = hitChance;
            this.vulnerable = vulnerable;
            this.speed = 1;
            pathTimerMod = timerMod;
            healthTexture = game.Content.Load<Texture2D>(@"Game\health100");
            debugTile = game.Content.Load<Texture2D>(@"Player\emptySlot");
            maxHealth = health;
            MOBPATHTIMER = rand.Next(2000, 10000) * timerMod;
            mob = true;
            animation = new AnimationComponent(2, 9, 50, 72, 175, Microsoft.Xna.Framework.Point.Zero);
            deathSprite = game.Content.Load<Texture2D>(@"Npc\deathSprite");
            key = null;
        }

        public bool IsOnMap()
        {
            if (Game1.map.mapName.Remove(Game1.map.mapName.Length - 1) == mapName || Game1.map.mapName == mapName)
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
            else
            {
                if (targetPoint == Game1.character.position)
                {
                    if (position.X > targetPoint.X)
                    {
                        position.X -= (int)speed * 2;
                    }
                    if (position.X < targetPoint.X)
                    {
                        position.X += (int)speed * 2;
                    }
                    if (position.Y > targetPoint.Y)
                    {
                        position.Y -= (int)speed * 2;
                    }
                    if (position.Y < targetPoint.Y)
                    {
                        position.Y += (int)speed * 2;
                    }
                }
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
                    walking = false;
                    if (mob)
                    {
                        directionTimer -= (float)gameTime.ElapsedGameTime.TotalSeconds * 0.75f;

                        if (directionTimer <= 0)
                        {
                            direction = rand.Next(1, 5);
                            directionTimer = DIRECTIONTIMER;
                        }
                        if (direction == 1)
                        {
                            if (path[pathIndex].Y < position.Y + position.Height / 2)
                            {
                                MoveUp(ref position);
                            }
                        }
                        if (direction == 2)
                        {
                            if (path[pathIndex].Y > position.Y + position.Height / 2)
                            {
                                MoveDown(ref position);
                            }
                        }
                        if (direction == 3)
                        {
                            if (path[pathIndex].X < position.X + position.Width / 2)
                            {
                                MoveLeft(ref position);
                            }
                        }
                        if (direction == 4)
                        {
                            if (path[pathIndex].X > position.X + position.Width / 2)
                            {
                                MoveRight(ref position);
                            }
                        }
                    }
                    else
                    {
                        if (path[pathIndex].Y < position.Y + position.Height / 2)
                        {
                            MoveUp(ref position);
                        }

                        else if (path[pathIndex].X < position.X + position.Width / 2)
                        {
                            MoveLeft(ref position);
                        }

                        if (path[pathIndex].Y > position.Y + position.Height / 2)
                        {
                            MoveDown(ref position);
                        }

                        else if (path[pathIndex].X > position.X + position.Width / 2)
                        {
                            MoveRight(ref position);
                        }
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
            if (bossMob)
            {
                walking = false;
                if (Game1.character.positionRectangle.X > position.X)
                {
                    MoveRight(ref position);
                }
                if (Game1.character.positionRectangle.X < position.X)
                {
                    MoveLeft(ref position);
                }
                if (Game1.character.positionRectangle.Y > position.Y)
                {
                    MoveDown(ref position);
                }
                if (Game1.character.positionRectangle.Y < position.Y)
                {
                    MoveUp(ref position);
                }
            }
            if (Game1.character.positionRectangle.Intersects(position) && IsOnMap() && !Game1.character.dead && !bossMob)
            {
                if (attackTimer <= 0)
                {
                    walking = false;
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
                    if (up)
                    {
                        if (!animation.IsAnimationPlaying(WALK_UP))
                        {
                            animation.LoopAnimation(WALK_UP);
                        }
                    }
                    else if (down)
                    {
                        if (!animation.IsAnimationPlaying(WALK_DOWN))
                        {
                            animation.LoopAnimation(WALK_DOWN);
                        }
                    }
                    if (left)
                    {
                        if (!animation.IsAnimationPlaying(WALK_LEFT))
                        {
                            animation.LoopAnimation(WALK_LEFT);
                        }
                    }
                    else if (right)
                    {
                        if (!animation.IsAnimationPlaying(WALK_RIGHT))
                        {
                            animation.LoopAnimation(WALK_RIGHT);
                        }
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
                            if (bossMob)
                            {
                                if (Game1.character.health <= 0)
                                {
                                    Game1.testBoss.Respawn(game);
                                }
                            }
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

        #region Movement functions
        private void MoveUp(ref Rectangle location)
        {
            up = true;
            down = false;
            left = false;
            right = false;
            if (name == "Laune")
            {
                animation.MaxFrameCount = 2;
            }
            if (!attackPlayer)
            {
                location.Y += (int)-(speed * 2);
            }
            else
                location.Y += (int)-(speed * 4);
            if (!animation.IsAnimationPlaying(WALK_UP))
            {
                animation.LoopAnimation(WALK_UP);
            }
            walking = true;
        }

        private void MoveDown(ref Rectangle location)
        {
            up = false;
            down = true;
            left = false;
            right = false;
            if (name == "Laune")
            {
                animation.MaxFrameCount = 2;
            }
            if (!attackPlayer)
            {
                location.Y += (int)(speed * 2);
            }
            else
                location.Y += (int)(speed * 4);
            if (!animation.IsAnimationPlaying(WALK_DOWN))
            {
                animation.LoopAnimation(WALK_DOWN);
            }
            walking = true;
        }

        private void MoveLeft(ref Rectangle location)
        {
            up = false;
            down = false;
            left = true;
            right = false;
            if (name == "Laune")
            {
                animation.MaxFrameCount = 1;
            }
            if (!attackPlayer)
            {
                location.X += (int)-(speed * 2);
            }
            else
                location.X += (int)-(speed * 4);
            if (!animation.IsAnimationPlaying(WALK_LEFT))
            {
                animation.LoopAnimation(WALK_LEFT);
            }
            walking = true;
        }

        private void MoveRight(ref Rectangle location)
        {
            up = false;
            down = false;
            left = false;
            right = true;
            if (name == "Laune")
            {
                animation.MaxFrameCount = 1;
            }
            if (!attackPlayer)
            {
                location.X += (int)(speed * 2);
            }
            else
                location.X += (int)(speed * 4);
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
            if (Game1.currentGameState == Game1.GameState.INTERACT)
            {
                dialogue.Update();
                if (!dialogue.isTalking && isInteracting == true)
                {
                    Game1.currentGameState = Game1.GameState.PLAY;
                    isInteracting = false;
                }
            }
        }

        public void Update(cCharacter player, H_Map.TileMap tiles, Game1 game, GameTime gameTime)
        {
            #region things to update every frame, positions
            aPosition.X = position.X - (position.Width / 2);
            aPosition.Y = position.Y - (position.Height / 2);
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

            if (!walking)
            {
                animation.MaxFrameCount = 1;
                if (up)
                {
                    if (!animation.IsAnimationPlaying(IDLE_UP))
                    {
                        animation.LoopAnimation(IDLE_UP);
                    }
                }
                if (down)
                {
                    if (!animation.IsAnimationPlaying(IDLE_DOWN))
                    {
                        animation.LoopAnimation(IDLE_DOWN);
                    }
                }
                if (left)
                {
                    if (!animation.IsAnimationPlaying(IDLE_LEFT))
                    {
                        animation.LoopAnimation(IDLE_LEFT);
                    }
                }
                if (right)
                {
                    if (!animation.IsAnimationPlaying(IDLE_RIGHT))
                    {
                        animation.LoopAnimation(IDLE_RIGHT);
                    }
                }
            }
            
            if (mob && !bossMob)
            {
                if (!attackPlayer && IsOnMap() && health > 0)
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

            if (health <= 0)
            {
                animation.StopAnimation();
                Death(gameTime);
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

            if (!attackPlayer && player.positionRectangle.Intersects(position) && IsOnMap())
            {
                if (health > 0)
                {
                    Vector2 pos = new Vector2(location.X, location.Y);
                    Vector2 direction = Game1.character.position - pos;
                    direction.Normalize();
                    Game1.character.Push(direction, 3);
                }
            }
        }

        public void Death(GameTime gameTime)
        {
            attackPlayer = false;
            animation.MaxFrameCount = 2;
            animation.UpdateAnimation(gameTime);
            //if (!dead)
            {
                animation.PlayAnimation(DEATH);
            }

            if (!animation.IsAnimationPlaying(DEATH))
            {
                //remove = true;
                Console.WriteLine("done");
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (IsOnMap())
            {
                if (!remove)
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
                    dialogue.isTalking = false;
                    Game1.currentGameState = Game1.GameState.PLAY;
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
                    Game1.character.GetSword(sword, 1, 20);
                    break;
                case 5:
                    if (secondDialogue != "null")
                    {
                        dialogue.dialogueManager = new DialogueManager(@"Content\npc\dialogue\" + secondDialogue + ".txt");
                    }
                    break;
                case 6:
                    Game1.character.GetSword(sword, 1, 20);
                    if (secondDialogue != "null")
                    {
                        dialogue.dialogueManager = new DialogueManager(@"Content\npc\dialogue\" + secondDialogue + ".txt");
                    }
                    break;
                default:
                    isInteracting = false;
                    dialogue.isTalking = false;
                    Game1.currentGameState = Game1.GameState.PLAY;
                    break;
            }
        }
    }
}