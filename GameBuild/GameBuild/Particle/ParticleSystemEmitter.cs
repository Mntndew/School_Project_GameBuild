using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace GameBuild
{
    public class ParticleSystemEmitter
    {
        Texture2D texture;
        List<Particle> particles = new List<Particle>();

        Random rand;

        public ParticleSystemEmitter(Game1 game)
        {
            texture = game.Content.Load<Texture2D>("particle");
            rand = new Random();
        }

        public void Update(GameTime gameTime)
        {
            for (int i = 0; i < particles.Count; i++)
            {
                particles[i].Update(gameTime);
                if (particles[i].dead)
                {
                    particles.RemoveAt(i);
                }
            }
        }

        public void Add(int x, int y, int width, int height, int amount, int minVelocityX, int maxVelocityX, int minVelocityY, int maxVelocityY, Color color, float timer, float scaleModifier, float rotationModifier, bool scaleMultiplicative,
            bool rotationMultiplicative, bool hasGravity)
        {
            for (int i = 0; i < amount; i++)
            {
                particles.Add(new Particle(new Rectangle(x, y, width, height), new Vector2(rand.Next(minVelocityX, maxVelocityX), rand.Next(minVelocityY, maxVelocityY)), color, timer, scaleModifier,
                    rotationModifier, rotationMultiplicative, scaleMultiplicative, hasGravity));
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            for (int i = 0; i < particles.Count; i++)
            {
                if (!particles[i].dead)
                {
                    //spriteBatch.Draw(texture, new Vector2(particles[i].position.X, particles[i].position.Y), particles[i].position, particles[i].color, particles[i].rotation, new Vector2(particles[i].position.Width / 2, particles[i].position.Height / 2), particles[i].scale, SpriteEffects.None, 0);
                    spriteBatch.Draw(texture, particles[i].position, particles[i].color);
                }
            }
        }
    }
}