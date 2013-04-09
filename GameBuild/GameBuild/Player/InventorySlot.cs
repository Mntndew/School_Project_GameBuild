using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameBuild
{
    public class InventorySlot
    {
        public Rectangle position;
        public Texture2D texture;
        public string item;
        public bool selected = true;

        public InventorySlot(Game1 game)
        {
            texture = game.Content.Load<Texture2D>(@"Player\emptySlot");
        }

        public void Draw(SpriteBatch spriteBatch, Game1 game)
        {
            if (Game1.character.showInventory)
            {
                if (!selected)
                {
                    spriteBatch.Draw(texture, position, new Color(50, 50, 50, 200));
                }
                if (selected)
                {
                    spriteBatch.Draw(texture, position, Color.White);
                }
            }
        }
    }
}