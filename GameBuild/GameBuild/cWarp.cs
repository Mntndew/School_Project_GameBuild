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

        int targetX;
        int targetY;
        int fileTargetX;
        int fileTargetY;

        Rectangle warpField;

        public cWarp(string sourceMap, int sourceX, int sourceY, int width, int height, string targetMap, int targetX, int targetY)
        {
            this.sourceMap = sourceMap;
            this.targetMap = targetMap;

            fileTargetX = targetX;
            fileTargetY = targetY;

            warpField = new Rectangle(sourceX, sourceY, width, height);
        }

        public void CheckMap(Game1 game)
        {
            if (sourceMap == (game.map.mapName.Remove(game.map.mapName.Length - 1)))
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
                game.map = game.Content.Load<H_Map.TileMap>(targetMap);
                game.map.tileset = game.Content.Load<Texture2D>("tileset");

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
            }
        }

        public void Draw(SpriteBatch spriteBatch, Game1 game)
        {
            if (isOnMap)
            {
                spriteBatch.Draw(game.collisionTex, warpField, new Color(200, 50, 200, 200));
            }
        }
    }
}