using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GameBuild.Menu
{
    public class Menu
    {
        //background
        Rectangle position;
        Texture2D texture;

        Rectangle resumePosition;
        Texture2D resume;

        Rectangle exitPosition;
        Texture2D exit;

        public bool paused;
        public bool resumeSelected = true;
        public bool exitSelected;

        public Menu(Game1 game)
        {
            position = new Rectangle(0, 0, game.graphics.PreferredBackBufferWidth, game.graphics.PreferredBackBufferHeight);

            resume = game.Content.Load<Texture2D>(@"Game\Menu\resumeSelected");
            exit = game.Content.Load<Texture2D>(@"Game\Menu\exit");
            resumePosition = new Rectangle(0, 300, 320, 64);
            exitPosition = new Rectangle(0, 384, 320, 64);
            texture = game.Content.Load<Texture2D>(@"Game\blackness");
        }

        public void Update(Game1 game)
        {
            if (game.keyState.IsKeyDown(Keys.Up) && game.oldState.IsKeyUp(Keys.Up))
            {
                if (!exitSelected && !resumeSelected)
                {
                    resumeSelected = true;
                    exitSelected = false;
                }
                else if (resumeSelected)
                {
                    exitSelected = true;
                    resumeSelected = false;
                }
                else if (exitSelected)
                {
                    resumeSelected = true;
                    exitSelected = false;
                }
            }
            if (game.keyState.IsKeyDown(Keys.Down) && game.oldState.IsKeyUp(Keys.Down))
            {
                if (!exitSelected && !resumeSelected)
                {
                    exitSelected = true;
                    resumeSelected = false;
                }
                else if (resumeSelected)
                {
                    exitSelected = true;
                    resumeSelected = false;
                }
                else if (exitSelected)
                {
                    resumeSelected = true;
                    exitSelected = false;
                }
            }
            if (exitSelected)
            {
                exit = game.Content.Load<Texture2D>(@"Game\Menu\exitSelected");
                resume = game.Content.Load<Texture2D>(@"Game\Menu\resume");
            }
            if (resumeSelected)
            {
                exit = game.Content.Load<Texture2D>(@"Game\Menu\exit");
                resume = game.Content.Load<Texture2D>(@"Game\Menu\resumeSelected");
            }
            if (game.keyState.IsKeyDown(Keys.Enter))
            {
                if (exitSelected)
                {
                    game.Exit();
                }
                if (resumeSelected)
                {
                    Game1.currentGameState = Game1.GameState.PLAY;
                    paused = false;
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (paused)
            {
                spriteBatch.Begin();
                spriteBatch.Draw(texture, position, new Color(10, 10, 10, 200));
                spriteBatch.Draw(exit, exitPosition, Color.White);
                spriteBatch.Draw(resume, resumePosition, Color.White);
                spriteBatch.End();
            }
        }
    }
}
