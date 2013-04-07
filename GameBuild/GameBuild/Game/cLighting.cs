using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace GameBuild
{
    class cLighting
    {
        Texture2D lightTexture;
        public Color lightColor;
        Rectangle lightRect;
        List<Rectangle> lanterns = new List<Rectangle>();
        public int difference;
        public int baseAlpha;
        public int alphaChange = 0;
        bool increaseAlpha = true;
        public cLighting(Rectangle LightRect, int Alpha, int Difference, Color color)
        {
            lightRect = LightRect;
            baseAlpha = Alpha;
            difference = Difference;
            lightColor = color;
            lightColor.A = (byte)baseAlpha;
        }

        public void LoadTexture(ContentManager content, string Texture)
        {
            lightTexture = content.Load<Texture2D>(Texture);
        }

        /*
        public void UpdateLanterns()
        {
            lanterns.Clear();
            for (int x = 0; x < map.mapWidth; x++)
            {
                for (int y = 0; y < map.mapHeight; y++)
                {
                    if (map.interactiveLayer[x, y].tileID == 30 || map.interactiveLayer[x, y].tileID == 31 || map.interactiveLayer[x, y].tileID == 32 || map.interactiveLayer[x, y].tileID == 33)
                    {
                        lanterns.Add(new Rectangle((x*map.tileSize) -100 + (map.tileSize/2), (y*map.tileSize)-100 + (map.tileSize/2), 200, 200));
                    }
                }
            }
        }
        */

        public void Update(int x, int y)
        {
            lightRect.X = x-(lightRect.Width/2)+24;
            lightRect.Y = y-(lightRect.Height/2)+24;

            if (increaseAlpha)
            {
                lightColor.A += 2;
                //lightColor.R++;
                if (lightColor.A > baseAlpha + difference)
                {
                    increaseAlpha = false;
                }
            }
            else if (!increaseAlpha)
            {
                lightColor.A -= 2;
                //lightColor.R--;
                if (lightColor.A < baseAlpha - difference)
                {
                    increaseAlpha = true;
                }
            }
            //Console.WriteLine(lightColor.A);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(lightTexture, lightRect, lightColor);
            for (int i = 0; i < lanterns.Count; i++)
            {
                spriteBatch.Draw(lightTexture, lanterns[i], lightColor);
            }
        }
    }
}
