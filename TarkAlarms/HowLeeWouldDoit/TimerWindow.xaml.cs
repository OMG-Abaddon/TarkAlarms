using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TarkAlarms.Classes;

namespace TarkAlarms.HowLeeWouldDoit
{
    /// <summary>
    /// Interaction logic for TimerWindow.xaml
    /// </summary>
    public partial class TimerWindow : Window
    {

        public ObservableCollection<LeesTrader> Traders { get; set; } = new ObservableCollection<LeesTrader>();
        public TimerWindow()
        {
            InitializeComponent();

            Traders.Add(new LeesTrader{Name = "Trader 10s", RestockTime = TimeSpan.FromSeconds(10)});
            Traders.Add(new LeesTrader { Name = "Trader 1m", RestockTime = TimeSpan.FromMinutes(1) });
            Traders.Add(new LeesTrader { Name = "Trader 2m", RestockTime = TimeSpan.FromMinutes(2) });
            Traders.Add(new LeesTrader { Name = "Trader Unspecified"});
            Traders.Add(new LeesTrader());

        }
    }
}
