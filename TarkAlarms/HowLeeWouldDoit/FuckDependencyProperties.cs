using System.ComponentModel;
using System.Runtime.CompilerServices;
using TarkAlarms.Traders.Annotations;

namespace TarkAlarms.Traders
{
    public abstract class FuckDependencyProperties : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void Updated([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
