using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameBuild
{
    public class Key
    {
        string key;
        public Rectangle position;
        public Texture2D texture;
        bool added = false;
        public string mapName;

        public Key(Rectangle position, string key, string mapName, Game1 game)
        {
            this.key = key;
            this.position = position;
            this.mapName = mapName;

            if (key == "key 0")
            {
                texture = game.Content.Load<Texture2D>(@"Game\blackness");
            }
            if (key == "key 1")
            {
                texture = game.Content.Load<Texture2D>(@"Game\blackness");
            }
            if (key == "key 2")
            {
                texture = game.Content.Load<Texture2D>(@"Game\blackness");
            }
        }

        public void PickUp(cCharacter player)
        {
            for (int x = 0; x < player.inventory.width; x++)
            {
                for (int y = 0; y < player.inventory.height; y++)
                {
                    if (player.inventory.inventorySlot[x, y].item == null && !added)
                    {
                        player.inventory.inventorySlot[x, y].item = key;
                        player.inventory.inventorySlot[x, y].texture = texture;
                        added = true;
                    }
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);
        }
    }
}