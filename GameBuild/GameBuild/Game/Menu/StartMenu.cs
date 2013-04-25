using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GameBuild.Menu
{
    public class StartMenu
    {
        Texture2D playButtonSelected;
        Texture2D playButtonDeselected;

        Texture2D exitButtonSelected;
        Texture2D exitButtonDeselected;

        bool play;

        KeyboardState oldState;
        KeyboardState currentState;

        public StartMenu(Texture2D playButtonS, Texture2D playButtonD, Texture2D exitButtonS, Texture2D exitButtonD)
        {
            playButtonSelected = playButtonS;
            playButtonDeselected = playButtonD;

            exitButtonSelected = exitButtonS;
            exitButtonDeselected = exitButtonD;
            play = true;
        }

        public void Update(Game1 game)
        {
            oldState = currentState;
            currentState = Keyboard.GetState();
            if ((currentState.IsKeyDown(Keys.Up) && oldState.IsKeyUp(Keys.Up)) || (currentState.IsKeyDown(Keys.Down) && oldState.IsKeyUp(Keys.Down)))
            {
                play = !play;
            }
            if (currentState.IsKeyDown(Keys.Enter))
            {
                if (play)
                {
                    game.transition = true;
                }
                else
                {
                    game.Exit();
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            if (play)
            {
                spriteBatch.Draw(playButtonSelected, new Rectangle(400, 300, playButtonSelected.Width, playButtonSelected.Height), Color.White);
                spriteBatch.Draw(exitButtonDeselected, new Rectangle(400, 500, exitButtonDeselected.Width, exitButtonDeselected.Height), Color.White);
            }
            else
            {
                spriteBatch.Draw(playButtonDeselected, new Rectangle(400, 300, playButtonDeselected.Width, playButtonDeselected.Height), Color.White);
                spriteBatch.Draw(exitButtonSelected, new Rectangle(400, 500, exitButtonSelected.Width, exitButtonSelected.Height), Color.White);
            }
            spriteBatch.End();
        }
    }
}
