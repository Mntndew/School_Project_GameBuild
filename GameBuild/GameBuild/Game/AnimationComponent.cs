using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace GameBuild
{
    class AnimationComponent
    {
        #region Declarations
        bool playing;
        bool loop;
        //bool paused; //never used, only set

        int spriteSheetWidth, spriteSheetHeight;
        int frameWidth, frameHeight;

        Point defaultFrame;
        public Point currentFrame;

        int maxFrameCount;

        float frameDelay; //milliseconds
        float timer;

        const float DEFAULT_DELAY = 50;

        public int MaxFrameCount
        {
            get { return maxFrameCount; }
            set { maxFrameCount = value; }
        }
        #endregion

        #region Constructors
        public AnimationComponent(int spriteSheetWidth, int spriteSheetHeight, int frameWidth, int frameHeight)
        {
            this.spriteSheetWidth = spriteSheetWidth;
            this.spriteSheetHeight = spriteSheetHeight;
            this.frameWidth = frameWidth;
            this.frameHeight = frameHeight;
            this.frameDelay = DEFAULT_DELAY;
            timer = 0;

            this.defaultFrame = Point.Zero;
            currentFrame = defaultFrame;

            playing = false;
            loop = false;
            //paused = false;

            maxFrameCount = spriteSheetWidth;
        }

        public AnimationComponent(int spriteSheetWidth, int spriteSheetHeight, int frameWidth, int frameHeight, float frameDelay, Point defaultFrame)
        {
            this.spriteSheetWidth = spriteSheetWidth;
            this.spriteSheetHeight = spriteSheetHeight;
            this.frameWidth = frameWidth;
            this.frameHeight = frameHeight;
            this.frameDelay = frameDelay;
            timer = 0;

            this.defaultFrame = defaultFrame;
            currentFrame = defaultFrame;

            playing = false;
            loop = false;
            //paused = false;

            maxFrameCount = spriteSheetWidth-1; //cuz the points work off of a Zero based index
        }
        #endregion

        private Rectangle PointToFrame(Point p)
        {
            return new Rectangle(p.X*frameWidth, p.Y*frameHeight, frameWidth, frameHeight);
        }

        public void UpdateAnimation(GameTime gameTime)
        {
            if (playing)
            {
                timer += (float)gameTime.ElapsedGameTime.TotalMilliseconds;
                if (timer > frameDelay)
                {
                    ResetTimer();
                    currentFrame.X++;
                    
                    if (currentFrame.X > maxFrameCount && loop)
                    {
                        currentFrame.X = 0;
                    }
                    else if (currentFrame.X > maxFrameCount)
                    {
                        StopAnimation();
                    }
                }
            }
        }

        public bool IsAnimationPlaying(int animation)
        {
            if (currentFrame.Y == animation && playing)
                return true;
            else
                return false;
        }

        private void ResetTimer()
        {
            timer = 0;
        }

        public void PlayAnimation(int animation)
        {
            if (animation < spriteSheetHeight)
            {
                ResetTimer();
                currentFrame.Y = animation;
                currentFrame.X = 0;
                playing = true;
                loop = false;
            }
            else
            {
                //ExceptionAnimationOutOfBounds();
            }
        }

        public void LoopAnimation(int animation)
        {
            //paused = false;
            if (animation < spriteSheetHeight)
            {
                currentFrame.Y = animation;
                currentFrame.X = 0;
                playing = true;
                loop = true;
            }
            else
            {
                //ExceptionAnimationOutOfBounds();
            }
        }

        public void StopAnimation()
        {
            playing = false;
            loop = false;
            currentFrame = defaultFrame;
            ResetTimer();
        }

        public void PauseAnimation()
        {
            playing = false;
            //paused = true;
        }

        public void ResumeAnimation()
        {
            playing = true;
            //paused = false;
        }

        public void ResetAnimation()
        {
            playing = false;
            currentFrame.X = 0;
        }

        public Rectangle GetFrame()
        {
            return PointToFrame(currentFrame);
        }

        private void ExceptionAnimationOutOfBounds()
        {
            throw new Exception("Animation is out of bounds of the sprite sheet.");
        }
    }
}
