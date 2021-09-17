using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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
        private readonly string pathToWavAlert;
        private readonly MediaPlayer mediaPlayer;

        public string Name { get; set; }
        public DispatcherTimer RestockTimer { get; set; }
        public FrameworkElement boundControl;
        public bool isAlarmEnabled;

        public Trader(string name, TimeSpan restockTime)
        {
            Name = name;
            isAlarmEnabled = true;
            RestockTimer = new DispatcherTimer();
            RestockTimer.Tick += new EventHandler((s, e) => PlaySound());
            RestockTimer.Interval = restockTime;

            pathToWavAlert = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $@"sounds\{name.ToLower(CultureInfo.InvariantCulture)}.wav");
            if (!File.Exists(pathToWavAlert))
            {
                pathToWavAlert = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $@"sounds\default.wav");
                if (!File.Exists(pathToWavAlert))
                {
                    // maybe should throw an Exception if default.wav doesn't exist?
                }
            }

            mediaPlayer = new();
            mediaPlayer.Volume = 5 / 100f;
        }

        public Trader(string name) :
            this(name, new TimeSpan(3, 0, 0))
        {

        }

        internal void SetTimerControl(FrameworkElement control)
        {
            boundControl = control;
            switch (control)
            {
                case TextBlock:
                    (control as TextBlock).Text = RestockTimer.Interval.ToString();
                    break;
                default:
                    break;
            }
        }

        public void StartRestockTimer()
        {
            RestockTimer.Start();
        }

        private void PlaySound()
        {
            if (isAlarmEnabled)
            {
                mediaPlayer.Open(new Uri(pathToWavAlert));
                mediaPlayer.Play();
                mediaPlayer.Close();
            }
        }
    }
}