using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameBuild
{
    class PathFinder
    {
        public List<Node>[,] openList;
        public List<Node>[,] closedList;

        public PathFinder(Game1 game)
        {
            openList = new List<Node>[Game1.map.mapWidth, Game1.map.mapHeight];
            closedList = new List<Node>[Game1.map.mapWidth, Game1.map.mapHeight];
        }

        public void FindPath(int startX, int startY, int targetX, int targetY)
        {
            for (int x = 0; x < Game1.map.mapWidth; x++)
            {
                for (int y = 0; y < Game1.map.mapHeight; y++)
                {
                    if (x == startX && y == startY)
                    {
                        openList[x, y].Add(new Node());
                    }
                }
            }

            while (openList[targetX, targetY] == null)
            {
                for (int x = 0; x < Game1.map.mapWidth; x++)
                {
                    for (int y = 0; y < Game1.map.mapHeight; y++)
                    {
                        for (int i = 0; i < openList.Length; i++)
                        {
                            //get the F value and add nodes to open list
                            #region straight
                            if (Game1.map.interactiveLayer[x + 1, y].isPassable)
                            {
                                openList[x + 1, y].Add(new Node());
                                openList[x + 1, y][i].G = 10;
                                if (x < targetX)
                                {
                                    if (y < targetY)
                                    {
                                        openList[x, y][i].H = (targetX - x) + (targetY - y);
                                    }
                                    if (y > targetY)
                                    {
                                        openList[x, y][i].H = (targetX - x) + (y - targetY);
                                    }
                                }
                                else
                                {
                                    if (y < targetY)
                                    {
                                        openList[x, y][i].H = (x - targetX) + (targetY - y);
                                    }
                                    if (y > targetY)
                                    {
                                        openList[x, y][i].H = (x - targetX) + (y - targetY);
                                    }
                                }
                                openList[x + 1, y][i].F = openList[x + 1, y][i].G + openList[x + 1, y][i].H;
                            }
                            if (Game1.map.interactiveLayer[x - 1, y].isPassable)
                            {
                                openList[x - 1, y].Add(new Node());
                                openList[x - 1, y][i].G = 10;
                                if (x < targetX)
                                {
                                    if (y < targetY)
                                    {
                                        openList[x, y][i].H = (targetX - x) + (targetY - y);
                                    }
                                    if (y > targetY)
                                    {
                                        openList[x, y][i].H = (targetX - x) + (y - targetY);
                                    }
                                }
                                else
                                {
                                    if (y < targetY)
                                    {
                                        openList[x, y][i].H = (x - targetX) + (targetY - y);
                                    }
                                    if (y > targetY)
                                    {
                                        openList[x, y][i].H = (x - targetX) + (y - targetY);
                                    }
                                }
                                openList[x - 1, y][i].F = openList[x - 1, y][i].G + openList[x - 1, y][i].H;
                            }
                            if (Game1.map.interactiveLayer[x, y + 1].isPassable)
                            {
                                openList[x, y + 1].Add(new Node());
                                openList[x, y + 1][i].G = 10;
                                if (x < targetX)
                                {
                                    if (y < targetY)
                                    {
                                        openList[x, y][i].H = (targetX - x) + (targetY - y);
                                    }
                                    if (y > targetY)
                                    {
                                        openList[x, y][i].H = (targetX - x) + (y - targetY);
                                    }
                                }
                                else
                                {
                                    if (y < targetY)
                                    {
                                        openList[x, y][i].H = (x - targetX) + (targetY - y);
                                    }
                                    if (y > targetY)
                                    {
                                        openList[x, y][i].H = (x - targetX) + (y - targetY);
                                    }
                                }
                                openList[x, y + 1][i].F = openList[x, y + 1][i].G + openList[x, y + 1][i].H;
                            }
                            if (Game1.map.interactiveLayer[x, y - 1].isPassable)
                            {
                                openList[x, y - 1].Add(new Node());
                                openList[x, y - 1][i].G = 10;
                                if (x < targetX)
                                {
                                    if (y < targetY)
                                    {
                                        openList[x, y][i].H = (targetX - x) + (targetY - y);
                                    }
                                    if (y > targetY)
                                    {
                                        openList[x, y][i].H = (targetX - x) + (y - targetY);
                                    }
                                }
                                else
                                {
                                    if (y < targetY)
                                    {
                                        openList[x, y][i].H = (x - targetX) + (targetY - y);
                                    }
                                    if (y > targetY)
                                    {
                                        openList[x, y][i].H = (x - targetX) + (y - targetY);
                                    }
                                }
                                openList[x, y - 1][i].F = openList[x, y - 1][i].G + openList[x, y - 1][i].H;
                            }
                            #endregion
                            #region diagonal
                            if (Game1.map.interactiveLayer[x - 1, y - 1].isPassable)
                            {
                                openList[x - 1, y - 1].Add(new Node());
                                openList[x - 1, y - 1][i].G = 14;
                                if (x < targetX)
                                {
                                    if (y < targetY)
                                    {
                                        openList[x, y][i].H = (targetX - x) + (targetY - y);
                                    }
                                    if (y > targetY)
                                    {
                                        openList[x, y][i].H = (targetX - x) + (y - targetY);
                                    }
                                }
                                else
                                {
                                    if (y < targetY)
                                    {
                                        openList[x, y][i].H = (x - targetX) + (targetY - y);
                                    }
                                    if (y > targetY)
                                    {
                                        openList[x, y][i].H = (x - targetX) + (y - targetY);
                                    }
                                }
                                openList[x - 1, y - 1][i].F = openList[x - 1, y - 1][i].G + openList[x - 1, y - 1][i].H;
                            }
                            if (Game1.map.interactiveLayer[x + 1, y - 1].isPassable)
                            {
                                openList[x + 1, y - 1].Add(new Node());
                                openList[x + 1, y - 1][i].G = 14;
                                if (x < targetX)
                                {
                                    if (y < targetY)
                                    {
                                        openList[x, y][i].H = (targetX - x) + (targetY - y);
                                    }
                                    if (y > targetY)
                                    {
                                        openList[x, y][i].H = (targetX - x) + (y - targetY);
                                    }
                                }
                                else
                                {
                                    if (y < targetY)
                                    {
                                        openList[x, y][i].H = (x - targetX) + (targetY - y);
                                    }
                                    if (y > targetY)
                                    {
                                        openList[x, y][i].H = (x - targetX) + (y - targetY);
                                    }
                                }
                                openList[x + 1, y - 1][i].F = openList[x + 1, y - 1][i].G + openList[x + 1, y - 1][i].H;
                            }
                            if (Game1.map.interactiveLayer[x - 1, y + 1].isPassable)
                            {
                                openList[x - 1, y + 1].Add(new Node());
                                openList[x - 1, y + 1][i].G = 14;
                                if (x < targetX)
                                {
                                    if (y < targetY)
                                    {
                                        openList[x, y][i].H = (targetX - x) + (targetY - y);
                                    }
                                    if (y > targetY)
                                    {
                                        openList[x, y][i].H = (targetX - x) + (y - targetY);
                                    }
                                }
                                else
                                {
                                    if (y < targetY)
                                    {
                                        openList[x, y][i].H = (x - targetX) + (targetY - y);
                                    }
                                    if (y > targetY)
                                    {
                                        openList[x, y][i].H = (x - targetX) + (y - targetY);
                                    }
                                }
                                openList[x - 1, y + 1][i].F = openList[x - 1, y + 1][i].G + openList[x - 1, y + 1][i].H;
                            }
                            if (Game1.map.interactiveLayer[x + 1, y + 1].isPassable)
                            {
                                openList[x + 1, y + 1].Add(new Node());
                                openList[x + 1, y + 1][i].G = 14;
                                if (x < targetX)
                                {
                                    if (y < targetY)
                                    {
                                        openList[x, y][i].H = (targetX - x) + (targetY - y);
                                    }
                                    if (y > targetY)
                                    {
                                        openList[x, y][i].H = (targetX - x) + (y - targetY);
                                    }
                                }
                                else
                                {
                                    if (y < targetY)
                                    {
                                        openList[x, y][i].H = (x - targetX) + (targetY - y);
                                    }
                                    if (y > targetY)
                                    {
                                        openList[x, y][i].H = (x - targetX) + (y - targetY);
                                    }
                                }
                                openList[x + 1, y + 1][i].F = openList[x + 1, y + 1][i].G + openList[x + 1, y + 1][i].H;
                            }
                            #endregion

                            //check the best node (lowest F)

                        }
                    }
                }
                //if (this node is the goal) 
                //{
                //    then we're done
                //}
                //else 
                //{
                //    move the current node to the closed list and consider all of its neighbors
                //    for (each neighbor) 
                //    {
                //        if (this neighbor is in the closed list and our current g value is lower) 
                //        {
                //            update the neighbor with the new, lower, g value 
                //            change the neighbor's parent to our current node
                //        }
                //        else if (this neighbor is in the open list and our current g value is lower) 
                //        {
                //            update the neighbor with the new, lower, g value 
                //            change the neighbor's parent to our current node
                //        }
                //        else this neighbor is not in either the open or closed list 
                //        {
                //            add the neighbor to the open list and set its g value
                //        }
                //    }
                //}
            }
        }
    }
}