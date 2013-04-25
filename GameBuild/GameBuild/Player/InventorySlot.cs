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
        public Texture2D itemTexture;
        public string item;

        public InventorySlot(Game1 game)
        {
            texture = game.Content.Load<Texture2D>(@"Player\emptySlot");
        }

        public void Draw(SpriteBatch spriteBatch, Game1 game)
        {
            if (Game1.character.showInventory)
            {
                spriteBatch.Draw(texture, position, Color.White);
                if (itemTexture != null)
                {
                    spriteBatch.Draw(itemTexture, new Rectangle(position.Center.X - itemTexture.Width / 2, position.Center.Y - itemTexture.Height / 2, itemTexture.Width, itemTexture.Height), Color.White);
                }
            }
        }
    }
}