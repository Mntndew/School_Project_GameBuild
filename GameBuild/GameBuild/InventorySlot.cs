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

        public InventorySlot(Game1 game)
        {
            texture = game.Content.Load<Texture2D>("emptySlot");
        }

        public void Draw(SpriteBatch spriteBatch, Game1 game)
        {
            if (game.character.showInventory)
            {
                spriteBatch.Draw(texture, position, new Color(150, 150, 150, 200));
            }
        }
    }
}
