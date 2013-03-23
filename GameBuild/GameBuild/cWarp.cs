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

        Rectangle warpField;

        public cWarp(string sourceMap, int sourceX, int sourceY, int width, int height, string targetMap, int targetX, int targetY,
            cCharacter player, Game1 game)
        {
            this.sourceMap = sourceMap;
            this.targetMap = targetMap;

            if (sourceMap == (game.map.mapName.Remove(game.map.mapName.Length - 1)))
            {
                isOnMap = true;
            }

            if (targetX != -1)
            {
                this.targetX = targetX;
            }
            else
                this.targetX = player.position.X;

            if (targetY != -1)
            {
                this.targetY = targetY;
            }
            else
                this.targetY = player.position.Y;

            warpField = new Rectangle(sourceX, sourceY, width, height);
        }
        
        public void Update(cCharacter player, Game1 game)
        {
            Console.WriteLine();
            Console.WriteLine("Loaded map: " + game.map.mapName.Remove(game.map.mapName.Length - 1));
            Console.WriteLine();
            Console.WriteLine("Warp source map: " + sourceMap);
            Console.WriteLine("Warp target map: " + targetMap);
            if (sourceMap == (game.map.mapName.Remove(game.map.mapName.Length - 1)))
            {
                isOnMap = true;
            }
            else
                isOnMap = false;

            if (isOnMap)
            {
                if (player.position.Intersects(warpField))
                {
                    game.map = game.Content.Load<H_Map.TileMap>(targetMap);
                    game.map.tileset = game.Content.Load<Texture2D>("tileset");
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