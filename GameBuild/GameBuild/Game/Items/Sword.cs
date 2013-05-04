using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameBuild.Game.Items
{
    public class Sword
    {
        public string swordName;
        public int minDamage, maxDamage;

        public Sword(string swordName, int minDamage, int maxDamage)
        {
            this.swordName = swordName;
            this.minDamage = minDamage;
            this.maxDamage = maxDamage;
        }

        public void SetSprite(string swordName, Game1 game)
        {
            if (Game1.character.gender == "male")
            {
                Game1.character.animation = new AnimationComponent(4, 12, 53, 70, 150, Point.Zero);
                if (swordName == "cockiri")
                {
                    Game1.character.spriteSheet = game.Content.Load<Texture2D>(@"Player\Sprite\Male\male-cockiri");
                }
                else if(swordName == "dong")
                {
                    Game1.character.spriteSheet = game.Content.Load<Texture2D>(@"Player\Sprite\Male\male-dong");
                }
                else if (swordName == "thruster")
                {
                    Game1.character.spriteSheet = game.Content.Load<Texture2D>(@"Player\Sprite\Male\male-thruster");
                }
            }
            else if (Game1.character.gender == "female")
            {
                Game1.character.animation = new AnimationComponent(4, 12, 41, 70, 150, Point.Zero);
                if (swordName == "cockiri")
                {
                    Game1.character.spriteSheet = game.Content.Load<Texture2D>(@"Player\Sprite\Female\male-cockiri");
                }
                else if (swordName == "dong")
                {
                    Game1.character.spriteSheet = game.Content.Load<Texture2D>(@"Player\Sprite\Female\male-dong");
                }
                else if (swordName == "thruster")
                {
                    Game1.character.spriteSheet = game.Content.Load<Texture2D>(@"Player\Sprite\Female\male-thruster");
                }
            }
        }
    }
}