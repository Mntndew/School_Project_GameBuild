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
        Texture2D texture;
        Texture2D targetTexture;
        public List<Projectile> projectiles = new List<Projectile>();
        public List<Npc> mobs = new List<Npc>();
        float timer = 0.1f;
        float sleepTimer = 2;
        const float SLEEPTIMER = 2;
        const float TIMER = 0.1f;
        double angle;
        float beamAttackTimer = 1;
        const float BEAMATTACKTIMER = 1;
        string map;
        public int health = 300;
        public int maxHealth = 300;
        float healthBarWidth;
        float healthPct;
        int beamDamage;
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
        }

        public void Update(Game1 game, GameTime gameTime)//Manages the phases
        {
            if (currentPhase != phase.sleep)
            {
                angle = Math.Atan2(Game1.character.bossTarget.Y - position.Y, Game1.character.bossTarget.X + 16 - position.X);
            }
            
            Console.WriteLine(angle);
            float elapsed = (float)gameTime.ElapsedGameTime.TotalSeconds;
            beamAttackTimer -= elapsed;

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
                        Game1.character.speed = 2;
                        if (beamAttackTimer <= 0)
                        {
                            beamDamage = game.damageObject.dealDamage(15, 30);
                            damageEffectList.Add(new DamageEffect(beamDamage, game, new Vector2(Game1.character.position.X, Game1.character.position.Y), new Color(255, 0, 0, 255), "npc"));
                            //Game1.character.health -= beamDamage;
                            Game1.character.Hit();
                            beamAttackTimer = BEAMATTACKTIMER;
                        }
                    }
                    else
                        Game1.character.speed = 4;
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
            #endregion

            switch (currentPhase)
            {
                case phase.beam:
                    Shoot(game);
                    break;
                case phase.mobs:
                    SpawnMobs(game);
                    break;
                case phase.sleep:
                    Sleep(gameTime);
                    break;
                case phase.berserk:
                    Berserk();
                    break;
                default:
                    Sleep(gameTime);
                    break;
            }
        }

        public bool IsOnMap()
        {
            if (Game1.map.mapName.Remove(Game1.map.mapName.Length - 1) == map)
            {
                return true;
            }
            else
                return false;
        }

        private void SwitchPhase()
        {
            if (currentPhase == phase.beam)
            {
                currentPhase = phase.mobs;
            }
            if (currentPhase == phase.mobs)
            {
                currentPhase = phase.berserk;
            }
            if (currentPhase == phase.sleep)
            {
                sleepTimer = SLEEPTIMER;
                currentPhase = phase.beam;
            }
        }

        private void Shoot(Game1 game)
        {
            projectiles.Add(new Projectile(new Vector2(this.position.X, this.position.Y), game));
        }

        private void SpawnMobs(Game1 game)
        {
            mobs.Add(new Npc(new Rectangle((position.X - 48) + 80, (position.Y - 48), 48, 48), game.Content.Load<Texture2D>(@"Game\blackness"), game, map, 1, true, 25, 1, 1, 25));
            for (int i = 0; i < mobs.Count; i++)
            {
                mobs[i].mob = true;
                mobs[i].bossMob = true;
            }
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

        private void Berserk()
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, new Rectangle(position.X + 32, position.Y + 32, position.Width, position.Height), null, Color.White, (float)angle, new Vector2(texture.Width / 2, texture.Height / 2), SpriteEffects.None, 0);
            //spriteBatch.Draw(texture, position, Color.White);
            spriteBatch.Draw(targetTexture, Game1.character.bossTarget, new Color(255, 100, 100, 100));
        }

        public void DrawMobs(SpriteBatch spriteBatch)
        {
            for (int i = 0; i < mobs.Count; i++)
            {
                mobs[i].Draw(spriteBatch);
            }
        }

        public void DrawHealth(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(healthTexture, new Rectangle(healthPos.X, healthPos.Y, healthPos.Width, healthPos.Height), Color.White);
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