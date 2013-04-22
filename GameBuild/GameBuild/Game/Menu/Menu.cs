using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameBuild.Menu
{
    public class Menu
    {
        //background
        Rectangle position;
        Texture2D texture;

        public bool paused;

        public Menu(Game1 game)
        {
            position = new Rectangle(0, 0, game.graphics.PreferredBackBufferWidth, game.graphics.PreferredBackBufferHeight);
            texture = game.Content.Load<Texture2D>(@"Game\blackness");
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (paused)
            {
                spriteBatch.Begin();
                spriteBatch.Draw(texture, position, new Color(10, 10, 10, 200));
                spriteBatch.End();
            }
        }
    }
}
