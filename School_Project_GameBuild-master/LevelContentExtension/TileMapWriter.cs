using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content.Pipeline;
using Microsoft.Xna.Framework.Content.Pipeline.Graphics;
using Microsoft.Xna.Framework.Content.Pipeline.Processors;
using Microsoft.Xna.Framework.Content.Pipeline.Serialization.Compiler;

// TODO: replace this with the type you want to write out.
using TWrite = H_Map.TileMap;

namespace LevelContentExtension
{
    /// <summary>
    /// This class will be instantiated by the XNA Framework Content Pipeline
    /// to write the specified data type into binary .xnb format.
    ///
    /// This should be part of a Content Pipeline Extension Library project.
    /// </summary>
    [ContentTypeWriter]
    public class TileMapWriter : ContentTypeWriter<TWrite>
    {
        protected override void Write(ContentWriter output, TWrite value)
        {
            output.Write(value.mapName);
            output.Write(value.mapWidth);
            output.Write(value.mapHeight);
            output.Write(value.tileWidth);
            output.Write(value.tileHeight);
            output.Write(value.tilesetWidth);

            for (int x = 0; x < value.mapWidth; x++)
            {
                for (int y = 0; y < value.mapHeight; y++)
                {
                    output.Write(value.backgroundLayer[x,y].tileID);
                }
            }
            for (int x = 0; x < value.mapWidth; x++)
            {
                for (int y = 0; y < value.mapHeight; y++)
                {
                    output.Write(value.interactiveLayer[x, y].tileID);
                }
            }
            for (int x = 0; x < value.mapWidth; x++)
            {
                for (int y = 0; y < value.mapHeight; y++)
                {
                    output.Write(value.foregroundLayer[x, y].tileID);
                }
            }
        }

        public override string GetRuntimeReader(TargetPlatform targetPlatform)
        {
            // TODO: change this to the name of your ContentTypeReader
            // class which will be used to load this data.
            return "H_Map.TileMapReader, H_Map";
        }
    }
}
