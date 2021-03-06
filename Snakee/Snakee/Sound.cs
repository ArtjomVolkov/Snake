using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace Snakee
{
    public class Sound
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        private string pathToMedia;

        public Sound(string pathToResources)
        {
            pathToMedia = pathToResources;
        }
        public void Play()
        {
            player.URL = pathToMedia + "Stardust.mp3";
            player.settings.volume = 100;
            player.controls.play();
            player.settings.setMode("loop", true);
        }
        public void PlayEat()
        {
            player.URL = pathToMedia + "Eat.mp3";
            player.settings.volume = 50;
            player.controls.play();
        }
        public void Play(string songName)
        {
            player.URL = pathToMedia + songName + ".mp3";
            player.controls.play();
        }
        public void Deads()
        {
            player.URL = pathToMedia + "Dead.mp3";
            player.settings.volume = 100;
            player.controls.play();
        }
        
    }
}
