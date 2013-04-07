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

        public cWarp(string sourceMap, int sourceX, int sourceY, int width, int height, string targetMap, int targetX, int targetY, Game1 game)
        {
            this.sourceMap = sourceMap;
            this.targetMap = targetMap;

            fileTargetX = targetX;
            fileTargetY = targetY;

            warpField = new Rectangle(sourceX, sourceY, width, height);
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
                Effect(game);
                if (doneEffect)
                {
                    Game1.map = game.Content.Load<H_Map.TileMap>(targetMap);
                    Game1.map.tileset = game.Content.Load<Texture2D>("tileset");
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
                //spriteBatch.Draw(game.collisionTex, warpField, new Color(200, 50, 200, 200));
            }
            spriteBatch.Draw(game.screenTexture, game.screen, game.screenColor);
        }
    }
}