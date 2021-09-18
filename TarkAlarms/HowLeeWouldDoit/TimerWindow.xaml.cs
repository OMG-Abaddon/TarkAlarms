using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace TarkAlarms.Traders
{
    /// <summary>
    /// Interaction logic for TimerWindow.xaml
    /// </summary>
    public partial class TimerWindow : Window
    {

        public ObservableCollection<Trader> Traders { get; set; } = new ObservableCollection<Trader>();
        public TimerWindow()
        {
            InitializeComponent();

            Traders.Add(new Trader{Name = "Trader 10s", RestockTime = TimeSpan.FromSeconds(10)});
            Traders.Add(new Trader { Name = "Trader 1m", RestockTime = TimeSpan.FromMinutes(1) });
            Traders.Add(new Trader { Name = "Trader 2m", RestockTime = TimeSpan.FromMinutes(2) });
            Traders.Add(new Trader { Name = "Trader Unspecified"});
            Traders.Add(new Trader());

        }
    }
}
