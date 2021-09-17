﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;

namespace TarkAlarms.Classes
{
    public static class Extension
    {
        // https://stackoverflow.com/questions/1110789/get-list-element-position-in-c-sharp-using-linq
        public static IEnumerable<int> FindEveryIndex<T>(this IEnumerable<T> items,
                                                         Predicate<T> predicate)
        {
            int index = 0; bool found = false;
            foreach (var item in items)
            {
                if (predicate(item))
                {
                    found = true; yield return index;
                };
                index++;
            }
            if (!found) yield return -1;
        }

        public static int FirstIndexOf<T>(this IEnumerable<T> collection, string value)
        {
            int index = 0;
            foreach (T item in collection)
            {
                if (item.ToString() == value)
                {
                    return index;
                };
                index++;
            }
            return -1;
        }
    }


    public class Trader
    {
        private static string defaultSoundFile = "default";
        private string pathWavAlert;

        public string Name { get; set; }
        public DispatcherTimer RestockTimer { get; set; }


        public Trader(string name, TimeSpan restockTime)
        {
            Name = name;
            RestockTimer = new DispatcherTimer();
            RestockTimer.Interval = restockTime;

            pathWavAlert = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, $@"sounds\default.wav");
        }

        internal void SetTimerControl(TextBlock textBlock)
        {
            RestockTimer.Tick += new EventHandler((s, e) => PlaySound());
        }

        public Trader(string name) :
            this(name, new TimeSpan(24, 0, 0))
        {

        }

        public void StartRestockTimer()
        {
            RestockTimer.Start();
        }

        private void PlaySound()
        {
            using (SoundPlayer soundPlayer = new SoundPlayer())
            {
                soundPlayer.SoundLocation = pathWavAlert;
                soundPlayer.Load();
                soundPlayer.Play();
            }
        }
    }
}