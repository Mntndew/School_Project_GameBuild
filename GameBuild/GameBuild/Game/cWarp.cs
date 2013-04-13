using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using System.IO;
using Microsoft.Xna.Framework.Graphics;

namespace GameBuild
{
    class cWarp
    {
        public string sourceMap;
        string targetMap;
        string key;

        public bool isOnMap;
        public bool doneEffect;
        public static bool canWalk = true;
        public bool addAlpha = true;

        int targetX;
        int targetY;
        int fileTargetX;
        int fileTargetY;

        Rectangle warpField;

        cDialogue lockedDialogue;

        bool hasShowedLockedMessage = false;

        public cWarp(string sourceMap, int sourceX, int sourceY, int width, int height, string targetMap, int targetX, int targetY, string key, Game1 game)
        {
            this.sourceMap = sourceMap;
            this.targetMap = targetMap;
            this.key = key;

            fileTargetX = targetX;
            fileTargetY = targetY;

            warpField = new Rectangle(sourceX, sourceY, width, height);
            lockedDialogue = new cDialogue(null, game.textBox, game, game.spriteFont, "doorLocked", "Door");
        }

        public void CheckMap(Game1 game)
        {
            if (sourceMap == (Game1.map.mapName.Remove(Game1.map.mapName.Length - 1)))
            {
                isOnMap = true;
            }
            else
                isOnMap = false;
        }

        public void Update(cCharacter player, Game1 game)
        {
            if (lockedDialogue.isTalking)
            {
                lockedDialogue.Update();
                if (lockedDialogue.isTalking == false)
                {
                    game.currentGameState = Game1.GameState.PLAY;
                }
            }
            if (targetX != -1)
            {
                targetX = fileTargetX;
            }
            else
                this.targetX = player.position.X;

            if (targetY != -1)
            {
                targetY = fileTargetY;
            }
            else
                this.targetY = player.position.Y;
            
            if (player.attackRectangle.Intersects(warpField))
            {
                bool hasKey = false;
                for (int x = 0; x < player.inventory.width; x++)
                {
                    for (int y = 0; y < player.inventory.height; y++)
                    {
                        if (player.inventory.inventorySlot[x, y].item == key)
                        {
                            Effect(game);
                            if (doneEffect)
                            {
                                if (player.position.X < warpField.X)
                                {
                                    if (targetX != -1)
                                    {
                                        targetX += 2;
                                    }
                                }
                                Game1.map = game.Content.Load<H_Map.TileMap>(@"Map\" + targetMap);
                                Game1.map.tileset = game.Content.Load<Texture2D>(@"Game\tileset");
                                if (targetX != -1)
                                {
                                    player.position.X = targetX;
                                }
                                if (targetY != -1)
                                {
                                    player.position.Y = targetY;
                                }
                                addAlpha = true;
                                canWalk = true;
                            }
                        }
                    }
                }
                if (!hasKey && !hasShowedLockedMessage)
                {
                    game.currentGameState = Game1.GameState.INTERACT;
                    lockedDialogue.isTalking = true;
                    hasShowedLockedMessage = true;
                }
            }
            else
            {
                hasShowedLockedMessage = false;
            }
        }

        public void Effect(Game1 game)
        {
            doneEffect = false;
            canWalk = false;
            if (addAlpha)
            {
                game.screenColor.A += 6;
            }
            if (game.screenColor.A >= 252)
            {
                addAlpha = false;
            }
            if (!addAlpha)
            {
                game.screenColor.A -= 18;
            }
            if (!addAlpha && game.screenColor.A == 0)
            {
                doneEffect = true;
            }
        }

        public void Draw(SpriteBatch spriteBatch, Game1 game)
        {
            if (isOnMap)
            {
                spriteBatch.Draw(game.collisionTex, warpField, new Color(200, 50, 200, 200));
            }
            spriteBatch.Draw(game.screenTexture, game.screen, game.screenColor);
            lockedDialogue.Draw(spriteBatch);
        }
    }
}