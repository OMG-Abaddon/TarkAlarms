using System.Windows;
using System.Timers;
using System;
using System.Collections.Generic;
using TarkAlarms.Classes;

namespace TarkAlarms
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Timer RestockTimer { get; set; }
        private Trader[] _Traders;

        public Trader[] Traders
        {
            get { return _Traders; }
            set { _Traders = value; }
        }

        // Using a DependencyProperty as the backing store for Traders.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TradersProperty =
            DependencyProperty.Register("Traders", typeof(Trader[]), typeof(ownerclass), new PropertyMetadata(0));




        public MainWindow()
        {
            InitializeComponent();
        }

        private void InitializeApp()
        {
            _Traders = new Trader[]
            {
                new Trader(TraderNames.Prapor),
                new Trader(TraderNames.Therapist),
                new Trader(TraderNames.Fence),
                new Trader(TraderNames.Skier),
                new Trader(TraderNames.Peacekeeper),
                new Trader(TraderNames.Mechanic),
                new Trader(TraderNames.Ragman),
                new Trader(TraderNames.Jaeger),
            };

            RestockTimer.Start();
            //RestockTimer.
        }
    }


}
