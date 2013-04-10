using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameBuild
{
    public class ParticleSystemManager
    {
        public ParticleSystem[] particleSystem;

        public ParticleSystemManager(Game1 game)
        {
            particleSystem = new ParticleSystem[1];
            particleSystem[0] = new ParticleSystem(game, 10);
        }
    }
}
