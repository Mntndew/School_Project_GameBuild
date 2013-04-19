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
        float speed = 2.5f;
        float timer = 2.5f;
        public Color color;
        ParticleSystemEmitter emitter;
        Random rand = new Random();
        float particleTimer;
        const float PARTICLETIMER = 0.03f;

        public Projectile(Vector2 position, Game1 game)
        {
            this.position = position;
            rectangle = new Rectangle((int)position.X, (int)position.Y, 24, 24);
            texture = game.Content.Load<Texture2D>(@"Game\blackness");
            angle = Math.Atan2(Game1.character.bossTarget.Y - position.Y, Game1.character.bossTarget.X - 32 - position.X);
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
            if (particleTimer <= 0)
            {
                Particle();
                particleTimer = PARTICLETIMER;
            }
        }

        public void Particle()
        {
            if (color.A > 150)
            {
                emitter.Add((int)position.X, (int)position.Y, 16, 16, 1, (int)velocity.X - 2, (int)velocity.X + 2, -4, -2, new Color(20, 10, 10, 100), 0.15f, 1, 1, false, false, false);//smoke
                emitter.Add((int)position.X, (int)position.Y, 10, 14, 1, (int)velocity.X - rand.Next(1, 4), (int)velocity.X + rand.Next(1, 4), (int)velocity.Y - 2, (int)velocity.Y + 2, new Color(30, 60, 30, 25), 0.15f, 1, 1, false, false, false);//fore
                emitter.Add((int)position.X, (int)position.Y, 8, 12, 1, (int)velocity.X - 2, (int)velocity.X + 2, (int)velocity.Y - 2, (int)velocity.Y + 2, new Color(30, 80, 50, 50), 0.15f, 1, 1, false, false, false);//middle
                emitter.Add((int)position.X, (int)position.Y, 12, 10, 1, (int)velocity.X - rand.Next(1, 4), (int)velocity.X + rand.Next(1, 4), (int)velocity.Y - 2, (int)velocity.Y + 2, new Color(20, 20, 60, 200), 0.15f, 1, 1, false, false, false);//base smoke
                emitter.Add((int)position.X, (int)position.Y, 8, 8, 1, (int)velocity.X - rand.Next(1, 4), (int)velocity.X + rand.Next(1, 4), (int)velocity.Y - 10, (int)velocity.Y, new Color(10, 10, 10, 50), 0.15f, 1, 1, false, false, false);//smoke
            }
        }

        public void CheckDead(GameTime gameTime)
        {
            float elapsed = (float)gameTime.ElapsedGameTime.TotalSeconds;
            timer -= elapsed;
            if (timer <= 0)
            {
                color *= 0.80f;
            }
            if (color.A == 0)
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