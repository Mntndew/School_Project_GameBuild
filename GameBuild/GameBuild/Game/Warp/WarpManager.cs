using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

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
                WarpItem warp = new WarpItem(reader.ReadLine(), int.Parse(reader.ReadLine()), int.Parse(reader.ReadLine()), int.Parse(reader.ReadLine()),
                    int.Parse(reader.ReadLine()), reader.ReadLine(), int.Parse(reader.ReadLine()), int.Parse(reader.ReadLine()), reader.ReadLine());
                reader.Close();
                if (warp.isOnMap)
                {
                    warps.Add(warp);
                }
            }
        }

        public void Warp(WarpItem warp, string key, int targetX, int targetY, string map, Game1 game, GameTime gameTime)//the key to unlock the door, targeted x coordinate, targeted y coordinate, targeted map
        {
            UpdateList(Game1.map.mapName);
            for (int y = 0; y < Game1.character.inventory.height; y++)
            {
                if ((Game1.character.inventory.inventorySlot[0, y].item == key || key == "."))//checks if the player has the key or if the key is ".", aka no key required
                {
                    Game1.map = game.Content.Load<H_Map.TileMap>(@"Map\" + map);
                    Game1.map.tileset = game.Content.Load<Texture2D>(@"Game\tileset");
                    if (warp.targetX != -1)//warp the X value if it isnt -1(the player's X value)
                    {
                        Game1.character.position.X = warp.targetX;
                    }
                    if (warp.targetY != -1)//warp the Y value if it isnt -1(the player's Y value)
                    {
                        Game1.character.position.Y = warp.targetY;
                    }
                    if (map == "Map4_C")
                    {
                        for (int i = 0; i < game.Npcs.Count; i++)
                        {
                            if (game.Npcs[i].name == "Cybot")
                            {
                                game.Npcs[i].isInteracting = true;
                                game.Npcs[i].dialogue.isTalking = true;
                                game.currentGameState = Game1.GameState.INTERACT;
                            }
                        }
                    }
                    if (map == "Map3_B")
                    {
                        for (int i = 0; i < game.Npcs.Count; i++)
                        {
                            if (game.Npcs[i].name == "Headmaster")
                            {
                                game.Npcs[i].mapName = map;
                                game.Npcs[i].position.X = 1800;
                                game.Npcs[i].position.Y = 192;
                                game.Npcs[i].reached = false;
                            }
                            if (game.Npcs[i].name == "Nurse")
                            {
                                game.Npcs[i].mapName = map;
                                game.Npcs[i].position.X = 1800;
                                game.Npcs[i].position.Y = 1248;
                                game.Npcs[i].reached = false;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("locked");
                }
            }
        }

        public void Update(Game1 game, GameTime gameTime)
        {
            UpdateList(Game1.map.mapName);
            for (int i = 0; i < warps.Count; i++)
            {
                if (Game1.character.warpRectangle.Intersects(warps[i].warpField))
                {
                    Warp(warps[i], warps[i].key, warps[i].targetX, warps[i].targetY, warps[i].targetMap, game, gameTime);
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch, Game1 game)
        {
            for (int i = 0; i < warps.Count; i++)
            {
                spriteBatch.Draw(game.screenTexture, warps[i].warpField, new Color(100, 100, 100, 100));
                spriteBatch.DrawString(game.spriteFont, warps[i].targetMap, new Vector2(warps[i].warpField.X, warps[i].warpField.Y), Color.Red);
            }
        }
    }
}