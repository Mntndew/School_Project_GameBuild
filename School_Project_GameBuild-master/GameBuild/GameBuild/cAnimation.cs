using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace GameBuild
{
    class cAnimation
    {
        public int frames;
        public int frameWidth, frameHeight;
        public bool isLoop;
        public bool playFromStart;
        public float frameSpeed; //delay between frames, in milliseconds
        public Rectangle[] frameRectangles;

        public cAnimation(float FrameSpeed, int Frames, int FrameWidth, int FrameHeight, bool Loop, Vector2 StartPos, bool PlayFromStart)
        {
            frames = Frames;
            frameSpeed = FrameSpeed;
            frameHeight = FrameHeight;
            frameWidth = FrameWidth;
            isLoop = Loop;
            playFromStart = PlayFromStart;
            frameRectangles = new Rectangle[frames];
            for (int i = 0; i < frames; i++)
            {
                frameRectangles[i] = new Rectangle((int)StartPos.X+(i*frameWidth), (int)StartPos.Y, frameWidth, frameHeight);
            }
        }
    }
}
