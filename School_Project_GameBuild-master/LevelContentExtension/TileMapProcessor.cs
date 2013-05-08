using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content.Pipeline;
using Microsoft.Xna.Framework.Content.Pipeline.Graphics;
using Microsoft.Xna.Framework.Content.Pipeline.Processors;

// TODO: replace these with the processor input and output types.
using TInput = System.String;
using TOutput = H_Map.TileMap;

namespace LevelContentExtension
{
    /// <summary>
    /// This class will be instantiated by the XNA Framework Content Pipeline
    /// to apply custom processing to content data, converting an object of
    /// type TInput to TOutput. The input and output types may be the same if
    /// the processor wishes to alter data without changing its type.
    ///
    /// This should be part of a Content Pipeline Extension Library project.
    ///
    /// TODO: change the ContentProcessor attribute to specify the correct
    /// display name for this processor.
    /// </summary>
    [ContentProcessor(DisplayName = "TileMapProcessor")]
    public class TileMapProcessor : ContentProcessor<TInput, TOutput>
    {
        public override TOutput Process(TInput input, ContentProcessorContext context)
        {
            string[] lines = input.Split('\n');

            string mapName = lines[0];
            int mapWidth = Convert.ToInt32(lines[1]);
            int mapHeight = Convert.ToInt32(lines[2]);
            int tileWidth = Convert.ToInt32(lines[3]);
            int tileHeight = Convert.ToInt32(lines[4]);
            int tilesetWidth = Convert.ToInt32(lines[5]);

            int[,] background = new int[mapWidth, mapHeight];
            for (int y = 0; y < mapHeight; y++)
            {
                string[] values = lines[y + 7].Split(',');
                for (int x = 0; x < mapWidth; x++)
                {
                    background[x, y] = Convert.ToInt32(values[x]);
                }
            }
            int[,] interactive = new int[mapWidth, mapHeight];
            for (int y = 0; y < mapHeight; y++)
            {
                string[] values = lines[mapHeight + y + 7 + 1].Split(',');
                for (int x = 0; x < mapWidth; x++)
                {
                    interactive[x, y] = Convert.ToInt32(values[x]);
                }
            }
            int[,] foreground = new int[mapWidth, mapHeight];
            for (int y = 0; y < mapHeight; y++)
            {
                string[] values = lines[mapHeight + mapHeight + y + 7 + 2].Split(',');
                for (int x = 0; x < mapWidth; x++)
                {
                    foreground[x, y] = Convert.ToInt32(values[x]);
                }
            }
            return new H_Map.TileMap(background, interactive, foreground, tileWidth, tileHeight, mapWidth, mapHeight, tilesetWidth, mapName);
        }
    }
}