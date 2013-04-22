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

        public bool isTalking;

        int selection = 1;
        int currentStatement = 0;

        KeyboardState oldState;
        KeyboardState currentState;

        string[] currentLines;
        string name;

        DialogueManager dialogueManager;

         

        public cDialogue(Texture2D portrait, Texture2D textBox, Game1 game, SpriteFont font, string dialogueFileName, string name)
        {
            this.portrait = portrait;
            this.textBox = textBox;
            this.font = font;
            this.name = name;

            int screenWidth = game.graphics.PreferredBackBufferWidth;
            int screenHeight = game.graphics.PreferredBackBufferHeight;
            if (portrait != null)
            {
                portraitPos = new Rectangle(screenWidth - 450, screenHeight - 720, 450, 720);
            }

            textBoxPos = new Rectangle(screenWidth / 2 - textBox.Width / 2, screenHeight - screenHeight / 4 - 150, textBox.Width, textBox.Height);

            dialogueManager = new DialogueManager(@"Content\npc\dialogue\" + dialogueFileName + ".txt");
            GetLines(0);
            dialogueManager.ReachedExit += new ExitEventHandler(ExitDialogue);
        }

        public void Update()
        {
            if (isTalking)
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
                    if (selection > currentLines.Length - 1)
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
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (isTalking)
            {
                if (portrait != null)
                {
                    spriteBatch.Draw(portrait, portraitPos, Color.White);
                }
                spriteBatch.Draw(textBox, textBoxPos, Color.White);

                Vector2 baseVector = new Vector2(textBoxPos.X + 60, textBoxPos.Y + 75);
                Vector2 offsetVector = Vector2.Zero;
                spriteBatch.DrawString(font, "" + name, new Vector2(textBoxPos.X + textBox.Width - 190, textBoxPos.Y + 25), Color.Black);
                spriteBatch.DrawString(font, currentLines[0], new Vector2(textBoxPos.X + 75, textBoxPos.Y + 75), Color.Black);
                offsetVector.Y = font.MeasureString(currentLines[0]).Y;
                for (int i = 1; i < currentLines.Length; i++)
                {
                    if (i == selection && currentLines.Length > 1)
                    {
                        spriteBatch.DrawString(font, currentLines[i], new Vector2(baseVector.X + offsetVector.X, baseVector.Y + offsetVector.Y), Color.Red);
                    }
                    else
                    {
                        spriteBatch.DrawString(font, currentLines[i], new Vector2(baseVector.X + offsetVector.X, baseVector.Y + offsetVector.Y), Color.DarkOrange);
                    }
                    offsetVector.Y += font.MeasureString(currentLines[i]).Y;
                }
            }
        }

        private void GotoNextStatement()
        {
            int index = dialogueManager.GetNextStatementIndex(currentStatement, selection);
            if (index > -1)
            {
                currentLines = dialogueManager.GetDialogueLinesFromIndex(index);
                currentStatement = index;
            }
            else
            {
                ResetDialogue();
            }
        }

        private void GetLines(int index)
        {
            currentLines = dialogueManager.GetDialogueLinesFromIndex(index);
        }

        public void ResetDialogue()
        {
            isTalking = false;
            selection = 1;
            currentLines = dialogueManager.GetDialogueLinesFromIndex(0);
            currentStatement = 0;
        }

        private void ExitDialogue(object sender, DialogueEventArgs e)
        {
            ResetDialogue();
            Console.WriteLine("I just exited a dialogue at exit {0}", e.exitNumber);
            //TODO: Add events to the npc class to pick up the exit type and respond accordingly
        }
    }
}
