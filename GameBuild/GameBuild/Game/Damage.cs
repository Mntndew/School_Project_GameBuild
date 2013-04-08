﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameBuild
{
    public class Damage
    {
        public int damage;

        Random rand = new Random();

        public Damage()
        {
        }

        public int dealDamage(int min, int max)
        {
            this.damage = rand.Next(min, max);
            return damage;
        }
    }

    public class DamageEffect
    {
        public Vector2 position;
        string damageString;
        string type;
        Color color;
        public bool active;

        public DamageEffect(int damage, Game1 game, Vector2 position, Color color, string type)
        {
            this.type = type;
            this.position = position;
            this.color = color;
            damageString = "" + damage;
        }

        public void Effect()
        {
            position.Y -= 1;
            if (color.A > 0)
            {
                if (type  == "damage")
                {
                    if (color.R > color.B)
                    {
                        color.A -= 7;
                        color.R -= 7;
                    }
                    else
                    {
                        color.A -= 7;
                        color.R -= 7;
                        color.G -= 7;
                        color.B -= 7;
                    }
                }
                if (type == "regen")
                {
                    color.A -= 5;
                    //color.R -= 5;
                    color.G -= 5;
                    //color.B -= 5;
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch, Game1 game)
        {
            spriteBatch.DrawString(game.spriteFont, damageString, position, color);
        }
    }
}