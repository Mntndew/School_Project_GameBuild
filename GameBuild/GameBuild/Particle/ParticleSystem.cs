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

        //for testing
        MouseState mouse;
        Rectangle position;
        bool left = true;
        bool right;

        public ParticleSystem(Game1 game, int amount)
        {
            texture = game.Content.Load<Texture2D>(@"Particle\blood");
            this.amount = amount;
            position = new Rectangle(700, 200, 1, 1);
            rand = new Random();
        }

        public void Update(GameTime gameTime)
        {
            mouse = Mouse.GetState();
            float elapsed = (float)gameTime.ElapsedGameTime.TotalSeconds;
            timer -= elapsed;
            if (left)
            {
                position.X -= 4;
                if (position.X <= 0)
                {
                    right = true;
                    left = false;
                }
            }
            if (right)
            {
                position.X += 4;
                if (position.X >= 800)
                {
                    left = true;
                    right = false;
                }
            }
            
            for (int i = 0; i < particles.Count; i++)
            {
                particles[i].Update(gameTime);
                if (particles[i].dead)
                {
                    particles.RemoveAt(i);
                }
            }
        }

        public void Add(int x, int y)
        {
            for (int i = 0; i < 10; i++)
            {
                particles.Add(new Particle(new Rectangle(x, y, texture.Width, texture.Height), new Vector2((float)rand.Next(-4, 4), rand.Next(0, 2)), 1, 2, 1, false, false, true));
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