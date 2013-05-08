/*
    ____________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________
   / /                                                                                                                                                                                                                                                                                                                                                                                                                                                  \
  / /        ooOOOOOOOOOOOOOOOOOOOO            ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS            ccCCCCCCCCCCCCCCCCCCCCCCCCCC    iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  llLLLLLLLLLL                            llLLLLLLLLLL                                      aaAAAAAAAAAAAAAAAA            ttTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT  iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII          ooOOOOOOOOOOOOOOOOOOOO          nnNNNNNNNNNN          nnNNNNNNNNNN  \
 / /     ooOOOOOOOOOOOOOOOOOOOOOOOOOOOO       ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS      ccCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC   iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  llLLLLLLLLLL                            llLLLLLLLLLL                                      aaAAAAAAAAAAAAAAAA            ttTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT  iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII      ooOOOOOOOOOOOOOOOOOOOOOOOOOOOO      nnNNNNNNNNNNNN        nnNNNNNNNNNN   \ 
| |  ooOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO   ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS  ccCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC   iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  llLLLLLLLLLL                            llLLLLLLLLLL                                     aaAAAAAAAAAAAAAAAAAA           ttTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT  iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  ooOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO  nnNNNNNNNNNNNN        nnNNNNNNNNNN    |
| |  ooOOOOOOOOOOOO           ooOOOOOOOOOOOO  ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS   ccCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC    iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  llLLLLLLLLLL                            llLLLLLLLLLL                                     aaAAAAAAAAAAAAAAAAAA           ttTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT  iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  ooOOOOOOOOOOOO          ooOOOOOOOOOOOO  nnNNNNNNNNNNNNNN      nnNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO  ssSSSSSSSSS                            ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                    aaAAAAAAAAAAAAAAAAAAAA                       ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNNNNNN      nnNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO  ssSSSSSSSSS                            ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                    aaAAAAAAAAAAAAAAAAAAAA                       ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNNNNNNNN    nnNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO  ssSSSSSSSSS                            ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                   aaAAAAAAAAAAaaAAAAAAAAAA                      ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNNNNNNNN    nnNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO  ssSSSSSSSSS                            ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                   aaAAAAAAAAAAaaAAAAAAAAAA                      ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNNNNNNNNNN  nnNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO  ssSSSSSSSSS                            ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                  aaAAAAAAAAAA  aaAAAAAAAAAA                     ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNNNNNNNNNN  nnNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO  ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS   ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                  aaAAAAAAAAAA  aaAAAAAAAAAA                     ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNNNNNNNNNNNNnnNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO  ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                 aaAAAAAAAAAA    aaAAAAAAAAAA                    ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNNnnNNNNNNNNNNNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO  ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                 aaAAAAAAAAAA    aaAAAAAAAAAA                    ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNNnnNNNNNNNNNNNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO    ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                aaAAAAAAAAAAAAAAAAAAAAAAAAAAAA                   ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNN  nnNNNNNNNNNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO                             ssSSSSSSSSS ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                aaAAAAAAAAAAAAAAAAAAAAAAAAAAAA                   ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNN  nnNNNNNNNNNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO                             ssSSSSSSSSS ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                               aaAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA                  ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNN    nnNNNNNNNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO                             ssSSSSSSSSS ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                               aaAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA                  ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNN    nnNNNNNNNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO                             ssSSSSSSSSS ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                              aaAAAAAAAAAA          aaAAAAAAAAAA                 ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNN      nnNNNNNNNNNNNNNN    |
| |  ooOOOOOOOOOOOO           ooOOOOOOOOOOOO    ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS ccCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC    iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  llLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL  llLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL    aaAAAAAAAAAA          aaAAAAAAAAAA                 ttTTTTTTTTTT               iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  ooOOOOOOOOOOOO          ooOOOOOOOOOOOO  nnNNNNNNNNNN      nnNNNNNNNNNNNNNN    |
| |  ooOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO  ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS  ccCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC   iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  llLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL  llLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL   aaAAAAAAAAAA            aaAAAAAAAAAA                ttTTTTTTTTTT               iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  ooOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO  nnNNNNNNNNNN        nnNNNNNNNNNNNN    |
 \ \     ooOOOOOOOOOOOOOOOOOOOOOOOOOOOO      ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS      ccCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC   iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  llLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL  llLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL   aaAAAAAAAAAA            aaAAAAAAAAAA                ttTTTTTTTTTT               iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII      ooOOOOOOOOOOOOOOOOOOOOOOOOOOOO      nnNNNNNNNNNN        nnNNNNNNNNNNNN    /
  \ \       ooOOOOOOOOOOOOOOOOOOOO             ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS            ccCCCCCCCCCCCCCCCCCCCCCCCCCC    iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  llLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL  llLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL  aaAAAAAAAAAA              aaAAAAAAAAAA               ttTTTTTTTTTT               iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII          ooOOOOOOOOOOOOOOOOOOOO          nnNNNNNNNNNN          nnNNNNNNNNNN   /
   \_\___________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________/
*/
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

        Dialogue dialogue;
        bool showedLocked = false;
        bool hasKey;

        public WarpManager(Game1 game)
        {
            warpFileCount = Directory.GetFiles(@"Content\Warp\").Length;
            warps = new List<WarpItem>();
            dialogue = new Dialogue(null, Game1.textBox, game, Game1.spriteFont, "doorLocked", "Door");
            dialogue.dialogueManager.ReachedExit += new ExitEventHandler(ExitedDialogue);
        }

        void ExitedDialogue(object sender, DialogueEventArgs e)
        {
            Game1.currentGameState = Game1.GameState.PLAY;
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
                    hasKey = true;
                    Game1.map = game.Content.Load<H_Map.TileMap>(@"Map\" + map);
                    Game1.map.tileset = game.Content.Load<Texture2D>(@"Game\tileset");
                    game.UpdateActiveNpcs();
                    if (warp.targetX != -1)//warp the X value if it isnt -1(the player's X value)
                    {
                        Game1.character.position.X = warp.targetX;
                    }
                    if (warp.targetY != -1)//warp the Y value if it isnt -1(the player's Y value)
                    {
                        Game1.character.position.Y = warp.targetY;
                    }

                    #region story stuff
                    if (map == "Map4_C")
                    {
                        for (int i = 0; i < game.Npcs.Count; i++)
                        {
                            if (game.Npcs[i].name == "Ziva")
                            {
                                if (game.Npcs[i].health > 0)
                                {
                                    game.Npcs[i].isInteracting = true;
                                    game.Npcs[i].dialogue.isTalking = true;
                                    Game1.currentGameState = Game1.GameState.INTERACT;
                                }
                            }
                        }
                    }
                    else if (map == "Map3_B")
                    {
                        for (int i = 0; i < game.Npcs.Count; i++)
                        {
                            if (game.Npcs[i].name == "Headmaster")
                            {
                                game.Npcs[i].mapName = map;
                            }
                            if (game.Npcs[i].name == "Celine")
                            {
                                game.Npcs[i].position.X = 1625;
                                game.Npcs[i].position.Y = 1521;
                                game.Npcs[i].mapName = map;
                            }
                        }
                    }
                    else if (map == "Map4_B")
                    {
                        Game1.character.waypointManager = new Player.CharacterWaypointManager(Game1.character.position, map, 3);
                        for (int i = 0; i < game.Npcs.Count; i++)
                        {
                            if (game.Npcs[i].name == "Celine")
                            {
                                game.Npcs[i].mapName = map;
                                game.Npcs[i].position.X = 834;
                                game.Npcs[i].position.Y = 711;
                                game.Npcs[i].left = true;
                                game.Npcs[i].right = false;
                                game.Npcs[i].up = false;
                                game.Npcs[i].down = false;
                                game.Npcs[i].MoveLeft(ref game.Npcs[i].position);
                                game.Npcs[i].animation.LoopAnimation(7);
                            }
                            if (game.Npcs[i].name == "Laune")
                            {
                                game.Npcs[i].mapName = map;
                                game.Npcs[i].position.X = 834;
                                game.Npcs[i].position.Y = 793;
                                game.Npcs[i].left = true;
                                game.Npcs[i].right = false;
                                game.Npcs[i].up = false;
                                game.Npcs[i].down = false;
                                game.Npcs[i].MoveLeft(ref game.Npcs[i].position);
                                game.Npcs[i].animation.LoopAnimation(9);
                            }
                            if (game.Npcs[i].name == "Melitta")
                            {
                                game.Npcs[i].mapName = map;
                                game.Npcs[i].position.X = 834;
                                game.Npcs[i].position.Y = 867;
                                game.Npcs[i].left = true;
                                game.Npcs[i].right = false;
                                game.Npcs[i].up = false;
                                game.Npcs[i].down = false;
                                game.Npcs[i].MoveLeft(ref game.Npcs[i].position);
                                game.Npcs[i].animation.LoopAnimation(7);
                            }
                            if (game.Npcs[i].name == "Sylian")
                            {
                                game.Npcs[i].mapName = map;
                                game.Npcs[i].position.X = 834;
                                game.Npcs[i].position.Y = 948;
                                game.Npcs[i].left = true;
                                game.Npcs[i].right = false;
                                game.Npcs[i].up = false;
                                game.Npcs[i].down = false;
                                game.Npcs[i].MoveLeft(ref game.Npcs[i].position);
                                game.Npcs[i].animation.LoopAnimation(7);
                            }
                            if (game.Npcs[i].name == "Ziva")
                            {
                                game.Npcs[i].mapName = map;
                                game.Npcs[i].position.X = 834;
                                game.Npcs[i].position.Y = 1029;
                                game.Npcs[i].left = true;
                                game.Npcs[i].right = false;
                                game.Npcs[i].up = false;
                                game.Npcs[i].down = false;
                                game.Npcs[i].MoveLeft(ref game.Npcs[i].position);
                                game.Npcs[i].animation.LoopAnimation(7);
                            }
                            game.Npcs[i].vulnerable = false;
                        }
                    }
                    #endregion
                }
            }
            if (!hasKey)
            {
                if (!showedLocked)
                {
                    dialogue.isTalking = true;
                    showedLocked = true;
                    Game1.currentGameState = Game1.GameState.INTERACT;
                    Vector2 dir = new Vector2(warp.warpField.X, warp.warpField.Y) - Game1.character.position;
                    dir.Normalize();
                    dir *= -1;
                    Game1.character.Push(dir, 3);
                }
            }
        }

        public void Update(Game1 game, GameTime gameTime)
        {
            UpdateList(Game1.map.mapName);
            bool intersect = false;
            for (int i = 0; i < warps.Count; i++)
            {
                if (Game1.character.warpRectangle.Intersects(warps[i].warpField))
                {
                    Warp(warps[i], warps[i].key, warps[i].targetX, warps[i].targetY, warps[i].targetMap, game, gameTime);
                    intersect = true;
                }
            }
            if (!intersect)
            {
                showedLocked = false;
            }
            dialogue.Update();
        }

        public void Draw(SpriteBatch spriteBatch, Game1 game)
        {
            for (int i = 0; i < warps.Count; i++)
            {
                spriteBatch.Draw(game.screenTexture, warps[i].warpField, new Color(100, 100, 100, 100));
                spriteBatch.DrawString(Game1.spriteFont, warps[i].targetMap, new Vector2(warps[i].warpField.X, warps[i].warpField.Y), Color.Red);
            }

            dialogue.Draw(spriteBatch);
        }
    }
}