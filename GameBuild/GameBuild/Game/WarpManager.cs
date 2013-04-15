using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Microsoft.Xna.Framework.Graphics;

namespace GameBuild.Game
{
    public class WarpManager
    {
        List<WarpItem> warps;
        int warpFileCount;//number of files in folder
        string[] warpFiles;//file names

        public WarpManager()
        {
            warpFileCount = Directory.GetFiles(@"Content\Warp\").Length;
            warps = new List<WarpItem>();
        }

        public void UpdateList(string mapName)
        {
            warps.Clear();
            warpFiles = new string[warpFileCount];//initialize the string[] with the amount of files
            for (int i = 0; i < warpFileCount; i++)//add a warp item for every file
            {
                warpFiles[i] = Directory.GetFiles(@"Content\Warp\")[i];
                StreamReader reader = new StreamReader(warpFiles[i]);
                WarpItem w = new WarpItem(reader.ReadLine(), int.Parse(reader.ReadLine()), int.Parse(reader.ReadLine()), int.Parse(reader.ReadLine()),
                    int.Parse(reader.ReadLine()), reader.ReadLine(), int.Parse(reader.ReadLine()), int.Parse(reader.ReadLine()), reader.ReadLine());
                reader.Close();
                Console.WriteLine(w.sourceMap);
                if (w.sourceMap == mapName.Remove(mapName.Length-1))
                {
                    warps.Add(w);
                    Console.WriteLine("Added warp mofo");
                }
            }
        }

        public void Warp(WarpItem warp, string key, int targetX, int targetY, string map, Game1 game)//the key to unlock the door, targeted x coordinate, targeted y coordinate, targeted map
        {
            for (int x = 0; x < Game1.character.inventory.width; x++)//player inventory slots
            {
                for (int y = 0; y < Game1.character.inventory.height; y++)
                {
                    if (Game1.character.inventory.inventorySlot[x, y].item == key || key == ".")//checks if the player has the key or if the key is ".", aka no key required
                    {
                        Game1.map = game.Content.Load<H_Map.TileMap>(@"Map\" + map);
                        Game1.map.tileset = game.Content.Load<Texture2D>(@"Game\tileset");
                        if (warp.targetX != -1)//warp the X value if it isnt -1(tha player's X value)
                        {
                            Game1.character.position.X = warp.targetX;
                        }
                        if (warp.targetY != -1)//warp the Y value if it isnt -1(tha player's Y value)
                        {
                            Game1.character.position.Y = warp.targetY;
                        }
                        UpdateList(Game1.map.mapName);
                        break;
                    }
                    else
                    {
                        //show locked message
                        break;
                    }
                }
            }
        }

        public void Update(Game1 game)
        {
            for (int i = 0; i < warps.Count; i++)
            {
                if (Game1.character.attackRectangle.Intersects(warps[i].warpField))
                {
                    Warp(warps[i], warps[i].key, warps[i].targetX, warps[i].targetY, warps[i].targetMap, game);
                }
            }
        }

        public void Draw(SpriteBatch s)
        {

        }
    }
}