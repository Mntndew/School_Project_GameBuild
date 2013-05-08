﻿/*
    ____________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________
   / /                                                                                                                                                                                                                                                                                                                                                                                                                                                  \
  / /        ooOOOOOOOOOOOOOOOOOOOO            ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS            ccCCCCCCCCCCCCCCCCCCCCCCCCCC    iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  llLLLLLLLLLL                            llLLLLLLLLLL                                      aaAAAAAAAAAAAAAAAA            ttTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT  iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII          ooOOOOOOOOOOOOOOOOOOOO          nnNNNNNNNNNN          nnNNNNNNNNNN  \
 / /     ooOOOOOOOOOOOOOOOOOOOOOOOOOOOO       ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS      ccCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC   iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  llLLLLLLLLLL                            llLLLLLLLLLL                                      aaAAAAAAAAAAAAAAAA            ttTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT  iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII      ooOOOOOOOOOOOOOOOOOOOOOOOOOOOO      nnNNNNNNNNNNNN        nnNNNNNNNNNN   \ 
| |  ooOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO   ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS  ccCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC   iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  llLLLLLLLLLL                            llLLLLLLLLLL                                     aaAAAAAAAAAAAAAAAAAA           ttTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT  iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  ooOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO  nnNNNNNNNNNNNN        nnNNNNNNNNNN    |
| |  ooOOOOOOOOOOOO           ooOOOOOOOOOOOO  ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS   ccCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC    iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  llLLLLLLLLLL                            llLLLLLLLLLL                                     aaAAAAAAAAAAAAAAAAAA           ttTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT  iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  ooOOOOOOOOOOOO          ooOOOOOOOOOOOO  nnNNNNNNNNNNNNNN      nnNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO  ssSSSSSSSSS                            ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                    aaAAAAAAAAAAAAAAAAAAAA                       ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNNNNNN      nnNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO  ssSSSSSSSSS                            ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                    aaAAAAAAAAAAAAAAAAAAAA                       ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNNNNNNNN    nnNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO  ssSSSSSSSSS                            ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                   aaAAAAAAAAAAaaAAAAAAAAAA                      ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNNNNNNNN    nnNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO  ssSSSSSSSSS                            ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                   aaAAAAAAAAAAaaAAAAAAAAAA                      ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNNNNNNNNNN  nnNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO  ssSSSSSSSSS                            ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                  aaAAAAAAAAAA  aaAAAAAAAAAA                     ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNNNNNNNNNN  nnNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO  ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS   ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                  aaAAAAAAAAAA  aaAAAAAAAAAA                     ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNNNNNNNNNNNNnnNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO  ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                 aaAAAAAAAAAA    aaAAAAAAAAAA                    ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNNnnNNNNNNNNNNNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO  ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                 aaAAAAAAAAAA    aaAAAAAAAAAA                    ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNNnnNNNNNNNNNNNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO    ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                aaAAAAAAAAAAAAAAAAAAAAAAAAAAAA                   ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNN  nnNNNNNNNNNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO                             ssSSSSSSSSS ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                                aaAAAAAAAAAAAAAAAAAAAAAAAAAAAA                   ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNN  nnNNNNNNNNNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO                             ssSSSSSSSSS ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                               aaAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA                  ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNN    nnNNNNNNNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO                             ssSSSSSSSSS ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                               aaAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA                  ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNN    nnNNNNNNNNNNNNNNNN    |
| |  ooOOOOOOOO                   ooOOOOOOOO                             ssSSSSSSSSS ccCCCCCCCC                                           iiIIIIIIIIII               llLLLLLLLLLL                            llLLLLLLLLLL                              aaAAAAAAAAAA          aaAAAAAAAAAA                 ttTTTTTTTTTT                            iiIIIIIIIIII               ooOOOOOOOO                  ooOOOOOOOO  nnNNNNNNNNNN      nnNNNNNNNNNNNNNN    |
| |  ooOOOOOOOOOOOO           ooOOOOOOOOOOOO    ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS ccCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC    iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  llLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL  llLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL    aaAAAAAAAAAA          aaAAAAAAAAAA                 ttTTTTTTTTTT               iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  ooOOOOOOOOOOOO          ooOOOOOOOOOOOO  nnNNNNNNNNNN      nnNNNNNNNNNNNNNN    |
| |  ooOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO  ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS  ccCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC   iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  llLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL  llLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL   aaAAAAAAAAAA            aaAAAAAAAAAA                ttTTTTTTTTTT               iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  ooOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO  nnNNNNNNNNNN        nnNNNNNNNNNNNN    |
 \ \     ooOOOOOOOOOOOOOOOOOOOOOOOOOOOO      ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS      ccCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC   iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  llLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL  llLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL   aaAAAAAAAAAA            aaAAAAAAAAAA                ttTTTTTTTTTT               iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII      ooOOOOOOOOOOOOOOOOOOOOOOOOOOOO      nnNNNNNNNNNN        nnNNNNNNNNNNNN    /
  \ \       ooOOOOOOOOOOOOOOOOOOOO             ssSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS            ccCCCCCCCCCCCCCCCCCCCCCCCCCC    iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII  llLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL  llLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL  aaAAAAAAAAAA              aaAAAAAAAAAA               ttTTTTTTTTTT               iiIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII          ooOOOOOOOOOOOOOOOOOOOO          nnNNNNNNNNNN          nnNNNNNNNNNN   /
   \_\___________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________/
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using GameBuild.Pathfinding;

namespace GameBuild.Npc
{
    public class Npc
    {
        #region shit load of variables
        public Rectangle position = new Rectangle(-1000, -1000, 0, 0);
        public Rectangle healthPos;
        Rectangle patrolRect;
        Rectangle aPosition;
        Vector2[] path;
        Vector2 randomWalkTarget;
        public Rectangle bumpRectangle;//for mini bots :) they bump into eachother
        Game1 game;
        Texture2D debugTile;
        public Texture2D walkSprite;
        Texture2D deathSprite;
        Texture2D aTexture;
        public Texture2D healthTexture;

        public string name;
        public string mapName;

        float healthBarWidth;
        float maxHealth;
        public float health;
        public float healthPct;
        public float speed;
        public float attackTimer = 500f;
        float pathTimer = 200f;
        const float ATTACKTIMER = 2000f;//milliseconds
        const float PATHTIMER = 200f;//milliseconds
        float MOBPATHTIMER = PATHTIMER;
        float pathTimerMod;
        int pathIndex;
        bool followPath;
        public double robotAngle;
        float directionTimer = 1;
        const float DIRECTIONTIMER = 1;

        public bool point1Tagged = false, point2Tagged = false, point3Tagged = false, point4Tagged = false;
        public bool canInteract;
        public bool countedInteractRect;//so that you cant interact with two npcs at once
        public bool isInteracting = false;
        public bool attackPlayer = false;
        public bool mob;
        public bool bossMob;
        public bool up, down, left, right;
        bool playDeath = true;
        bool addA = false;
        bool hasPath = false;
        bool hasTarget;
        public bool vulnerable;
        bool walking;
        public bool remove;

        public string secondDialogue;
        public string thirdDialogue;

        public enum patrolType
        {
            upDown,
            leftRight,
            box,
            none
        }

        public Key key;

        public Dialogue dialogue;
        List<DamageEffect> damageEffectList = new List<DamageEffect>();
        public AnimationComponent animation;
        WaypointManager waypoint;
        public Quest quest;
        Game.Items.Sword sword;

        Random rand = new Random();

        const int WALK_UP = 0;
        const int WALK_RIGHT = 1;
        const int WALK_DOWN = 2;
        const int WALK_LEFT = 3;
        const int IDLE_UP = 4;
        const int IDLE_RIGHT = 5;
        const int IDLE_DOWN = 6;
        const int IDLE_LEFT = 7;
        int DEATH;
        const int ATTACK_UP = 10;
        const int ATTACK_DOWN = 8;
        const int ATTACK_LEFT = 11;
        const int ATTACK_RIGHT = 9;

        Color color = new Color(255, 255, 255, 255);
        Color aColor;

        int damage;
        int minDamage;//for mobs
        int maxDamage;
        int hitChance;
        int chance;
        int direction;
        #endregion

        public Npc(string mapName, string name, int x, int y, int width, int height, bool up, bool down, bool left, bool right,
            string spritePath, string portraitPath, bool patrolNone, bool patrolUpDown, bool patrolLeftRight,
            bool patrolBox, int patrolX, int patrolY, int patrolWidth, int patrolHeight, float speed, Game1 game,
            string dialoguePath, string keyName, string secondDialogue, string thirdDialogue)
        {
            position = new Rectangle(x, y, 50, 71);
            this.name = name;
            this.mapName = mapName;
            this.up = up;
            this.down = down;
            this.left = left;
            this.right = right;
            vulnerable = true;
            minDamage = 2;
            maxDamage = 15;
            patrolRect = new Rectangle(patrolX, patrolY, patrolWidth, patrolHeight);
            aTexture = game.Content.Load<Texture2D>(@"Npc\A");
            aPosition = new Rectangle(0, 0, aTexture.Width, aTexture.Height);
            health = 200;
            maxHealth = health;
            this.speed = speed;
            this.game = game;

            if (name != "Informer")
            {
                dialogue = new Dialogue(game.Content.Load<Texture2D>(@"npc\portrait\" + portraitPath), Game1.textBox, game, Game1.spriteFont, dialoguePath, name);
                walkSprite = game.Content.Load<Texture2D>(@"npc\sprite\" + spritePath);
            }

            debugTile = game.Content.Load<Texture2D>(@"Player\emptySlot");
            healthTexture = game.Content.Load<Texture2D>(@"Game\health100");
            aColor = Color.White;
            DEATH = 8;
            if (name == "Celine")
            {
                animation = new AnimationComponent(2, 9, 50, 72, 175, Microsoft.Xna.Framework.Point.Zero);
                position.Height = 72;
                sword = new Game.Items.Sword("cockiri", 17, 27);//3, 17
                waypoint = new WaypointManager(name, "Map3_B", 2);
            }
            else if (name == "Headmaster")
            {
                animation = new AnimationComponent(2, 9, 50, 127, 175, Microsoft.Xna.Framework.Point.Zero);
                vulnerable = false;
                position.Y -= 60;
                position.Height = 127;

                waypoint = new WaypointManager(name, "Map3_B", 3);
            }
            else if (name == "Lamia")
            {
                animation = new AnimationComponent(2, 4, 100, 76, 175, Microsoft.Xna.Framework.Point.Zero);
                position.Y -= 64;
                position.Height = 64;
                position.Width = 84;
            }
            else if (name == "Laune")
            {
                animation = new AnimationComponent(3, 11, 50, 75, 175, Microsoft.Xna.Framework.Point.Zero);

            }
            else if (name == "Informer")
            {
                if (spritePath == @"Player\maleSheet")
                {
                    animation = new AnimationComponent(4, 13, 50, 70, 150, Microsoft.Xna.Framework.Point.Zero);
                }
                else
                {
                    animation = new AnimationComponent(4, 4, 41, 70, 150, Microsoft.Xna.Framework.Point.Zero);
                }
            }
            else if (name == "Sylian")
            {
                quest = new Quest(Game1.ribbon.item, this.name);
                animation = new AnimationComponent(2, 4, 50, 71, 175, Microsoft.Xna.Framework.Point.Zero);
            }
            else
            {
                animation = new AnimationComponent(2, 4, 50, 71, 175, Microsoft.Xna.Framework.Point.Zero);
            }

            mob = false;

            dialogue.dialogueManager.ReachedExit += ExitedDialogue;
            if (keyName != "nokey")
            {
                key = new Key(Rectangle.Empty, keyName, game.keyTexture, this.mapName, game);
            }

            this.secondDialogue = secondDialogue;
            this.thirdDialogue = thirdDialogue;
        }

        public Npc(int x, int y, int width, int height, Texture2D walkSprite, Game1 game, string mapName,
            float timerMod, bool attackPlayer, int health, int minDamage, int maxDamage, int hitChance, bool vulnerable)
        {
            this.mapName = mapName;
            position.X = x;
            position.Y = y - 128;
            position.Width = width;
            position.Height = height;
            this.walkSprite = walkSprite;
            this.attackPlayer = attackPlayer;
            this.health = health;
            this.minDamage = minDamage;
            this.maxDamage = maxDamage;
            this.hitChance = hitChance;
            this.vulnerable = vulnerable;
            this.speed = 1;
            pathTimerMod = timerMod;
            healthTexture = game.Content.Load<Texture2D>(@"Game\health100");
            debugTile = game.Content.Load<Texture2D>(@"Player\emptySlot");
            maxHealth = health;
            MOBPATHTIMER = rand.Next(2000, 10000) * timerMod;
            mob = true;
            animation = new AnimationComponent(3, 13, 50, 74, 175, Microsoft.Xna.Framework.Point.Zero);
            deathSprite = game.Content.Load<Texture2D>(@"Npc\deathSprite");
            key = null;
            DEATH = 12;
        }

        public bool IsOnMap()
        {
            if (Game1.map.mapName.Remove(Game1.map.mapName.Length - 1) == mapName || Game1.map.mapName == mapName)
            {
                return true;
            }
            else
                return false;
        }

        public void GoTo(Vector2 targetPoint, GameTime gameTime)//manages findpath and followpath
        {
            float elapsed = (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            pathTimer -= elapsed;
            if (pathTimer <= 0)
            {
                FindPath(targetPoint);
                if (mob)
                {
                    if (!attackPlayer)
                    {
                        MOBPATHTIMER = (PATHTIMER * 3) * pathTimerMod;
                        MOBPATHTIMER += rand.Next((int)-(PATHTIMER / 2), (int)PATHTIMER / 2);
                    }
                    else
                        MOBPATHTIMER = PATHTIMER;

                    pathTimer = MOBPATHTIMER;
                }
                else
                    pathTimer = PATHTIMER;
            }
            if (path != null)
            {
                FollowPath(gameTime);
            }
            else
            {
                if (targetPoint == Game1.character.position)
                {
                    if (position.X > targetPoint.X)
                    {
                        position.X -= (int)speed * 2;
                    }
                    if (position.X < targetPoint.X)
                    {
                        position.X += (int)speed * 2;
                    }
                    if (position.Y > targetPoint.Y)
                    {
                        position.Y -= (int)speed * 2;
                    }
                    if (position.Y < targetPoint.Y)
                    {
                        position.Y += (int)speed * 2;
                    }
                }
            }
        }

        private void FindPath(Vector2 targetPoint)
        {
            if ((!Game1.character.dead) || (!hasPath && !Game1.character.dead))
            {
                int[,] map = new int[Game1.map.mapWidth, Game1.map.mapHeight];
                for (int x = 0; x < Game1.map.mapWidth; x++)
                {
                    for (int y = 0; y < Game1.map.mapHeight; y++)
                    {
                        if (Game1.map.interactiveLayer[x, y].isPassable == true)
                        {
                            map[x, y] = 0;
                        }
                        else
                        {
                            map[x, y] = 1;
                        }
                    }
                }
                Pathfinding.Point start = new Pathfinding.Point((position.X + position.Width / 2) / Game1.map.tileWidth, (position.Y + position.Height / 2) / Game1.map.tileHeight);
                Pathfinding.Point end;
                if (!mob || attackPlayer)
                {
                    end = new Pathfinding.Point((int)targetPoint.X / Game1.map.tileWidth, (int)targetPoint.Y / Game1.map.tileHeight);
                }
                else
                    end = new Pathfinding.Point((int)targetPoint.X, (int)targetPoint.Y);

                path = PathFinder.GetVectorPath(PathFinder.FindPath(map, start, end), Game1.map.tileWidth, Game1.map.tileHeight);

                hasPath = true;
                followPath = true;
                pathIndex = path.Length - 1;
            }
        }

        private void FollowPath(GameTime gameTime)
        {
            if ((path.Length == 1 && path[0].X == -32 && path[0].Y == -32) || position.Intersects(Game1.character.positionRectangle))
            {
                followPath = false;
                hasPath = false;
            }
            else
            {
                followPath = true;
            }
            if (hasPath && pathIndex < path.Length && followPath)
            {
                Rectangle prevLocation = position;
                if (Math.Abs((position.X + position.Width / 2) - path[pathIndex].X) < 10 && Math.Abs((position.Y + position.Height / 2) - path[pathIndex].Y) < 10)
                {
                    pathIndex--;
                    if (pathIndex < 0)
                    {
                        hasPath = false;
                        pathIndex = 0;
                        followPath = false;
                    }
                }
                if (followPath)
                {
                    walking = false;
                    if (mob)
                    {
                        directionTimer -= (float)gameTime.ElapsedGameTime.TotalSeconds * 0.75f;

                        if (directionTimer <= 0)
                        {
                            direction = rand.Next(1, 5);
                            directionTimer = DIRECTIONTIMER;
                        }
                        if (direction == 1)
                        {
                            if (path[pathIndex].Y < position.Y + position.Height / 2)
                            {
                                MoveUp(ref position);
                            }
                        }
                        if (direction == 2)
                        {
                            if (path[pathIndex].Y > position.Y + position.Height / 2)
                            {
                                MoveDown(ref position);
                            }
                        }
                        if (direction == 3)
                        {
                            if (path[pathIndex].X < position.X + position.Width / 2)
                            {
                                MoveLeft(ref position);
                            }
                        }
                        if (direction == 4)
                        {
                            if (path[pathIndex].X > position.X + position.Width / 2)
                            {
                                MoveRight(ref position);
                            }
                        }
                    }
                    else
                    {
                        if (path[pathIndex].Y < position.Y + position.Height / 2)
                        {
                            MoveUp(ref position);
                        }
                        if (path[pathIndex].X < position.X + position.Width / 2 && !(path[pathIndex].Y < position.Y + position.Height / 2))
                        {
                            MoveLeft(ref position);
                        }
                        if (path[pathIndex].Y > position.Y + position.Height / 2)
                        {
                            MoveDown(ref position);
                        }
                        if (path[pathIndex].X > position.X + position.Width / 2 && !(path[pathIndex].Y > position.Y + position.Height / 2))
                        {
                            MoveRight(ref position);
                        }
                    }
                }
            }
        }

        private void RandomMovement(GameTime gameTime)
        {
            GetTargetLocation();
            if (hasTarget)
            {
                GoTo(randomWalkTarget, gameTime);
            }
        }

        private void GetTargetLocation()
        {
            hasTarget = false;
            randomWalkTarget = new Vector2(rand.Next(0, 30), rand.Next(0, 30));

            if (randomWalkTarget.X > 0 && randomWalkTarget.X < Game1.map.mapWidth && randomWalkTarget.Y > 0 && randomWalkTarget.Y < Game1.map.mapHeight)
            {
                if (Game1.map.interactiveLayer[(int)randomWalkTarget.X, (int)randomWalkTarget.Y].isPassable)
                {
                    hasTarget = true;
                }
                else
                    GetTargetLocation();
            }
            else
                GetTargetLocation();
        }

        public void Attack(Game1 game, GameTime gameTime)
        {
            Rectangle location = position;
            float elapsed = (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            if (bossMob)
            {
                walking = false;
                if (Game1.character.positionRectangle.X > position.X)
                {
                    MoveRight(ref position);
                }
                if (Game1.character.positionRectangle.X < position.X)
                {
                    MoveLeft(ref position);
                }
                if (Game1.character.positionRectangle.Y > position.Y)
                {
                    MoveDown(ref position);
                }
                if (Game1.character.positionRectangle.Y < position.Y)
                {
                    MoveUp(ref position);
                }
            }
            if (Game1.character.positionRectangle.Intersects(position) && IsOnMap() && !Game1.character.dead && !bossMob)
            {
                if (attackTimer <= 0)
                {
                    walking = false;
                    damage = game.damageObject.dealDamage(minDamage, maxDamage);
                    damageEffectList.Add(new DamageEffect(damage, game, new Vector2(Game1.character.positionRectangle.X, Game1.character.positionRectangle.Y), new Color(255, 0, 0, 255), "npc"));
                    Game1.character.health -= damage;
                    Game1.character.Hit();
                    Vector2 pos = new Vector2(location.X, location.Y);
                    Vector2 direction = Game1.character.position - pos;
                    direction.Normalize();
                    Game1.character.Push(direction, 12);
                    attackTimer = ATTACKTIMER;
                    Game1.character.Disable();
                    if (up)
                    {
                        animation.PlayAnimation(ATTACK_UP);
                    }
                    else if (down)
                    {
                        animation.PlayAnimation(ATTACK_DOWN);
                    }
                    if (left)
                    {
                        animation.PlayAnimation(ATTACK_LEFT);
                    }
                    else if (right)
                    {
                        animation.PlayAnimation(ATTACK_RIGHT);
                    }
                }
                followPath = false;
            }
            else
            {
                if (Game1.character.positionRectangle.Intersects(position) && !Game1.character.dead)
                {
                    if (attackTimer <= 0)
                    {
                        chance = rand.Next(1, 100);
                        if (chance <= hitChance)
                        {
                            damage = game.damageObject.dealDamage(minDamage, maxDamage);
                            damageEffectList.Add(new DamageEffect(damage, game, new Vector2(Game1.character.positionRectangle.X, Game1.character.positionRectangle.Y), new Color(255, 0, 0, 255), "npc"));
                            Game1.character.health -= damage;
                            if (bossMob)
                            {
                                if (Game1.character.health <= 0)
                                {
                                    Game1.testBoss.Respawn(game);
                                }
                            }
                            Game1.character.Hit();
                            chance = 101;
                            attackTimer = ATTACKTIMER;
                        }
                    }
                }
            }

            attackTimer -= elapsed;

            if (IsOnMap() && !bossMob)
            {
                GoTo(new Vector2((Game1.character.positionRectangle.X + (Game1.character.positionRectangle.Width / 2)), (Game1.character.positionRectangle.Y + (Game1.character.positionRectangle.Height / 2))), gameTime);
                if (!hasPath && !position.Intersects(Game1.character.positionRectangle))
                {
                    if (Game1.character.positionRectangle.X > position.X)
                    {
                        MoveRight(ref position);
                    }
                    if (Game1.character.positionRectangle.X < position.X)
                    {
                        MoveLeft(ref position);
                    }
                    if (Game1.character.positionRectangle.Y > position.Y)
                    {
                        MoveDown(ref position);
                    }
                    if (Game1.character.positionRectangle.Y < position.Y)
                    {
                        MoveUp(ref position);
                    }
                }
            }
        }

        #region Movement functions
        public void MoveUp(ref Rectangle location)
        {
            up = true;
            down = false;
            left = false;
            right = false;
            if (name == "Laune")
            {
                animation.MaxFrameCount = 2;
            }
            if (!attackPlayer)
            {
                location.Y += (int)-(speed * 2);
            }
            else
                location.Y += (int)-(speed * 4);

            if (!animation.IsAnimationPlaying(WALK_UP))
            {
                animation.LoopAnimation(WALK_UP);
            }
            walking = true;
        }

        public void MoveDown(ref Rectangle location)
        {
            up = false;
            down = true;
            left = false;
            right = false;
            if (name == "Laune")
            {
                animation.MaxFrameCount = 2;
            }
            if (!attackPlayer)
            {
                location.Y += (int)(speed * 2);
            }
            else
                location.Y += (int)(speed * 4);

            if (!animation.IsAnimationPlaying(WALK_DOWN))
            {
                animation.LoopAnimation(WALK_DOWN);
            }
            walking = true;
        }

        public void MoveLeft(ref Rectangle location)
        {
            up = false;
            down = false;
            left = true;
            right = false;
            if (name == "Laune")
            {
                animation.MaxFrameCount = 1;
            }
            if (!attackPlayer)
            {
                location.X += (int)-(speed * 2);
            }
            else
                location.X += (int)-(speed * 4);

            if (!animation.IsAnimationPlaying(WALK_LEFT))
            {
                animation.LoopAnimation(WALK_LEFT);
            }
            walking = true;
        }

        public void MoveRight(ref Rectangle location)
        {
            up = false;
            down = false;
            left = false;
            right = true;
            if (name == "Laune")
            {
                animation.MaxFrameCount = 1;
            }
            if (!attackPlayer)
            {
                location.X += (int)(speed * 2);
            }
            else
                location.X += (int)(speed * 4);

            if (!animation.IsAnimationPlaying(WALK_RIGHT))
            {
                animation.LoopAnimation(WALK_RIGHT);
            }
            walking = true;
        }
        #endregion

        public bool IsCollision(H_Map.TileMap tiles, Rectangle location)
        {
            Microsoft.Xna.Framework.Point tileIndex = tiles.GetTileIndexFromVector(new Vector2(location.X, location.Y));
            return (!tiles.interactiveLayer[tileIndex.X, tileIndex.Y].isPassable);
        }

        public void UpdateDialogue(Game1 game)
        {
            if (Game1.currentGameState == Game1.GameState.INTERACT)
            {
                dialogue.Update();
                if (!dialogue.isTalking && isInteracting == true)
                {
                    Game1.currentGameState = Game1.GameState.PLAY;
                    isInteracting = false;
                }
            }
        }

        public void Update(Character player, H_Map.TileMap tiles, Game1 game, GameTime gameTime)
        {
            #region things to update every frame, positions
            aPosition.X = position.X - (position.Width / 2);
            aPosition.Y = position.Y - (position.Height / 2);
            Rectangle location = new Rectangle(position.X, position.Y, position.Width, position.Height);
            healthPos.X = position.X + 8;
            healthPos.Y = position.Y - 15;
            healthPos.Width = (int)healthBarWidth;
            healthPos.Height = 10;
            healthPct = (health / maxHealth);
            healthBarWidth = (float)healthTexture.Width * healthPct;
            bumpRectangle = new Rectangle(position.X + position.Width / 2, position.Y + position.Height / 2, position.Width / 2, position.Height / 2);
            animation.UpdateAnimation(gameTime);
            #endregion

            if (health <= 0)
            {
                Death(gameTime);
            }
            else
            {
                if (waypoint != null)
                {
                    waypoint.Update(game, new Vector2(position.X, position.Y));
                }

                if (!walking && health > 0)
                {
                    animation.MaxFrameCount = 1;
                    if (up)
                    {
                        if (!animation.IsAnimationPlaying(IDLE_UP))
                        {
                            animation.LoopAnimation(IDLE_UP);
                        }
                    }
                    if (down)
                    {
                        if (!animation.IsAnimationPlaying(IDLE_DOWN))
                        {
                            animation.LoopAnimation(IDLE_DOWN);
                        }
                    }
                    if (left)
                    {
                        if (!animation.IsAnimationPlaying(IDLE_LEFT))
                        {
                            animation.LoopAnimation(IDLE_LEFT);
                        }
                    }
                    if (right)
                    {
                        if (!animation.IsAnimationPlaying(IDLE_RIGHT))
                        {
                            animation.LoopAnimation(IDLE_RIGHT);
                        }
                    }
                }

                if (mob && !bossMob)
                {
                    if (!attackPlayer && IsOnMap() && health > 0)
                    {
                        RandomMovement(gameTime);
                    }
                    else
                        pathTimer = 0;
                }

                for (int i = 0; i < damageEffectList.Count; i++)
                {
                    damageEffectList[i].Effect();
                }

                if (attackPlayer)
                {
                    canInteract = false;
                    Attack(game, gameTime);
                }

                #region Player Interaction

                if (IsOnMap())
                {
                    if (position.Intersects(player.interactRect) && !attackPlayer)
                    {
                        canInteract = true;
                        if (!isInteracting)
                        {
                            if (!addA)
                            {
                                aColor.A -= 10;
                                aColor.B += 10;
                                aColor.R -= 10;
                                aColor.G += 10;
                            }
                            if (aColor.A <= 50)
                            {
                                addA = true;
                            }
                            if (addA)
                            {
                                aColor.A += 10;
                                aColor.R += 10;
                                aColor.B -= 10;
                                aColor.G -= 10;
                            }
                            if (aColor.A >= 240)
                            {
                                addA = false;
                            }
                        }
                    }
                    else
                    {
                        canInteract = false;
                    }
                }
                if (quest != null && quest.completed)
                {
                    canInteract = false;
                }
                #endregion

                if (!attackPlayer && player.positionRectangle.Intersects(position) && IsOnMap())
                {
                    if (health > 0)
                    {
                        Vector2 pos = new Vector2(location.X, location.Y);
                        Vector2 direction = Game1.character.position - pos;
                        direction.Normalize();
                        if (name != "")
                        {
                            Game1.character.Push(direction, 3);
                        }
                        else
                        {
                            if (attackPlayer)
                            {
                                Game1.character.Push(direction, 3);
                            }
                        }
                    }
                }
            }
        }

        public void Death(GameTime gameTime)
        {
            attackPlayer = false;
            if (!remove && playDeath)
            {
                animation.StopAnimation();
                animation.PlayAnimation(DEATH);
                animation.MaxFrameCount = 3;
                playDeath = false;
            }
            else if (!animation.playing)//!animation.IsAnimationPlaying(DEATH)
            {
                remove = true;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (IsOnMap())
            {
                if (!remove)
                {
                    spriteBatch.Draw(walkSprite, position, animation.GetFrame(), Color.White);
                }
            }
        }

        public void DrawHealth(SpriteBatch spriteBatch)
        {
            if (IsOnMap())
            {
                if (healthTexture != null && health > 0)
                {
                    spriteBatch.Draw(healthTexture, healthPos, Color.White);
                }
            }
        }

        public void DrawA(SpriteBatch spriteBatch)
        {
            if (IsOnMap())
            {
                if (health > 0)
                {
                    if (canInteract && Game1.character.npcsInRectangle < 2)
                    {
                        spriteBatch.Draw(aTexture, aPosition, aColor);
                    }
                }
            }
        }

        public void DrawDamage(SpriteBatch spriteBatch, Game1 game)
        {
            for (int i = 0; i < damageEffectList.Count; i++)
            {
                if (health > 0)
                {
                    damageEffectList[i].Draw(spriteBatch, game);
                }
            }
        }

        public void ExitedDialogue(object sender, DialogueEventArgs e)
        {
            Console.WriteLine(e.exitNumber);

            switch (e.exitNumber)
            {
                case 0:
                    isInteracting = false;
                    dialogue.isTalking = false;
                    Game1.currentGameState = Game1.GameState.PLAY;
                    break;

                case 1:
                    attackPlayer = true;
                    break;

                case 2:
                    if (key != null)
                    {
                        key.position = Game1.character.positionRectangle;
                        Game1.keys.Add(key);
                        key = null;
                    }
                    if (quest != null)
                    {
                        quest.completed = true;
                    }
                    break;

                case 3:
                    if (name == "Ziva" && Game1.testBoss.health > 0)
                    {
                        Game1.testBoss.attackPlayer = true;
                    }
                    health = 0;
                    break;

                case 4:
                    if (sword != null)
                    {
                        Game1.character.GetSword(sword, game);
                    }
                    break;

                case 5:
                    if (secondDialogue != "null")
                    {
                        dialogue.dialogueManager = new DialogueManager(@"Content\npc\dialogue\" + secondDialogue + ".txt");
                        dialogue.dialogueManager.ReachedExit += ExitedDialogue;
                    }
                    break;

                case 6:
                    if (sword != null)
                    {
                        Game1.character.GetSword(sword, game);
                        sword = null;
                    }
                    if (secondDialogue != "null")
                    {
                        dialogue.dialogueManager = new DialogueManager(@"Content\npc\dialogue\" + secondDialogue + ".txt");
                        dialogue.dialogueManager.ReachedExit += ExitedDialogue;
                    }
                    break;
                case 7:
                    if (quest != null)
                    {
                        quest.Accept(game);
                    }
                    break;
                default:
                    isInteracting = false;
                    dialogue.isTalking = false;
                    Game1.currentGameState = Game1.GameState.PLAY;
                    break;
            }
        }
    }
}