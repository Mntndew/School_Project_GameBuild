using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace GameBuild
{
    public class ParticleSystem
    {
        public List<ParticleSystemEmitter> emitters = new List<ParticleSystemEmitter>();

        public void Update(GameTime gameTime)
        {
            for (int i = 0; i < emitters.Count; i++)
            {
                if (emitters[i] != null)
                {
                    emitters[i].Update(gameTime);
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            for (int i = 0; i < emitters.Count; i++)
            {
                if (emitters[i] != null)
                {
                    emitters[i].Draw(spriteBatch);
                }
            }
        }
    }
}
