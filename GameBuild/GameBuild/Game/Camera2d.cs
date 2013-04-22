using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameBuild
{
    public class Camera2d
    {
        private const float zoomUpperLimit = 1.5f;
        private const float zoomLowerLimit = .1f;

        private float zoom;
        private Matrix transform;
        public Vector2 pos;
        private float rotation;
        private int viewportWidth;
        private int viewportHeight;
        private int worldWidth;
        private int worldHeight;

        public Camera2d(Viewport viewport, int worldWidth, int worldHeight, float initialZoom)
        {
            this.zoom = initialZoom;
            this.rotation = 0.0f;
            this.pos = Vector2.Zero;
            this.viewportWidth = viewport.Width;
            this.viewportHeight = viewport.Height;
            this.worldHeight = worldHeight;
            this.worldWidth = worldWidth;
        }

        #region Properties
        public float Zoom
        {
            get { return zoom; }
            set
            {
                zoom = value;
                if (zoom < zoomLowerLimit)
                    zoom = zoomLowerLimit;
                if (zoom > zoomUpperLimit)
                    zoom = zoomUpperLimit;
            }
        }

        public float Rotation
        {
            get { return rotation; }
            set { rotation = value; }
        }

        public void Move(Vector2 amount)
        {
            pos += amount;
        }
        public Vector2 Pos
        {
            get { return pos; }
            set
            {
                float leftBarrier = (float)viewportWidth * .5f / zoom;
                float rightBarrier = worldWidth - (float)viewportWidth * .5f / zoom;
                float topBarrier = worldHeight - (float)viewportHeight * .5f / zoom;
                float bottomBarrier = (float)viewportHeight * .5f / zoom;
                pos = value;
                if (pos.X < leftBarrier)
                    pos.X = leftBarrier;
                if (pos.X > rightBarrier)
                    pos.X = rightBarrier;
                if (pos.Y > topBarrier)
                    pos.Y = topBarrier;
                if (pos.Y < bottomBarrier)
                    pos.Y = bottomBarrier;
            }
        }
        #endregion

        public Rectangle GetCameraRectangle(int screenWidth, int screenHeight)
        {
            return new Rectangle((int)-Pos.X+ screenWidth, (int)-Pos.Y+screenHeight, viewportWidth, viewportHeight);
        }

        public Matrix GetTransformation()
        {
            transform = Matrix.CreateTranslation(new Vector3(-pos.X, -pos.Y, 0)) *
                Matrix.CreateRotationZ(Rotation) *
                Matrix.CreateScale(new Vector3(Zoom, Zoom, 1)) *
                Matrix.CreateTranslation(new Vector3(viewportWidth * 0.5f, viewportHeight * 0.5f, 0));
            return transform;
        }
    }
}
