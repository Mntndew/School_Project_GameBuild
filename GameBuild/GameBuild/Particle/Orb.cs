using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameBuild
{
    public class Orb
    {
        public Rectangle position;
        Vector2 velocity;
        Vector2 distance;
        public Color color;
        bool picked;

        public Orb(Rectangle position)
        {
            this.position = position;
            color = new Color(255, 255, 255);
            velocity = new Vector2();
        }

        public void Update()
        {
            position.X += (int)velocity.X;
            position.Y += (int)velocity.Y;

            distance.X = position.X - Game1.character.position.X;
            distance.Y = position.Y - Game1.character.position.Y;

            if (!picked)
            {
                velocity.X = -(distance.X / 20) + 1;
                velocity.Y = -(distance.Y / 20) + 1;
            }
            else
            {
                velocity.X = 0;
                velocity.Y = 0;
                color *= 0.5f;
            }

            if (position.Intersects(Game1.character.attackRectangle))
            {
                picked = true;
            }
        }
    }
}
