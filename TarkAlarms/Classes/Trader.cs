using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace TarkAlarms.Classes
{
    public enum TraderNames
    {
        Prapor,
        Therapist,
        Fence,
        Skier,
        Peacekeeper,
        Mechanic,
        Ragman,
        Jaeger,

    }

    public class Trader
    {


        public string Name { get; private set; }
        public DateTime LastRestock { get; set; }
        public DateTime NextRestock { get; set; }
        public TimeSpan RestockTime { get; set; }

        public Trader(string name, DateTime nextRestock, DateTime lastRestock, TimeSpan restockTime)
        {
            Name = name;
            LastRestock = lastRestock;
            NextRestock = nextRestock;
            RestockTime = restockTime;
        }

        public Trader(string name) : this(name, DateTime.MaxValue, DateTime.Now, TimeSpan.MaxValue)
        {

        }

        public Trader(TraderNames name) : this(name.ToString())
        {

        }

        //public Trader(string name, DateTime nextRestock, DateTime lastRestock) 
        //    : this(name, nextRestock, DateTime.MaxValue, TimeSpan.Zero) { }

        //public Trader(string name, DateTime nextRestock) 
        //    : this(name, nextRestock, DateTime.MaxValue) { }

        //public Trader(string name) 
        //    : this(name, DateTime.MaxValue) { }

    }
}
