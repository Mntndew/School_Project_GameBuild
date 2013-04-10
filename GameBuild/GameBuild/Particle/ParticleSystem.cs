using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace GameBuild
{
    public class ParticleSystem
    {
        Texture2D texture;
        List<Particle> particles = new List<Particle>();
        
        int amount;
        Random rand;

        float timer = 0.075f;
        const float TIMER = 0.075f;

        public ParticleSystem(Game1 game, int amount)
        {
            texture = game.Content.Load<Texture2D>(@"Particle\blood");
            this.amount = amount;
            rand = new Random();
        }

        public void Update(GameTime gameTime)
        {
            float elapsed = (float)gameTime.ElapsedGameTime.TotalSeconds;
            timer -= elapsed;
            for (int i = 0; i < particles.Count; i++)
            {
                particles[i].Update(gameTime);
                if (particles[i].dead)
                {
                    particles.RemoveAt(i);
                }
            }
        }

        public void Add(int x, int y, int width, int height, int amount, int minVelocityX, int maxVelocityX, int minVelocityY, int maxVelocityY, float timer, float scaleModifier, float rotationModifier, bool scaleMultiplicative,
            bool rotationMultiplicative, bool hasGravity)
        {
            for (int i = 0; i < amount; i++)
            {
                particles.Add(new Particle(new Rectangle(x, y, width, height), new Vector2(rand.Next(minVelocityX, maxVelocityX), rand.Next(minVelocityY, maxVelocityY)), timer, scaleModifier,
                    rotationModifier, rotationMultiplicative, scaleMultiplicative, hasGravity));
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            for (int i = 0; i < particles.Count; i++)
            {
                spriteBatch.Draw(texture, particles[i].position, particles[i].color);
            }
        }
    }
}