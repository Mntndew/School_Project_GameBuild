using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace GameBuild
{
    public class ItemLabel
    {
        Texture2D texture;
        Texture2D side;
        Texture2D side2;
        public Rectangle position;
        public ItemLabel(Rectangle position, int characters, Game1 game)
        {
            texture = game.Content.Load<Texture2D>(@"Game\itemLabel");
            side = game.Content.Load<Texture2D>(@"Game\labelSide");
            side2 = game.Content.Load<Texture2D>(@"Game\labelSide2");
            this.position = position;
            this.position.Width = (characters * 10) + 2;
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(side, new Rectangle(position.X - 2, position.Y, 2, 25), Color.White);
            spriteBatch.Draw(side, new Rectangle(position.X + position.Width, position.Y, 2, 25), Color.White);
            spriteBatch.Draw(side2, new Rectangle(position.X, position.Y, position.Width, 2), Color.White);
            spriteBatch.Draw(side2, new Rectangle(position.X, position.Y + position.Height - 2, position.Width, 2), Color.White);
            spriteBatch.Draw(texture, position, new Color(255, 255, 255, 200));
        }
    }
}
