/*
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
