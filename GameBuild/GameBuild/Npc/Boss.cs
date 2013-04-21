using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameBuild.Npc
{
    public class Boss
    {
        public Rectangle position;
        Rectangle healthPos;
        Vector2[] path;
        Texture2D texture;
        Texture2D targetTexture;
        public List<Projectile> projectiles = new List<Projectile>();
        public List<Npc> mobs = new List<Npc>();
        Npc robot;
        float phaseTimer;
        float sleepTimer = 2;
        const float SLEEPTIMER = 2;
        const float TIMER = 0.1f;
        float pathTimer = 200f;
        const float PATHTIMER = 200f;//milliseconds
        double angle;
        float beamAttackTimer = 0.08f;
        const float BEAMATTACKTIMER = 0.08f;
        string map;
        public int health = 250;
        public int maxHealth = 250;
        float healthBarWidth;
        float healthPct;
        int beamDamage;
        int speed = 4;
        int damage;
        int pathIndex;
        bool followPath;
        bool hasPath;
        public bool dead;
        List<DamageEffect> damageEffectList = new List<DamageEffect>();
        Texture2D healthTexture;

        public enum phase
        {
            beam,
            mobs,
            sleep,
            berserk
        }
        public phase currentPhase = phase.beam;

        public Boss(Rectangle position, Game1 game, string map)
        {
            this.position = position;
            this.map = map;
            healthTexture = game.Content.Load<Texture2D>(@"Game\health100");
            healthPos = new Rectangle();
            texture = game.Content.Load<Texture2D>(@"Game\blackness");
            targetTexture = game.Content.Load<Texture2D>(@"Game\target");
            angle = Math.Atan2(Game1.character.bossTarget.Y - position.Y, Game1.character.bossTarget.X + 16 - position.X);
            robot = new Npc(new Rectangle(position.X - 64, position.Y, 64, 64), game.Content.Load<Texture2D>(@"robot"), game, this.map, 0, false, 10, 0, 0, 0, false);
        }

        public void Update(Game1 game, GameTime gameTime)//Manages the phases
        {
            if (currentPhase != phase.sleep)
            {
                angle = Math.Atan2(Game1.character.bossTarget.Y - position.Y, Game1.character.bossTarget.X + 16 - position.X);
            }
            
            float elapsed = (float)gameTime.ElapsedGameTime.TotalSeconds;
            beamAttackTimer -= elapsed;

            robot.position.X = position.X - 64;
            robot.position.Y = position.Y;

            if (currentPhase != phase.sleep)
            {
                phaseTimer += elapsed;
                if (phaseTimer >= 7)
                {
                    SwitchPhase();
                }
            }

            healthPct = ((float)health / (float)maxHealth);
            healthBarWidth = (healthTexture.Width * 25) * healthPct;
            healthPos.Width = (int)healthBarWidth;
            healthPos.X = 40;
            healthPos.Y = 10;
            healthPos.Height = healthTexture.Height;

            for (int i = 0; i < damageEffectList.Count; i++)
            {
                damageEffectList[i].Effect();
            }

            for (int i = 0; i < projectiles.Count; i++)
            {
                projectiles[i].CheckDead(gameTime);
                if (!projectiles[i].dead)
                {
                    projectiles[i].Update(gameTime);
                    if (Game1.character.position.Intersects(projectiles[i].rectangle))
                    {
                        Game1.character.inCombat = true;
                        if (beamAttackTimer <= 0)
                        {
                            beamDamage = game.damageObject.dealDamage(1, 4);
                            damageEffectList.Add(new DamageEffect(beamDamage, game, new Vector2(Game1.character.position.X, Game1.character.position.Y), new Color(255, 0, 0, 255), "npc"));
                            Game1.character.health -= beamDamage;
                            Game1.character.Hit();
                            beamAttackTimer = BEAMATTACKTIMER;
                        }
                    }
                }
                else
                    projectiles.RemoveAt(i);
            }

            for (int i = 0; i < mobs.Count; i++)
            {
                if (mobs[i].health > 0)
                {
                    mobs[i].Update(Game1.character, Game1.map, game, gameTime);
                }
                else
                    mobs.RemoveAt(i);
            }

            #region mob-mob collision
            for (int i = 0; i < mobs.Count; i++)
            {
                if (mobs[i].position.Intersects(Game1.character.position) && mobs[i].health > 0)
                {
                    Game1.character.speed = 2;
                }
                else
                    Game1.character.speed = 4;

                for (int j = 0; j < mobs.Count; j++)
                {
                    if (mobs[i] != mobs[j])
                    {
                        if (mobs[i].position.Intersects(mobs[j].position))
                        {
                            if (mobs[i].position.X < mobs[j].position.X)
                            {
                                mobs[i].position.X -= 1;
                                mobs[j].position.X += 1;
                            }
                            if (mobs[i].position.X > mobs[j].position.X)
                            {
                                mobs[i].position.X += 1;
                                mobs[j].position.X -= 1;
                            }
                            if (mobs[i].position.Y < mobs[j].position.Y)
                            {
                                mobs[i].position.Y -= 1;
                                mobs[j].position.Y += 1;
                            }
                            if (mobs[i].position.Y > mobs[j].position.Y)
                            {
                                mobs[i].position.Y += 1;
                                mobs[j].position.Y -= 1;
                            }
                        }
                    }
                }
            }
            if (mobs.Count == 0)
            {
                Game1.character.speed = 4;
                if (currentPhase == phase.mobs)
                {
                    SwitchPhase();
                }
            }
            #endregion

            switch (currentPhase)
            {
                case phase.beam:
                    Shoot(game);
                    break;
                case phase.mobs:
                    if (phaseTimer <= 7)
                    {
                        SpawnMobs(game);
                    }
                    break;
                case phase.sleep:
                    Sleep(gameTime);
                    break;
                case phase.berserk:
                    Berserk(game, gameTime);
                    break;
                default:
                    Berserk(game, gameTime);
                    break;
            }

            if (healthPct <= 0)
            {
                Death();
            }
        }

        public bool IsOnMap()
        {
            if (Game1.map.mapName == map)
            {
                return true;
            }
            else
                return false;
        }

        private void SwitchPhase()
        {
            if (currentPhase == phase.beam && phaseTimer != 0)
            {
                currentPhase = phase.mobs;
                phaseTimer = 0;
            }
            if (currentPhase == phase.mobs && phaseTimer != 0)
            {
                currentPhase = phase.berserk;
                phaseTimer = 0;
            }
            if (currentPhase == phase.sleep)
            {
                sleepTimer = SLEEPTIMER;
                currentPhase = phase.beam;
                phaseTimer = 0;
            }
        }

        private void Shoot(Game1 game)
        {
            projectiles.Add(new Projectile(new Vector2(this.robot.position.X, this.robot.position.Y), game));
        }

        private void SpawnMobs(Game1 game)
        {
            for (int i = 0; i < 10; i++)
            {
                if (mobs.Count < 50)
                {
                    mobs.Add(new Npc(new Rectangle(position.X + i, position.Y - 48 + i, 48, 48), game.Content.Load<Texture2D>(@"Game\blackness"), game, map, 1, true, 5, 1, 3, 5, true));
                }
            }
            for (int i = 0; i < mobs.Count; i++)
            {
                mobs[i].mob = true;
                mobs[i].bossMob = true;
            }
            currentPhase = phase.berserk;
        }

        private void Sleep(GameTime gameTime)
        {
            float elapsed = (float)gameTime.ElapsedGameTime.TotalSeconds;
            sleepTimer -= elapsed;
            if (sleepTimer <= 0)
            {
                SwitchPhase();
            }
        }

        private void Berserk(Game1 game, GameTime gameTime)
        {
            Game1.character.targetSpeed = 5.5f;
            GoTo(new Vector2((Game1.character.position.X + (Game1.character.position.Width / 2)) / Game1.map.tileWidth, (Game1.character.position.Y + (Game1.character.position.Height / 2)) / Game1.map.tileHeight), false, gameTime);
            if (position.Intersects(Game1.character.attackRectangle))
            {
                damage = game.damageObject.dealDamage(10, 27);
                damageEffectList.Add(new DamageEffect(damage, game, new Vector2(Game1.character.position.X, Game1.character.position.Y), new Color(235, 10, 10, 255), "npc"));
                Game1.character.health -= damage;
                Game1.character.Hit();
                phaseTimer = 0;
                currentPhase = phase.beam;
            }

            if (phaseTimer >= 7)
            {
                phaseTimer = 0;
                currentPhase = phase.beam;
            }
        }

        public void GoTo(Vector2 targetPoint, bool isWaypoint, GameTime gameTime)//manages findpath and followpath
        {
            float elapsed = (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            pathTimer -= elapsed;
            if (pathTimer <= 0)
            {
                FindPath(targetPoint);
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
                end = new Pathfinding.Point((int)targetPoint.X, (int)targetPoint.Y);

                path = Pathfinding.PathFinder.GetVectorPath(Pathfinding.PathFinder.FindPath(map, start, end), Game1.map.tileWidth, Game1.map.tileHeight);
                hasPath = true;
                followPath = true;
                pathIndex = path.Length - 1;
            }
        }

        private void FollowPath(GameTime gameTime, bool isWaypoint)
        {
            if ((path.Length == 1 && path[0].X == -32 && path[0].Y == -32) || position.Intersects(Game1.character.position))
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
                        position.X -= speed;
                    }
                    else if (path[pathIndex].X > position.X + position.Width / 2)
                    {
                        position.X += speed;
                    }
                    if (path[pathIndex].Y < position.Y + position.Height / 2)
                    {
                        position.Y -= speed;
                    }
                    else if (path[pathIndex].Y > position.Y + position.Height / 2)
                    {
                        position.Y += speed;
                    }
                }
            }
        }

        private void Death()
        {
            for (int i = 0; i < mobs.Count; i++)
            {
                mobs[i].health = 0;
            }
            dead = true;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(robot.walkSprite, new Rectangle(robot.position.X + 16, robot.position.Y + 16, robot.position.Width, robot.position.Height),
                null, new Color(100, 100, 255, 255), (float)angle, new Vector2(robot.position.Width / 2, robot.position.Height / 3), SpriteEffects.None, 0);
            spriteBatch.Draw(texture, position, Color.White);
            spriteBatch.Draw(targetTexture, Game1.character.bossTarget, new Color(255, 50, 50, 100));
        }

        public void DrawMobs(SpriteBatch spriteBatch)
        {
            for (int i = 0; i < mobs.Count; i++)
            {
                if (mobs[i].health > 0)
                {
                    mobs[i].Draw(spriteBatch);
                }
            }
        }

        public void DrawHealth(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(healthTexture, new Rectangle(healthPos.X, healthPos.Y, healthPos.Width, healthPos.Height), Color.White);
            spriteBatch.DrawString(Game1.debugFont, "" + (healthPct * 100) + "%", new Vector2(640, 2), Color.Black);
        }

        public void DrawDamage(SpriteBatch spriteBatch, Game1 game)
        {
            for (int i = 0; i < damageEffectList.Count; i++)
            {
                damageEffectList[i].Draw(spriteBatch, game);
            }
        }
    }
}