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

        public bool isOnMap;
        public bool doneEffect;
        public static bool canWalk = true;
        public bool addAlpha = true;

        int targetX;
        int targetY;
        int fileTargetX;
        int fileTargetY;

        Rectangle warpField;

        Rectangle screen;
        Texture2D effectTexture;
        Color effectColor;

        public cWarp(string sourceMap, int sourceX, int sourceY, int width, int height, string targetMap, int targetX, int targetY, Game1 game)
        {
            this.sourceMap = sourceMap;
            this.targetMap = targetMap;

            fileTargetX = targetX;
            fileTargetY = targetY;

            warpField = new Rectangle(sourceX, sourceY, width, height);
            screen = new Rectangle(0, 0, game.graphics.PreferredBackBufferWidth, game.graphics.PreferredBackBufferHeight);

            effectTexture = game.Content.Load<Texture2D>("blackness");

            effectColor = new Color(0, 0, 0, 0);
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
            //Console.WriteLine();
            //Console.WriteLine("Loaded map: " + game.map.mapName.Remove(game.map.mapName.Length - 1));
            //Console.WriteLine();
            //Console.WriteLine("Warp source map: " + sourceMap);
            //Console.WriteLine("Warp target map: " + targetMap);
            //Console.WriteLine();
            //Console.WriteLine("X: " + player.position.X);
            //Console.WriteLine("Y: " + player.position.Y);

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

            if (player.position.Intersects(warpField))
            {
                Effect();
                if (doneEffect)
                {
                    Game1.map = game.Content.Load<H_Map.TileMap>(targetMap);
                    Game1.map.tileset = game.Content.Load<Texture2D>("tileset");
                    for (int i = 0; i < game.Npcs.Count; i++)
                    {
                        if (!game.Npcs[i].hasBeenAdded)
                        {
                            game.UpdateActiveNpcs();
                        }
                    }
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

        public void Effect()
        {
            doneEffect = false;
            canWalk = false;
            if (addAlpha)
            {
                effectColor.A += 6;
            }
            if (effectColor.A >= 252)
            {
                addAlpha = false;
            }
            if (!addAlpha)
            {
                effectColor.A -= 18;
            }
            if (!addAlpha && effectColor.A == 0)
            {
                doneEffect = true;
            }
        }

        public void Draw(SpriteBatch spriteBatch, Game1 game)
        {
            if (isOnMap)
            {
                //spriteBatch.Draw(game.collisionTex, warpField, new Color(200, 50, 200, 200));
            }
            spriteBatch.Draw(effectTexture, screen, effectColor);
        }
    }
}