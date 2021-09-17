using System;
using System.Threading;
using System.Windows.Threading;

namespace TarkAlarms.HowLeeWouldDoit
{
    public class LeesTrader : FuckDependencyProperties
    {
        /// <summary>
        /// The name fo the trader. Ultimately irrelevant to the timer  other than looking pretty
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// When the timer last reset.
        /// </summary>
        public DateTime ResetTime { get; set; }

        /// <summary>
        /// How long the timer lasts
        /// </summary>
        public TimeSpan RestockTime { get; set; }

        /// <summary>
        /// If the timer will auto reset when it runs out
        /// </summary>
        public bool AutoReset { get; set; }

        /// <summary>
        /// If the timer will play noise when it resets
        /// </summary>
        public bool AudibleAlarm { get; set; }

        public double PercentageComplete
        {
            get => 1 - ((DateTime.UtcNow - ResetTime) / RestockTime);
        }

        private DispatcherTimer _internalTimer;

        private void TimerTick(object? state)
        {
            if (DateTime.UtcNow > (ResetTime + RestockTime))
            {
                _internalTimer.Stop();
                if (AutoReset) ResetTimer();
                if (AudibleAlarm) SoundPlayer.PlayDefault();
            }
        }

        LeesTrader()
        {
            
            _internalTimer = new DispatcherTimer(DispatcherPriority.Normal);
            _internalTimer.Interval = TimeSpan.FromSeconds(1);
            _internalTimer.Start();

        }

        public void ResetTimer(DateTime? resetTime = null)
        {
            _internalTimer.Stop();
            var actualResetTime = resetTime ?? DateTime.UtcNow;
            ResetTime = actualResetTime;
            _internalTimer.Start();
        }
    }
}
