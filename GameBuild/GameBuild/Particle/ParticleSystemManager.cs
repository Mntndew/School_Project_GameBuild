using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;

namespace GameBuild
{
    public class ParticleSystemManager
    {
        public ParticleSystem[] particleSystem;

        public ParticleSystemManager()
        {
            particleSystem = new ParticleSystem[2];
        }

        public void AddParticleSystem(Game1 game)
        {
            for (int i = 0; i < particleSystem.Length; i++)
            {
                particleSystem[i] = new ParticleSystem(game);
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            for (int i = 0; i < particleSystem.Length; i++)
            {
                particleSystem[i].Draw(spriteBatch);
            }
        }
    }
}
