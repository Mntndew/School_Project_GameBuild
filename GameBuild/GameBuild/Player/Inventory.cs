using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace GameBuild
{
    public class Inventory
    {
        public InventorySlot[,] inventorySlot;
        public int width = 1, height = 6;
        int spacing = 5;
        int size = 3;

        public Inventory(Game1 game)
        {
            inventorySlot = new InventorySlot[width, height];
            spacing *= 8;
            size *= 16;
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
                    inventorySlot[x, y].position = new Rectangle(10 + (x * (10 + spacing)), 10 + (y * (10 + spacing)), size, size);
                }
            }
        }

        public void RemoveItem(string item)
        {
            Console.WriteLine(item);
            for (int y = 0; y < height; y++)
            {
                if (inventorySlot[0, y].item == item)
                {
                    inventorySlot[0, y].item = null;
                    inventorySlot[0, y].itemTexture = null;
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch, Game1 game)
        {
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    inventorySlot[x, y].Draw(spriteBatch, game);
                }
            }
        }
    }
}