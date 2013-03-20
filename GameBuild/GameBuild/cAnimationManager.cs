using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameBuild
{
    class cAnimationManager
    {
        Dictionary<string, cAnimation> animationList;
        Texture2D spriteSheet;
        int frameCountX, frameCountY;
        string currentAnimation;
        int currentFrame;
        bool play;
        float timeToFrameUpdate = 0.0f;
        public cAnimationManager(Texture2D SpriteSheet, int FrameCountX, int FrameCountY)
        {
            animationList = new Dictionary<string, cAnimation>();
            
            currentAnimation = "idle";
            spriteSheet = SpriteSheet;
            frameCountX = FrameCountX;
            frameCountY = FrameCountY;
            AddAnimation(0, false, new Vector2(0, 0), 1, "idle", false);
        }

        public void AddAnimation(float FrameSpeed, bool Loop, Vector2 StartPosition, int Frames, string animationName, bool playFromStart)
        {
            cAnimation animation = new cAnimation(FrameSpeed, Frames, spriteSheet.Width/frameCountX, spriteSheet.Height/frameCountY, Loop, StartPosition, playFromStart);
            animationList.Add(animationName, animation);
        }

        public void StartAnimation(string animationName)
        {
            currentAnimation = animationName;
            if (animationList[animationName].playFromStart)
            {
                currentFrame = 0;
            }
            play = true;
        }

        public void StopAnimation()
        {
            play = false;
            currentFrame = 0;
        }

        public void UpdateFrame(GameTime gameTime)
        {
            if (play)
            {
                
                timeToFrameUpdate -= gameTime.ElapsedGameTime.Milliseconds;
                if (timeToFrameUpdate <= 0)
                {
                    currentFrame++;
                    
                    timeToFrameUpdate = animationList[currentAnimation].frameSpeed;
                    if (currentFrame == animationList[currentAnimation].frames && animationList[currentAnimation].isLoop)
                    {
                        currentFrame = 0;
                    }
                    else if (currentFrame > animationList[currentAnimation].frames)
                    {
                        currentFrame = 0;
                        play = false;
                    }
                }
            }
        }
        public void Draw(SpriteBatch spriteBatch, Rectangle positionRectangle)
        {
            spriteBatch.Draw(spriteSheet, positionRectangle, animationList[currentAnimation].frameRectangles[currentFrame], Color.White);
        }
    }
}
