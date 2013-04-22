using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameBuild.Npc
{
    public class Projectile
    {
        public Vector2 position;
        public Rectangle rectangle;
        public Texture2D texture;
        Vector2 velocity;
        public bool dead;
        double angle;
        float speed = 7;
        float timer = 0.7f;
        public Color color;
        ParticleSystemEmitter emitter;
        Random rand = new Random();
        float particleTimer;
        const float PARTICLETIMER = 0.02f;

        public Projectile(Vector2 position, Game1 game)
        {
            this.position = position;
            rectangle = new Rectangle((int)position.X, (int)position.Y, 24, 24);
            texture = game.Content.Load<Texture2D>(@"Game\blackness");
            angle = Math.Atan2(Game1.character.bossTarget.Y - position.Y, Game1.character.bossTarget.X + 16 - position.X);
            velocity.X = speed * (float)Math.Cos(angle);
            velocity.Y = speed * (float)Math.Sin(angle);
            color = new Color(255, 255, 255);
            emitter = new ParticleSystemEmitter(game);
        }

        public void Update(GameTime gameTime)
        {
            position.X += velocity.X;
            position.Y += velocity.Y;
            rectangle.X = (int)position.X;
            rectangle.Y = (int)position.Y;
            float elapsed = (float)gameTime.ElapsedGameTime.TotalSeconds;
            particleTimer -= elapsed;
            emitter.Update(gameTime);
            if (particleTimer <= 0 && color.A == 255)
            {
                Particle();
                particleTimer = PARTICLETIMER;
            }
        }

        public void Particle()
        {
            //blue/purple
            emitter.Add((int)position.X, (int)position.Y, 12, 12, 1, -2, 2, -4, -3, new Color(50, 50, 100, 255), 0.015f, 1, 1, false, false, false);

            //smoke
            emitter.Add((int)position.X, (int)position.Y, 20, 20, 2, -2, 2, -6, -4, new Color(10, 5, 5, 255), 0.2f, 1, 1, false, false, false);

            //blue
            emitter.Add((int)position.X, (int)position.Y, 12, 12, 1, -4, 4, -4, -3, new Color(125, 125, 250, 10), 0.15f, 1, 1, false, false, false);

            //green
            emitter.Add((int)position.X, (int)position.Y, 16, 16, 1, -2, 2, -4, -3, new Color(75, 200, 75, 100), 0.15f, 1, 1, false, false, true);
        }

        public void CheckDead(GameTime gameTime)
        {
            float elapsed = (float)gameTime.ElapsedGameTime.TotalSeconds;
            timer -= elapsed;
            if (timer <= 0)
            {
                color *= 0.80f;
            }
            if (color.A <= 0)
            {
                dead = true;
            }
        }

        public void DrawParticles(SpriteBatch spriteBatch)
        {
            emitter.Draw(spriteBatch);
        }
    }
}