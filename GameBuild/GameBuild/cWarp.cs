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
        int files = Directory.GetFiles(@"Content\warp\").Length;

        string[] warp;
        string sourceMap;
        string targetMap;

        int targetX;
        int targetY;

        Rectangle warpField;

        StreamReader reader;

        public cWarp()
        {
            warp = new string[files];
            for (int i = 0; i < files; i++)
            {
                warp[i] = Directory.GetFiles(@"Content\warp\")[i];
                reader = new StreamReader(warp[i]);
                warpField = new Rectangle();
                sourceMap = reader.ReadLine();
                warpField.X = int.Parse(reader.ReadLine());
                warpField.Y = int.Parse(reader.ReadLine());
                warpField.Width = int.Parse(reader.ReadLine());
                warpField.Height = int.Parse(reader.ReadLine());
                targetMap = reader.ReadLine();
                targetX = int.Parse(reader.ReadLine());
                targetY = int.Parse(reader.ReadLine());
                reader.Close();
            }
        }

        public void Update(cCharacter player, Game1 game)
        {
            if (player.position.Intersects(warpField))
            {
                game.map = game.Content.Load<H_Map.TileMap>(targetMap);
                game.map.tileset = game.Content.Load<Texture2D>("tileset");
                player.position.X = targetX;
                player.position.Y = targetY;
            }
        }
    }
}
