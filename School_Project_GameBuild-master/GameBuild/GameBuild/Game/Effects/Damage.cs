/*
    ____________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________
   / /                                                                                                                                                                                                                                                                                                                                                                                                                                                  \
  / /        ooOOOOOOOOOOOOOOOOOOOO            ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS            ccCCCCCCCCCCCCCCCCCCCCCCCCCC    iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  llLLLLLLLLLL                            llLLLLLLLLLL                                      aaAAAAAAAAAAAAAAAA            ttTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT  iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII          ooOOOOOOOOOOOOOOOOOOOO          nnNNNNNNNNNN          nnNNNNNNNNNN  \
 / /     ooOOOOOOOOOOOOOOOOOOOOOOOOOOOO       ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS      ccCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC   iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  llLLLLLLLLLL                            llLLLLLLLLLL                                      aaAAAAAAAAAAAAAAAA            ttTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT  iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII      ooOOOOOOOOOOOOOOOOOOOOOOOOOOOO      nnNNNNNNNNNNNN        nnNNNNNNNNNN   \ 
| |  ooOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO   ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS  ccCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC   iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  llLLLLLLLLLL                            llLLLLLLLLLL                                     aaAAAAAAAAAAAAAAAAAA           ttTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT  iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  ooOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO  nnNNNNNNNNNNNN        nnNNNNNNNNNN    |
| |  ooOOOOOOOOOOOO           ooOOOOOOOOOOOO  ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS   ccCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC    iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  llLLLLLLLLLL                            llLLLLLLLLLL                                     aaAAAAAAAAAAAAAAAAAA           ttTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT  iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  ooOOOOOOOOOOOO          ooOOOOOOOOOOOO  nnNNNNNNNNNNNNNN      nnNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO  ssSSSSSSSSS                            ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                    aaAAAAAAAAAAAAAAAAAAAA                       ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNNNNNN      nnNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO  ssSSSSSSSSS                            ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                    aaAAAAAAAAAAAAAAAAAAAA                       ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNNNNNNNN    nnNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO  ssSSSSSSSSS                            ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                   aaAAAAAAAAAAaaAAAAAAAAAA                      ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNNNNNNNN    nnNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO  ssSSSSSSSSS                            ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                   aaAAAAAAAAAAaaAAAAAAAAAA                      ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNNNNNNNNNN  nnNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO  ssSSSSSSSSS                            ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                  aaAAAAAAAAAA  aaAAAAAAAAAA                     ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNNNNNNNNNN  nnNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO  ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS   ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                  aaAAAAAAAAAA  aaAAAAAAAAAA                     ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNNNNNNNNNNNNnnNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO  ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                 aaAAAAAAAAAA    aaAAAAAAAAAA                    ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNNnnNNNNNNNNNNNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO  ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                 aaAAAAAAAAAA    aaAAAAAAAAAA                    ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNNnnNNNNNNNNNNNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO    ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                aaAAAAAAAAAAAAAAAAAAAAAAAAAAAA                   ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNN  nnNNNNNNNNNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO                             ssSSSSSSSSS ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                aaAAAAAAAAAAAAAAAAAAAAAAAAAAAA                   ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNN  nnNNNNNNNNNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO                             ssSSSSSSSSS ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                               aaAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA                  ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNN    nnNNNNNNNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO                             ssSSSSSSSSS ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                               aaAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA                  ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNN    nnNNNNNNNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO                             ssSSSSSSSSS ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                              aaAAAAAAAAAA          aaAAAAAAAAAA                 ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNN      nnNNNNNNNNNNNNNN    |
| |  ooOOOOOOOOOOOO           ooOOOOOOOOOOOO    ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS ccCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC    iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  llLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL  llLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL    aaAAAAAAAAAA          aaAAAAAAAAAA                 ttTTTTTTTTTT               iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  ooOOOOOOOOOOOO          ooOOOOOOOOOOOO  nnNNNNNNNNNN      nnNNNNNNNNNNNNNN    |
| |  ooOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO  ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS  ccCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC   iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  llLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL  llLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL   aaAAAAAAAAAA            aaAAAAAAAAAA                ttTTTTTTTTTT               iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  ooOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO  nnNNNNNNNNNN        nnNNNNNNNNNNNN    |
 \ \     ooOOOOOOOOOOOOOOOOOOOOOOOOOOOO      ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS      ccCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC   iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  llLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL  llLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL   aaAAAAAAAAAA            aaAAAAAAAAAA                ttTTTTTTTTTT               iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII      ooOOOOOOOOOOOOOOOOOOOOOOOOOOOO      nnNNNNNNNNNN        nnNNNNNNNNNNNN    /
  \ \       ooOOOOOOOOOOOOOOOOOOOO             ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS            ccCCCCCCCCCCCCCCCCCCCCCCCCCC    iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  llLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL  llLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL  aaAAAAAAAAAA              aaAAAAAAAAAA               ttTTTTTTTTTT               iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII          ooOOOOOOOOOOOOOOOOOOOO          nnNNNNNNNNNN          nnNNNNNNNNNN   /
   \_\___________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________/
*/
using System;
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
                if (type == "npc")
                {
                    color.A -= 1;
                    color.R -= 1;
                }
                if (type == "player")
                {
                    color.A -= 5;
                    color.R -= 5;
                    color.G -= 5;
                    color.B -= 5;
                }
                if (type == "regen")
                {
                    color.A -= 3;
                    color.G -= 3;
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch, Game1 game)
        {
            if (type != "regen")
            {
                spriteBatch.DrawString(Game1.spriteFont, damageString, position, color);
            }
            else
            {
                spriteBatch.DrawString(Game1.spriteFont, "+" + damageString, position, color);
            }
        }
    }
}