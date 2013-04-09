using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace GameBuild.Pathfinding
{
    static class PathFinder
    {
        public static int diagonals = 0;
        public static int horver = 0;
        public static int closedListLength = 0;
        public static int openListLength = 0;

        public static Point[] FindPath(int[,] map, Point startPoint, Point endPoint)
        {
            diagonals = 0;
            horver = 0;
            closedListLength = 0;
            openListLength = 0;
            List<Node> openList = new List<Node>();
            List<Node> closedList = new List<Node>();

            openList.Add(new Node(startPoint, 0, 0, null));

            bool foundPath = false;
            while (!foundPath && openList.Count > 0)
            {
                Node q = GetLowestFNode(openList);
                openList.Remove(q);

                Node[] successors = GetSuccessors(map, q, endPoint);
                int endNodeIndex = 0;
                for (int i = 0; i < successors.Length; i++)
                {
                    if (successors[i].Position == endPoint)
                    {
                        foundPath = true;
                        endNodeIndex = i;
                        break;
                    }
                    bool exited = false;
                    for (int j = 0; j < openList.Count; j++)
                    {
                        if (successors[i].Position == openList[j].Position && successors[i].F < openList[j].F)
                        {
                            exited = true;
                            openList.Add(successors[i]);
                            break;
                        }
                    }
                    if (!exited)
                    {
                        for (int j = 0; j < closedList.Count; j++)
                        {
                            if (successors[i].Position == closedList[j].Position && successors[i].F > closedList[j].F)
                            {
                                exited = true;
                                break;
                            }
                        }
                    }
                    if (!exited)
                    {
                        openList.Add(successors[i]);
                    }
                }

                closedList.Add(q);

                if (foundPath)
                {
                    closedList.Add(successors[endNodeIndex]);
                    break;
                }
            }
            openListLength = openList.Count;
            closedListLength = closedList.Count;
            if (openList.Count == 0)
            {
                return NoPath();
            }
            return GetPath(closedList, startPoint);
        }

        private static Node GetLowestFNode(List<Node> l)
        {
            Node n = l[0];
            for (int i = 1; i < l.Count; i++)
            {
                Node n2 = l[i];
                if (n.F > n2.F)
                {
                    n = n2;
                }
            }
            return n;
        }

        private static Node[] GetSuccessors(int[,] map, Node n, Point endPoint)
        {
            List<Node> tempList = new List<Node>();
            for (int x = -1; x < 2; x++)
            {
                for (int y = -1; y < 2; y++)
                {
                    if (!(x == 0 && y == 0))
                    {
                        if (n.Position.X - x >= 0 && n.Position.X - x < map.GetLength(1) && n.Position.Y - y >= 0 && n.Position.Y - y < map.GetLength(0))
                        {
                            if (map[n.Position.X - x, n.Position.Y - y] != 1)
                            {
                                if (x == 0 || y == 0)
                                {
                                    Point p = new Point(n.Position.X - x, n.Position.Y - y);
                                    int h = (Math.Abs(endPoint.X - p.X) + Math.Abs(endPoint.Y - p.Y)) * 10;
                                    tempList.Add(new Node(p, n.G + 10, h, n));
                                    horver++;
                                }
                                else
                                {
                                    Point p = new Point(n.Position.X - x, n.Position.Y - y);
                                    int h = (Math.Abs(endPoint.X - p.X) + Math.Abs(endPoint.Y - p.Y)) * 10;
                                    tempList.Add(new Node(p, n.G + 14, h, n));
                                    diagonals++;
                                }
                            }
                        }
                    }
                }
            }
            return tempList.ToArray();
        }

        private static Point[] GetPath(List<Node> list, Point startPos)
        {
            List<Point> p = new List<Point>();
            p.Add(list[list.Count - 1].Position);
            if (list.Count - 2 > 0)
            {
                Node currentN = list[list.Count - 2];
                while (currentN.Position != startPos)
                {
                    p.Add(currentN.Position);
                    currentN = currentN.ParentNode;
                }
            }
            return p.ToArray();
        }

        private static Point[] NoPath()
        {
            Point[] p = { new Point(-1, -1) };
            return p;
        }

        public static Vector2[] GetVectorPath(Point[] path, float nodeWidth, float nodeHeight)
        {
            Vector2[] vPath = new Vector2[path.Length];
            for (int i = 0; i < vPath.Length; i++)
            {
                vPath[i] = path[i].ToVector(nodeWidth, nodeHeight);
            }
            return vPath;
        }
    }
}
