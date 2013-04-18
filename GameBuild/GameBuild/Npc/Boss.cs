using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameBuild.Npc
{
    public class Boss
    {
        public Rectangle position;
        Rectangle healthPos;
        Texture2D texture;
        public List<Projectile> projectiles = new List<Projectile>();
        public List<Npc> mobs = new List<Npc>();
        float timer = 1;
        const float TIMER = 1000;
        string map;
        public int health = 100;
        public int maxHealth = 100;
        int healthBarWidth;
        int healthPct;
        Texture2D healthTexture;

        public Boss(Rectangle position, Game1 game, string map)
        {
            this.position = position;
            this.map = map;
            healthPos = new Rectangle();
            healthTexture = game.Content.Load<Texture2D>(@"Game\health100");
            texture = game.Content.Load<Texture2D>(@"Game\blackness");
        }

        public void Update(Game1 game, GameTime gameTime)//Manages the phases
        {
            healthPct = (health / maxHealth);
            healthBarWidth = (healthTexture.Width * 25) * healthPct;
            healthPos.Width = (int)healthBarWidth;
            healthPos.Height = healthTexture.Height;

            for (int i = 0; i < projectiles.Count; i++)
            {
                projectiles[i].CheckDead(gameTime);
                if (!projectiles[i].dead)
                {
                    projectiles[i].Update(gameTime);
                }
                else
                    projectiles.RemoveAt(i);
            }

            for (int i = 0; i < mobs.Count; i++)
            {
                mobs[i].Update(Game1.character, Game1.map, game, gameTime);
            }

            float elapsed = (float)gameTime.ElapsedGameTime.TotalSeconds;
            timer -= elapsed;
            if (timer <= 0)
            {
                //Shoot(game);
                SpawnMobs(game);
                timer = TIMER;
            }
        }

        public bool IsOnMap()
        {
            if (Game1.map.mapName.Remove(Game1.map.mapName.Length - 1) == map)
            {
                return true;
            }
            else
                return false;
        }

        private void Shoot(Game1 game)
        {
            projectiles.Add(new Projectile(new Vector2(this.position.X, this.position.Y), game));
        }

        private void SpawnMobs(Game1 game)
        {
            for (int i = 0; i < 4; i++)
            {
                mobs.Add(new Npc(new Rectangle((position.X - 48) + (48 * i),
                    (position.Y - 48) + (48 * i), 48, 48),
                    game.Content.Load<Texture2D>(@"Game\blackness"),
                    game, map, 1, true, 25, 1, 1, 25));
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);
            for (int i = 0; i < mobs.Count; i++)
            {
                mobs[i].Draw(spriteBatch);
            }
            spriteBatch.Draw(texture, Game1.character.bossTarget, new Color(255, 100, 100, 100));
        }

        public void DrawHealth(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(healthTexture, new Rectangle(40, 10, healthPos.Width - 2, healthPos.Height), Color.White);
        }
    }
}
