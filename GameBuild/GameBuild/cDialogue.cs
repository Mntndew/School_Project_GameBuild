using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GameBuild
{
    public class cDialogue
    {
        Texture2D portrait;
        Texture2D textBox;
        SpriteFont font;

        public Rectangle portraitPos;
        public Rectangle textBoxPos;

        int width = 0, height = 0;

        public bool isTalking;

        int selection;

        KeyboardState oldState;
        KeyboardState currentState;

        string[] currentLines;

        public cDialogue(Texture2D portrait, Texture2D textBox, Game1 game, SpriteFont font)
        {
            this.portrait = portrait;
            this.textBox = textBox;
            this.font = font;

            int screenWidth = game.graphics.PreferredBackBufferWidth;
            int screenHeight = game.graphics.PreferredBackBufferHeight;

            portraitPos = new Rectangle(game.graphics.PreferredBackBufferWidth - width, game.graphics.PreferredBackBufferHeight - height, width, height);
            textBoxPos = new Rectangle(screenWidth/2 - textBox.Width/2, screenHeight - screenHeight/4, textBox.Width, textBox.Height);
        }

        public void Update()
        {
            oldState = currentState;
            currentState = Keyboard.GetState();

            if (currentState.IsKeyDown(Keys.Up) && oldState.IsKeyUp(Keys.Up))
            {
                selection -= 1;
                if (selection < 1)
                {
                    selection = currentLines.Length - 1;
                }
            }
            else if (currentState.IsKeyDown(Keys.Down) && oldState.IsKeyUp(Keys.Down))
            {
                selection += 1;
                if (selection > currentLines.Length)
                {
                    selection = 1;
                }
            }
            if (currentState.IsKeyDown(Keys.Enter) && oldState.IsKeyUp(Keys.Enter))
            {
                GotoNextStatement();
                selection = 1;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (isTalking && portrait != null)
            {
                spriteBatch.Draw(portrait, portraitPos, Color.White);
                spriteBatch.Draw(textBox, textBoxPos, Color.White);
                for (int i = 0; i < currentLines.Length; i++)
                {
                    spriteBatch.DrawString(font, currentLines[i], new Vector2(textBoxPos.X + 100, textBoxPos.Y + 40 + i*10), Color.White);
                }
            }
        }

        private void GotoNextStatement()
        {
            
        }
    }
}
