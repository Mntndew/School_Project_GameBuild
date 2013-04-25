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
        public bool added = false;
        public string mapName;

        public Key(Rectangle position, string key, Texture2D texture, string mapName, Game1 game)
        {
            this.key = key;
            this.position = position;
            this.mapName = mapName;
            this.texture = texture;
        }

        void ExitedDialogue(object sender, DialogueEventArgs e)
        {
            Game1.currentGameState = Game1.GameState.PLAY;
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
                        player.inventory.inventorySlot[x, y].itemTexture = texture;
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