using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace GameBuild.Pathfinding
{
    public struct Point
    {
        int x;
        int y;
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static bool operator ==(Point p1, Point p2)
        {
            if (p1.X == p2.X && p1.Y == p2.Y)
            {
                return true;
            }
            else
                return false;
        }

        public static bool operator !=(Point p1, Point p2)
        {
            if (p1.X == p2.X && p1.Y == p2.Y)
            {
                return false;
            }
            else
                return true;
        }

        public Vector2 ToVector()
        {
            return new Vector2(x, y);
        }
        public Vector2 ToVector(float width, float height)
        {
            return new Vector2(x*width, y*height);
        }
    }

    class Node
    {
        Point position;
        Node parent;

        public int F; // total cost
        public int G; // movement cost
        public int H; // estimated goal cost

        public Point Position
        {
            get { return position; }
        }
        public Node ParentNode
        {
            get { return parent; }
            set { this.parent = value; }
        }

        public Node(Point position, int g, int h, Node parent)
        {
            this.position = position;
            this.parent = parent;
            G = g;
            H = h;
            F = G + H;
        }
    }
}
    