using System;
using System.DirectoryServices.ActiveDirectory;
using System.Threading;
using System.Windows.Threading;

namespace TarkAlarms.HowLeeWouldDoit
{
    public class LeesTrader : FuckDependencyProperties
    {
        /// <summary>
        /// The name fo the trader. Ultimately irrelevant to the timer  other than looking pretty
        /// </summary>
        public string Name { get; set; } = Guid.NewGuid().ToString();

        /// <summary>
        /// When the timer last reset.
        /// </summary>
        public DateTime ResetTime { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// How long the timer lasts
        /// </summary>
        public TimeSpan RestockTime { get; set; } = TimeSpan.FromMinutes(1);

        /// <summary>
        /// If the timer will auto reset when it runs out
        /// </summary>
        public bool AutoReset { get; set; } = false;

        /// <summary>
        /// If the timer will play noise when it resets
        /// </summary>
        public bool AudibleAlarm { get; set; } = true;

        /// <summary>
        /// How far through the restock cycle are we
        /// </summary>
        public double PercentageComplete => 1 - (TimeRemaining / RestockTime);

        /// <summary>
        /// Remaining time
        /// </summary>
        public TimeSpan TimeRemaining => RestockTime - (DateTime.UtcNow - ResetTime);

        private DispatcherTimer _internalTimer;

        public LeesTrader()
        {
            
            _internalTimer = new DispatcherTimer(DispatcherPriority.Normal);
            _internalTimer.Interval = TimeSpan.FromSeconds(1);
            _internalTimer.Tick += TimerTick;
            _internalTimer.Start();

        }

        private void TimerTick(object? sender, EventArgs e)
        {
            if (DateTime.UtcNow > (ResetTime + RestockTime))
            {
                _internalTimer.Stop();
                if (AutoReset) ResetTimer();
                if (AudibleAlarm) SoundPlayer.PlayDefault();
            }
        }

        private void UpdateBindings()
        {
            //This is bad WPF, because you should really do this inside the properties but I can't be botehred redoign them now
            Updated(nameof(TimeRemaining));
            Updated(nameof(PercentageComplete));
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
