using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace GameBuild
{
    public class Inventory
    {
        public InventorySlot[,] inventorySlot;
        int width = 10, height = 10;

        public Inventory(Game1 game)
        {
            inventorySlot = new InventorySlot[width, height];
            
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    inventorySlot[x, y] = new InventorySlot(game);
                }
            }
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    inventorySlot[x, y].position = new Rectangle(10 + (x * 42), 10 + (y * 42), 32, 32);
                }
            }
            
        }

        public void Draw(SpriteBatch spriteBatch, Game1 game)
        {
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    inventorySlot[x, y].Draw(spriteBatch, game);
                }
            }
        }
    }
}
