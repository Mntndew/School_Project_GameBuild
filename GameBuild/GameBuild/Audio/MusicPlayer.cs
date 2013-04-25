using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Media;

namespace GameBuild.Audio
{
    class MusicPlayer
    {
        IList<Song> songs;

        Random r;

        float songInterval; //specified in seconds

        float currentSongLength;
        float currentSongPlayTime;

        float FadeTime = 3000;

        public IList<Song> Songs
        {
            get { return songs; }
            set { songs = value; }
        }

        public MusicPlayer()
        {
            songs = new List<Song>();
            MediaPlayer.IsVisualizationEnabled = true;
            r = new Random();
        }

        public void Play(int Index)
        {
            MediaPlayer.Volume = 0; // for fading in and out
            MediaPlayer.Stop();
            //MediaPlayer.Play(songs[Index]);
            currentSongLength = (float)songs[Index].Duration.TotalMilliseconds;
            currentSongPlayTime = 0;
        }

        public void Pause()
        {
            MediaPlayer.Pause();
        }

        public void Stop()
        {
            MediaPlayer.Stop();
        }

        public void Update(GameTime gameTime)
        {
            if (MediaPlayer.State != MediaState.Playing)
            {
                songInterval -= (float)gameTime.ElapsedGameTime.TotalSeconds;
                if (songInterval <= 0)
                {
                    Play(r.Next(songs.Count));
                    songInterval = r.Next(0, 50);
                }
            }
            else if (MediaPlayer.State == MediaState.Playing)
            {
                float elapsed = (float)gameTime.ElapsedGameTime.TotalMilliseconds;
                currentSongPlayTime += elapsed;
                if (currentSongPlayTime <= FadeTime)
                {
                    MediaPlayer.Volume += elapsed/FadeTime/2;
                }
                else if (currentSongPlayTime + FadeTime >= currentSongLength)
                {
                    MediaPlayer.Volume -= elapsed/FadeTime/2;
                }
            }
        }
    }
}
