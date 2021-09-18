using System.Windows;
using TarkAlarms.Traders;

namespace TarkAlarms
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //public List<Trader> Traders { get; private set; }

        //public List<string> TraderData = new List<string>()
        //{
        //    "Prapor",
        //    "Therapist",
        //    "Fence",
        //    "Skier",
        //    "Peacekeeper",
        //    "Mechanic",
        //    "Ragman",
        //    "Jaeger",
        //};


        public MainWindow()
        {
            InitializeComponent();
            //InitializeApp();
        }

        //        private void InitializeApp()
        //        {
        //            Traders = new List<Trader>();
        //            Trader prapor = new Trader("Prapor"),
        //                therapist = new Trader("Therapist"),
        //                fence = new Trader("Fence"),
        //                skier = new Trader("Skier"),
        //                peacekeeper = new Trader("Peacekeeper"),
        //                mechanic = new Trader("Mechanic"),
        //                ragman = new Trader("Ragman"),
        //                jaeger = new Trader("Jaeger");
        //#if DEBUG
        //            prapor.RestockTimer.Interval = new TimeSpan(0, 0, 5); //test
        //#endif
        //            prapor.SetTimerControl(txbClockPrapor);
        //            therapist.SetTimerControl(txbClockTherapist);
        //            fence.SetTimerControl(txbClockFence);
        //            skier.SetTimerControl(txbClockSkier);
        //            peacekeeper.SetTimerControl(txbClockPeacekeeper);
        //            mechanic.SetTimerControl(txbClockMechanic);
        //            ragman.SetTimerControl(txbClockRagman);
        //            jaeger.SetTimerControl(txbClockJaeger);

        //            prapor.StartRestockTimer();
        //            therapist.StartRestockTimer();
        //            fence.StartRestockTimer();
        //            skier.StartRestockTimer();
        //            peacekeeper.StartRestockTimer();
        //            mechanic.StartRestockTimer();
        //            ragman.StartRestockTimer();
        //            jaeger.StartRestockTimer();


        //        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new TimerWindow().Show();
        }
    }
}
