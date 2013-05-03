using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameBuild.Game.Items
{
    public class Ribbon
    {
        public string item;
        public Rectangle position;
        public Texture2D texture;
        public bool added = false;
        public string mapName;
        public ItemLabel label;

        public Ribbon(Rectangle position, string item, Texture2D texture, string mapName, Game1 game)
        {
            this.item = item;
            this.position = position;
            this.mapName = mapName;
            this.texture = texture;
            label = new ItemLabel(new Rectangle(position.X, position.Y - 25, 0, 25), this.item.Length, game);
        }

        public void PickUp(Game1 game)
        {
            for (int x = 0; x < Game1.character.inventory.width; x++)
            {
                for (int y = 0; y < Game1.character.inventory.height; y++)
                {
                    if (Game1.character.inventory.inventorySlot[x, y].item == null && !added)
                    {
                        Game1.character.inventory.inventorySlot[x, y].item = item;
                        Game1.character.inventory.inventorySlot[x, y].itemTexture = texture;
                        added = true;
                    }
                    if (added)
                    {
                        break;
                    }
                }
            }
        }

        public bool IsOnMap()
        {
            if (mapName == Game1.map.mapName.Remove(Game1.map.mapName.Length - 1))
            {
                return true;
            }
            else
                return false;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);
        }

        public void DrawLabel(SpriteBatch spriteBatch)
        {
            label.Draw(spriteBatch);
        }
    }
}
