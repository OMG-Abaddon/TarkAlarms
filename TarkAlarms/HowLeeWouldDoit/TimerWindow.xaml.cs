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
        }
    }
}
