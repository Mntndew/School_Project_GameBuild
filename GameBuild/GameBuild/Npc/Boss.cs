/*
    ____________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________
   / /                                                                                                                                                                                                                                                                                                                                                                                                                                                  \
  / /        ooOOOOOOOOOOOOOOOOOOOO            ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS            ccCCCCCCCCCCCCCCCCCCCCCCCCCC    iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  llLLLLLLLLLL                            llLLLLLLLLLL                                      aaAAAAAAAAAAAAAAAA            ttTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT  iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII          ooOOOOOOOOOOOOOOOOOOOO          nnNNNNNNNNNN          nnNNNNNNNNNN  \
 / /     ooOOOOOOOOOOOOOOOOOOOOOOOOOOOO       ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS      ccCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC   iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  llLLLLLLLLLL                            llLLLLLLLLLL                                      aaAAAAAAAAAAAAAAAA            ttTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT  iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII      ooOOOOOOOOOOOOOOOOOOOOOOOOOOOO      nnNNNNNNNNNNNN        nnNNNNNNNNNN   \ 
| |  ooOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO   ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS  ccCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC   iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  llLLLLLLLLLL                            llLLLLLLLLLL                                     aaAAAAAAAAAAAAAAAAAA           ttTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT  iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  ooOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO  nnNNNNNNNNNNNN        nnNNNNNNNNNN    |
| |  ooOOOOOOOOOOOO           ooOOOOOOOOOOOO  ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS   ccCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC    iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  llLLLLLLLLLL                            llLLLLLLLLLL                                     aaAAAAAAAAAAAAAAAAAA           ttTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT  iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  ooOOOOOOOOOOOO          ooOOOOOOOOOOOO  nnNNNNNNNNNNNNNN      nnNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO  ssSSSSSSSSS                            ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                    aaAAAAAAAAAAAAAAAAAAAA                       ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNNNNNN      nnNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO  ssSSSSSSSSS                            ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                    aaAAAAAAAAAAAAAAAAAAAA                       ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNNNNNNNN    nnNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO  ssSSSSSSSSS                            ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                   aaAAAAAAAAAAaaAAAAAAAAAA                      ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNNNNNNNN    nnNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO  ssSSSSSSSSS                            ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                   aaAAAAAAAAAAaaAAAAAAAAAA                      ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNNNNNNNNNN  nnNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO  ssSSSSSSSSS                            ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                  aaAAAAAAAAAA  aaAAAAAAAAAA                     ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNNNNNNNNNN  nnNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO  ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS   ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                  aaAAAAAAAAAA  aaAAAAAAAAAA                     ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNNNNNNNNNNNNnnNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO  ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                 aaAAAAAAAAAA    aaAAAAAAAAAA                    ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNNnnNNNNNNNNNNNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO  ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                 aaAAAAAAAAAA    aaAAAAAAAAAA                    ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNNnnNNNNNNNNNNNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO    ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                aaAAAAAAAAAAAAAAAAAAAAAAAAAAAA                   ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNN  nnNNNNNNNNNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO                             ssSSSSSSSSS ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                aaAAAAAAAAAAAAAAAAAAAAAAAAAAAA                   ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNN  nnNNNNNNNNNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO                             ssSSSSSSSSS ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                               aaAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA                  ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNN    nnNNNNNNNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO                             ssSSSSSSSSS ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                               aaAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA                  ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNN    nnNNNNNNNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO                             ssSSSSSSSSS ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                              aaAAAAAAAAAA          aaAAAAAAAAAA                 ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNN      nnNNNNNNNNNNNNNN    |
| |  ooOOOOOOOOOOOO           ooOOOOOOOOOOOO    ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS ccCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC    iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  llLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL  llLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL    aaAAAAAAAAAA          aaAAAAAAAAAA                 ttTTTTTTTTTT               iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  ooOOOOOOOOOOOO          ooOOOOOOOOOOOO  nnNNNNNNNNNN      nnNNNNNNNNNNNNNN    |
| |  ooOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO  ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS  ccCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC   iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  llLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL  llLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL   aaAAAAAAAAAA            aaAAAAAAAAAA                ttTTTTTTTTTT               iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  ooOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO  nnNNNNNNNNNN        nnNNNNNNNNNNNN    |
 \ \     ooOOOOOOOOOOOOOOOOOOOOOOOOOOOO      ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS      ccCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC   iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  llLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL  llLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL   aaAAAAAAAAAA            aaAAAAAAAAAA                ttTTTTTTTTTT               iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII      ooOOOOOOOOOOOOOOOOOOOOOOOOOOOO      nnNNNNNNNNNN        nnNNNNNNNNNNNN    /
  \ \       ooOOOOOOOOOOOOOOOOOOOO             ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS            ccCCCCCCCCCCCCCCCCCCCCCCCCCC    iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  llLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL  llLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL  aaAAAAAAAAAA              aaAAAAAAAAAA               ttTTTTTTTTTT               iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII          ooOOOOOOOOOOOOOOOOOOOO          nnNNNNNNNNNN          nnNNNNNNNNNN   /
   \_\___________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________/
*/
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
        Random rand = new Random();
        Npc robot;
        float shootTimer = 0;
        const float SHOOTTIMER = 0.01f;
        float phaseTimer;
        float sleepTimer = 2;
        const float SLEEPTIMER = 2;
        float pathTimer = 200f;
        const float PATHTIMER = 200f;//milliseconds
        double angle;
        float beamAttackTimer = 0.08f;
        const float BEAMATTACKTIMER = 0.08f;
        string map;
        public int health = 300;
        public int maxHealth = 300;
        float healthBarWidth;
        float healthPct;
        int beamDamage;
        int speed = 4;
        int damage;
        int pathIndex;
        bool followPath;
        bool hasPath;
        public bool dead;
        public bool attackPlayer;
        public bool enraged;
        bool up, down, left, right;
        List<DamageEffect> damageEffectList = new List<DamageEffect>();
        AnimationComponent animation;
        Texture2D healthTexture;

        const int WALK_UP = 0;
        const int WALK_RIGHT = 1;
        const int WALK_DOWN = 2;
        const int WALK_LEFT = 3;
        const int IDLE_UP = 4;
        const int IDLE_RIGHT = 5;
        const int IDLE_DOWN = 6;
        const int IDLE_LEFT = 7;

        public enum phase
        {
            beam,
            mobs,
            sleep,
            charge
        }
        public phase currentPhase = phase.beam;

        public Boss(Rectangle position, Game1 game, string map)
        {
            this.position = position;
            this.map = map;
            healthTexture = game.Content.Load<Texture2D>(@"Game\health100");
            healthPos = new Rectangle();
            texture = game.Content.Load<Texture2D>(@"Npc\sprite\Cybot");
            targetTexture = game.Content.Load<Texture2D>(@"Game\target");
            angle = Math.Atan2(Game1.character.bossTarget.Y - position.Y, Game1.character.bossTarget.X + 16 - position.X);
            robot = new Npc(position.X - 64, position.Y, 64, 64, game.Content.Load<Texture2D>(@"robot"), game, this.map, 0, false, 10, 0, 0, 0, false);
            animation = new AnimationComponent(2, 8, 54, 70, 175, Microsoft.Xna.Framework.Point.Zero);
        }

        public void Update(Game1 game, GameTime gameTime)//Manages the phases
        {
            healthPct = ((float)health / (float)maxHealth);
            healthBarWidth = (healthTexture.Width * 25) * healthPct;
            healthPos.Width = (int)healthBarWidth;
            healthPos.X = 40;
            healthPos.Y = 10;
            healthPos.Height = healthTexture.Height;
            angle = Math.Atan2(Game1.character.bossTarget.Y - position.Y, Game1.character.bossTarget.X + 16 - position.X);
            animation.UpdateAnimation(gameTime);
            for (int i = 0; i < mobs.Count; i++)
            {
                if (mobs[i].health > 0)
                {
                    mobs[i].robotAngle = Math.Atan2(Game1.character.position.Y - mobs[i].position.Y, Game1.character.position.X - mobs[i].position.X);
                }
            }
            float elapsed = (float)gameTime.ElapsedGameTime.TotalSeconds;
            beamAttackTimer -= elapsed;

            for (int i = 0; i < game.activeNpcs.Count; i++)
            {
                if (game.activeNpcs[i].name == "Cybot")
                {
                    if (game.activeNpcs[i].health <= 0)
                    {
                        attackPlayer = true;
                    }
                }
            }

            if (robot.position.X > (position.X - 64))
            {
                robot.position.X -= 2;
            }
            if (robot.position.X < (position.X - 64))
            {
                robot.position.X += 2;
            }
            if (robot.position.Y > position.Y)
            {
                robot.position.Y -= 2;
            }
            if (robot.position.Y < position.Y)
            {
                robot.position.Y += 2;
            }
            phaseTimer += elapsed;
            if (!enraged)
            {
                if (phaseTimer >= 5)
                {
                    SwitchPhase();
                }
            }
            else
            {
                if (phaseTimer >= 2.5f)
                {
                    SwitchPhase();
                }
            }
            
            if (healthPct <= 0)
            {
                Death(game);
            }

            if (health <= maxHealth / 3)
            {
                enraged = true;
            }

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
                    if (Game1.character.positionRectangle.Intersects(projectiles[i].rectangle) && healthPct > 0)
                    {
                        Game1.character.inCombat = true;
                        if (beamAttackTimer <= 0 && projectiles[i].color.A == 255)
                        {
                            if (!enraged)
                            {
                                beamDamage = game.damageObject.dealDamage(1, 5);
                                Game1.character.Push(projectiles[i].velocity, 1f);
                            }
                            else
                            {
                                beamDamage = game.damageObject.dealDamage(2, 6);
                                if (i >= 40)
                                {
                                    Game1.character.Push(projectiles[i].velocity, 2f);
                                }
                            }
                            damageEffectList.Add(new DamageEffect(beamDamage, game, new Vector2(Game1.character.positionRectangle.X, Game1.character.positionRectangle.Y), new Color(255, 0, 0, 255), "npc"));
                            Game1.character.health -= beamDamage;
                            if (Game1.character.health <= 0)
                            {
                                Respawn(game);
                            }
                            Game1.character.Hit();
                            beamAttackTimer = BEAMATTACKTIMER;
                        }
                    }
                }
                else
                    projectiles.RemoveAt(i);
            }

            #region mob stuff
            for (int i = 0; i < mobs.Count; i++)
            {
                if (mobs[i].position.Intersects(Game1.character.positionRectangle))
                {
                    Game1.character.speed = 2;
                }
                else
                    Game1.character.speed = 4;

                mobs[i].Update(Game1.character, Game1.map, game, gameTime);
                if (mobs[i].health <= 0)
                {
                    mobs.RemoveAt(i);
                }
            }

            for (int i = 0; i < mobs.Count; i++)
            {
                for (int j = 0; j < mobs.Count; j++)
                {
                    if (mobs[i] != mobs[j])
                    {
                        if (mobs[i].bumpRectangle.Intersects(mobs[j].bumpRectangle))
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

            if (currentPhase != phase.charge)
            {
                if (left)
                {
                    if (!animation.IsAnimationPlaying(IDLE_LEFT))
                    {
                        animation.LoopAnimation(IDLE_LEFT);
                    }
                }
                else if (right)
                {
                    if (!animation.IsAnimationPlaying(IDLE_RIGHT))
                    {
                        animation.LoopAnimation(IDLE_RIGHT);
                    }
                }
                else if (up)
                {
                    if (!animation.IsAnimationPlaying(IDLE_UP))
                    {
                        animation.LoopAnimation(IDLE_UP);
                    }
                }
                else if (down)
                {
                    if (!animation.IsAnimationPlaying(IDLE_DOWN))
                    {
                        animation.LoopAnimation(IDLE_DOWN);
                    }
                }
            }

            if (attackPlayer && healthPct > 0)
            {
                switch (currentPhase)
                {
                    case phase.beam:
                        shootTimer -= elapsed;
                        if (shootTimer <= 0)
                        {
                            Shoot(game);
                            shootTimer = SHOOTTIMER;
                        }
                        break;
                    case phase.mobs:
                        SpawnMobs(game);
                        break;
                    case phase.sleep:
                        Sleep(gameTime);
                        break;
                    case phase.charge:
                        Charge(game, gameTime);
                        break;
                    default:
                        Charge(game, gameTime);
                        break;
                }
            }
        }

        public void Respawn(Game1 game)
        {
            health += (maxHealth - health) / 2;
            healthPct = ((float)health / (float)maxHealth);
            Game1.character.health = Game1.character.maxHealth;
            Game1.map = game.Content.Load<H_Map.TileMap>(@"Map\Map4_B");
            Game1.character.position.X = 1000;
            Game1.character.position.Y = 720;
            if (healthPct > 30)
            {
                enraged = false;
            }
        }

        private void Death(Game1 game)
        {
            if (!dead)
            {
                game.Npcs.Add(new Npc(map, "Cybotdead", -256, -256, 0, 0, false, false, false, false, "Cybot", "Cybot", true, false, false, false, 0, 0, 0, 0, 0, game, "Cybot dead", "nokey", null, null));
            }
            
            attackPlayer = false;
            for (int i = 0; i < mobs.Count; i++)
            {
                mobs[i].health = 0;
            }
            for (int i = 0; i < game.Npcs.Count; i++)
            {
                if (game.Npcs[i].name == "Cybotdead" && !dead)
                {
                    game.Npcs[i].isInteracting = true;
                    game.Npcs[i].dialogue.isTalking = true;
                }
            }
            if (!dead)
            {
                Game1.currentGameState = Game1.GameState.INTERACT;
            }
            dead = true;
        }

        public bool IsOnMap()
        {
            if (Game1.map.mapName.Remove(Game1.map.mapName.Length  - 1) == map)
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
                currentPhase = phase.charge;
                phaseTimer = 0;
            }
            if ((currentPhase == phase.sleep))
            {
                sleepTimer = SLEEPTIMER;
                currentPhase = phase.beam;
            }
        }

        private void Shoot(Game1 game)
        {
            if (healthPct > 0)
            {
                projectiles.Add(new Projectile(new Vector2(this.robot.position.Center.X - 8, this.robot.position.Y), game));
            }
        }

        private void SpawnMobs(Game1 game)
        {
            if (healthPct > 0 && mobs.Count < 50)
            {
                for (int i = 0; i < 5; i++)
                {
                    mobs.Add(new Npc(position.X + i, position.Y - 48 + i, 30, 25, game.Content.Load<Texture2D>(@"Npc\bot"), game, map, 1, true, 25, 1, 5, 1, true));
                }
                for (int i = 0; i < mobs.Count; i++)
                {
                    mobs[i].mob = true;
                    mobs[i].bossMob = true;
                    mobs[i].position.Width = 30;
                    mobs[i].position.Height = 25;
                    currentPhase = phase.charge;
                }
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

        private void Charge(Game1 game, GameTime gameTime)
        {
            Game1.character.targetSpeed = 5.5f;
            GoTo(new Vector2((Game1.character.positionRectangle.X + (Game1.character.positionRectangle.Width / 2)) / Game1.map.tileWidth, (Game1.character.positionRectangle.Y + (Game1.character.positionRectangle.Height / 2)) / Game1.map.tileHeight), false, gameTime);
            if (position.Intersects(Game1.character.attackRectangle) && healthPct > 0)
            {
                damage = game.damageObject.dealDamage(10, 27);
                damageEffectList.Add(new DamageEffect(damage, game, new Vector2(Game1.character.positionRectangle.X, Game1.character.positionRectangle.Y), new Color(235, 10, 10, 255), "npc"));
                Game1.character.health -= damage;
                if (Game1.character.health <= 0)
                {
                    Respawn(game);
                }
                Game1.character.Hit();
                phaseTimer = 0;
                currentPhase = phase.beam;
            }

            if (!enraged)
            {
                if (phaseTimer >= 5)
                {
                    phaseTimer = 0;
                    currentPhase = phase.beam;
                }
            }
            else
            {
                if (phaseTimer >= 2.5f)
                {
                    phaseTimer = 0;
                    currentPhase = phase.beam;
                }
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
            if ((path.Length == 1 && path[0].X == -32 && path[0].Y == -32) || position.Intersects(Game1.character.positionRectangle))
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
                if (followPath && currentPhase == phase.charge)
                {
                    if (path[pathIndex].X < position.X + position.Width / 2)
                    {
                        if (!animation.IsAnimationPlaying(WALK_LEFT))
                        {
                            animation.LoopAnimation(WALK_LEFT);
                        }
                        position.X -= speed;
                        left = true;
                        right = false;
                        up = false;
                        down = false;
                    }
                    else if (path[pathIndex].X > position.X + position.Width / 2)
                    {
                        if (!animation.IsAnimationPlaying(WALK_RIGHT))
                        {
                            animation.LoopAnimation(WALK_RIGHT);
                        }
                        position.X += speed;
                        left = false;
                        right = true;
                        up = false;
                        down = false;
                    }
                    if (path[pathIndex].Y < position.Y + position.Height / 2)
                    {
                        if (!animation.IsAnimationPlaying(WALK_UP))
                        {
                            animation.LoopAnimation(WALK_UP);
                        }
                        position.Y -= speed;
                        left = false;
                        right = false;
                        up = true;
                        down = false;
                    }
                    else if (path[pathIndex].Y > position.Y + position.Height / 2)
                    {
                        if (!animation.IsAnimationPlaying(WALK_DOWN))
                        {
                            animation.LoopAnimation(WALK_DOWN);
                        }
                        position.Y += speed;
                        left = false;
                        right = false;
                        up = false;
                        down = true;
                    }
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(robot.walkSprite, robot.position, Color.White);
            spriteBatch.Draw(texture, position, animation.GetFrame(), Color.White);
            spriteBatch.Draw(targetTexture, Game1.character.bossTarget, new Color(255, 50, 50, 100));
        }

        public void DrawMobs(SpriteBatch spriteBatch)
        {
            for (int i = 0; i < mobs.Count; i++)
            {
                spriteBatch.Draw(mobs[i].walkSprite, mobs[i].position, null, Color.White, (float)mobs[i].robotAngle, new Vector2(15, 12), SpriteEffects.None, 0);
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