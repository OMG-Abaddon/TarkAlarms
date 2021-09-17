using System.Windows;
using System.Timers;
using System;
using System.Collections.Generic;
using TarkAlarms.Classes;
using System.Windows.Threading;
using System.Diagnostics;
using System.Windows.Controls;
using System.Linq;

namespace TarkAlarms
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer restockTimer;

        public List<Trader> Traders { get; private set; }

        public List<string> TraderData = new List<string>()
        {
            "Prapor",
            "Therapist",
            "Fence",
            "Skier",
            "Peacekeeper",
            "Mechanic",
            "Ragman",
            "Jaeger",
        };

        //public List<string> TraderDictionary = new Dictionary<int, string>()
        //    {
        //        {0,"Prapor"},
        //        {1,"Therapist"},
        //        {2,"Fence"},
        //        {3,"Skier"},
        //        {4,"Peacekeeper"},
        //        {5,"Mechanic"},
        //        {6,"Ragman"},
        //        {7,"Jaeger"},

        //    };

        public MainWindow()
        {
            InitializeComponent();
            InitializeApp();
        }

        private void InitializeApp()
        {
            Traders = new List<Trader>();
            Trader prapor = new Trader("Prapor"),
                therapist = new Trader("Therapist"),
                fence = new Trader("Fence"),
                skier = new Trader("Skier"),
                peacekeeper = new Trader("Peacekeeper"),
                mechanic = new Trader("Mechanic"),
                ragman = new Trader("Ragman"),
                jaeger = new Trader("Jaeger");

            prapor.SetTimerControl(txbClockPrapor);
            prapor.RestockTimer.Interval = new TimeSpan(0, 0, 2);
            prapor.StartRestockTimer();

        }

    }


}
