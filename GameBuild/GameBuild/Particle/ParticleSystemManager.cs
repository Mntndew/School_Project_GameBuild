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
            particleSystem = new ParticleSystem[2];
            particleSystem[0] = new ParticleSystem(game, 10);
            particleSystem[1] = new ParticleSystem(game, 10);
        }
    }
}
