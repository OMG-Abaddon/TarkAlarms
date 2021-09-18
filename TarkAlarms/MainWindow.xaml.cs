using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using TarkAlarms.Traders;

namespace TarkAlarms
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Trader> Traders { get; set; } = new ObservableCollection<Trader>();

        public List<string> AvailableTraders = new List<string>()
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


        public MainWindow()
        {
            InitializeComponent();
            AddTraders();
        }

        private void AddTraders()
        {
#if DEBUG
            Traders.Add(new Trader { Name = "TEST 2 seconds", RestockTime = TimeSpan.FromSeconds(2) });
#endif
            foreach (var traderName in AvailableTraders)
            {
                Traders.Add(new Trader { Name = traderName });
            }
        }
    }
}
