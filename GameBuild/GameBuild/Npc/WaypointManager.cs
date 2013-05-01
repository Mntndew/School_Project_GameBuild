using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace GameBuild.Npc
{
    class WaypointManager
    {
        int amount;
        int index = 0;
        string name;
        string map;
        public bool done;
        Vector2[] waypoints;
        Vector2 position;
        private bool up, down, left, right;//where the waypoint is relative to the npc
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">The name of the npc.</param>
        /// <param name="map">The map name where it triggers.</param>
        /// <param name="amount">The amount of points in the array.</param>
        public WaypointManager(string name, string map, int amount)
        {
            this.amount = amount;
            waypoints = new Vector2[amount];
            this.name = name;
            this.map = map;
            SetWaypoints();
            CheckDirection();
        }

        private void SetWaypoints()
        {
            //set points
            if (name == "Headmaster")
            {
                waypoints[0] = new Vector2(468, 693);
                waypoints[1] = new Vector2(393, 1022);
                waypoints[2] = new Vector2(575, 1110);
            }
            else if (name == "Celine")
            {
                waypoints[0] = new Vector2(560, 1521);
                waypoints[1] = new Vector2(560, 1234);
            }
        }

        public void Update(Game1 game, Vector2 position)
        {
            if (map == Game1.map.mapName.Remove(Game1.map.mapName.Length - 1))
            {
                Console.WriteLine(position);
                this.position = position;
                if (Reached())
                {
                    NextWaypoint(game);
                }
                else
                {
                    for (int i = 0; i < game.activeNpcs.Count; i++)
                    {
                        if (game.activeNpcs[i].name == name)
                        {
                            CheckDirection();
                            if (left)
                            {
                                if (!(waypoints[index].X - position.X <= 16 && waypoints[index].X - position.X >= -16))
                                {
                                    game.activeNpcs[i].MoveLeft(ref game.activeNpcs[i].position);
                                }
                            }
                            else if (right)
                            {
                                if (!(waypoints[index].X - position.X <= 16 && waypoints[index].X - position.X >= -16))
                                {
                                    game.activeNpcs[i].MoveRight(ref game.activeNpcs[i].position);
                                }
                            }

                            if (up)
                            {
                                if (!(waypoints[index].Y - position.Y <= 16 && waypoints[index].Y - position.Y >= -16))
                                {
                                    game.activeNpcs[i].MoveUp(ref game.activeNpcs[i].position);
                                }
                            }
                            else if (down)
                            {
                                if (!(waypoints[index].Y - position.Y <= 16 && waypoints[index].Y - position.Y >= -16))
                                {
                                    game.activeNpcs[i].MoveDown(ref game.activeNpcs[i].position);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void CheckDirection()
        {
            if (waypoints[index].Y != position.Y)
            {
                if ((waypoints[index].Y - position.Y >= 8
                || waypoints[index].Y - position.Y <= -8) 
                && waypoints[index].Y < position.Y)
                {
                    up = true;
                    down = false;
                }

                if ((waypoints[index].Y - position.Y >= 8
                    || waypoints[index].Y - position.Y <= -8) 
                    && waypoints[index].Y > position.Y)
                {
                    up = false;
                    down = true;
                }
            }
            if (waypoints[index].X != position.X)
            {
                if ((waypoints[index].X - position.X >= 8
                || waypoints[index].X - position.X <= -8) 
                && waypoints[index].X < position.X)
                {
                    left = true;
                    right = false;
                }

                if ((waypoints[index].X - position.X >= 8
                    || waypoints[index].X - position.X <= -8) 
                    && waypoints[index].X > position.X)
                {
                    left = false;
                    right = true;
                }
            }
        }

        private bool Reached()
        {
            if ((waypoints[index].X - position.X <= 16 && waypoints[index].X - position.X >= -16)
                && (waypoints[index].Y - position.Y <= 16 && waypoints[index].Y - position.Y >= -16))
            {
                return true;
            }
            else
                return false;
        }

        private void NextWaypoint(Game1 game)
        {
            if (index < amount - 1)
            {
                index++;
            }
            else
                done = true;

            if (!done)
            {
                CheckDirection();
            }
            else
            {
                for (int i = 0; i < game.activeNpcs.Count; i++)
                {
                    if (game.activeNpcs[i].name == "Headmaster")
                    {
                        game.activeNpcs[i].animation.PlayAnimation(6);
                    }
                    if (game.activeNpcs[i].name == "Celine")
                    {
                        game.activeNpcs[i].animation.PlayAnimation(6);
                    }
                }
            }
        }
    }
}
