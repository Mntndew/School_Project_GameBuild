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
        int width = 10, height = 3;
        int spacing = 5;
        int size = 3;
        bool movedRight;
        bool movedDown;

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
            inventorySlot[0, 0].selected = true;
        }

        public void Update(Game1 game, GameTime gameTime)
        {
            if (game.keyState.IsKeyDown(Keys.Left) && game.oldState.IsKeyUp(Keys.Left))
            {
                for (int x = 0; x < width; x++)
                {
                    for (int y = 0; y < height; y++)
                    {
                        if (inventorySlot[x, y].selected && x - 1 > -1)
                        {
                            inventorySlot[x - 1, y].selected = true;
                            inventorySlot[x, y].selected = false;
                        }
                    }
                }
            }
            if (game.keyState.IsKeyDown(Keys.Up) && game.oldState.IsKeyUp(Keys.Up))
            {
                for (int x = 0; x < width; x++)
                {
                    for (int y = 0; y < height; y++)
                    {
                        if (inventorySlot[x, y].selected && y - 1 > -1)
                        {
                            inventorySlot[x, y - 1].selected = true;
                            inventorySlot[x, y].selected = false;
                        }
                    }
                }
            }
            if (game.keyState.IsKeyDown(Keys.Right) && game.oldState.IsKeyUp(Keys.Right))
            {
                for (int x = 0; x < width; x++)
                {
                    for (int y = 0; y < height; y++)
                    {
                        if (inventorySlot[x, y].selected && x + 1 < width)
                        {
                            if (!movedRight)
                            {
                                inventorySlot[x + 1, y].selected = true;
                                inventorySlot[x, y].selected = false;
                                movedRight = true;
                            }
                        }
                    }
                }
            }
            if (game.keyState.IsKeyUp(Keys.Right))
            {
                movedRight = false;
            }
            if (game.keyState.IsKeyDown(Keys.Down) && game.oldState.IsKeyUp(Keys.Down))
            {
                for (int x = 0; x < width; x++)
                {
                    for (int y = 0; y < height; y++)
                    {
                        if (inventorySlot[x, y].selected && y + 1 < height)
                        {
                            if (!movedDown)
                            {
                                inventorySlot[x, y + 1].selected = true;
                                inventorySlot[x, y].selected = false;
                                movedDown = true;
                            }
                        }
                    }
                }
            }
            if (game.keyState.IsKeyUp(Keys.Down))
            {
                movedDown = false;
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