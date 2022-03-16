﻿using System;
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

        public Sound()
        {
        }

        public Sound(string pathToResources)
        {
            pathToMedia = pathToResources;
        }
        public void Play()
        {
            player.URL = pathToMedia + "stardust.mp3";
            player.settings.volume = 100;
            player.controls.play();
            player.settings.setMode("loop", true);
        }
        public void Play(string songName)
        {
            player.URL = pathToMedia + songName + ".mp3";
            player.controls.play();
        }
        public void Deads()
        {
            player.URL = pathToMedia + "dead.mp3";
            player.settings.volume = 100;
            player.controls.play();
        }
        public void PlayEat()
        {
            player.URL = pathToMedia + "eating.mp3";
            player.settings.volume = 100;
            player.controls.play();
        }
    }
}