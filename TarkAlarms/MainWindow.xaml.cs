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

            //foreach (Trader trader in Traders)
            //{
            //    switch (trader.Name)
            //    {
            //        case TraderNames.Prapor:
            //            break;
            //        default:
            //            break;
            //    }
            ////}

            //Traders.Add(new Trader(TraderNames.Prapor));
            //Traders.Add(new Trader(TraderNames.Therapist));
            //Traders.Add(new Trader(TraderNames.Fence));
            //Traders.Add(new Trader(TraderNames.Skier));
            //Traders.Add(new Trader(TraderNames.Peacekeeper));
            //Traders.Add(new Trader(TraderNames.Mechanic));
            //Traders.Add(new Trader(TraderNames.Ragman));
            //Traders.Add(new Trader(TraderNames.Jaeger));








            //{
            //    new Trader(, DateTime.Now.AddMinutes(5),DateTime.Now.AddMinutes(-20),new TimeSpan(0,25,0)),
            //    new Trader("Therapist", DateTime.Now.AddMinutes(5),DateTime.Now.AddMinutes(-20),new TimeSpan(0,25,0)),
            //    new Trader("Fence", DateTime.Now.AddMinutes(5),DateTime.Now.AddMinutes(-20),new TimeSpan(0,25,0)),
            //    new Trader("Skier", DateTime.Now.AddMinutes(5),DateTime.Now.AddMinutes(-20),new TimeSpan(0,25,0)),
            //    new Trader("Peacekeeper", DateTime.Now.AddMinutes(5),DateTime.Now.AddMinutes(-20),new TimeSpan(0,25,0)),
            //    new Trader("Mechanic", DateTime.Now.AddMinutes(5),DateTime.Now.AddMinutes(-20),new TimeSpan(0,25,0)),
            //    new Trader("Ragman", DateTime.Now.AddMinutes(5),DateTime.Now.AddMinutes(-20),new TimeSpan(0,25,0)),
            //    new Trader("Jaeger", DateTime.Now.AddMinutes(5),DateTime.Now.AddMinutes(-20),new TimeSpan(0,25,0)),
            //};



            //this.Traders = new Trader[]
            //{
            //    new Trader(TraderNames.Prapor),
            //    new Trader(TraderNames.Therapist),
            //    new Trader(TraderNames.Fence),
            //    new Trader(TraderNames.Skier),
            //    new Trader(TraderNames.Peacekeeper),
            //    new Trader(TraderNames.Mechanic),
            //    new Trader(TraderNames.Ragman),
            //    new Trader(TraderNames.Jaeger),
            //};

            //foreach (Trader trader in this.Traders)
            //{
            //    trader.RestockTimer.Tick += (s, e) => MainWindow.
            //    trader.StartRestockTimer();
            //}
        }

    }


}
