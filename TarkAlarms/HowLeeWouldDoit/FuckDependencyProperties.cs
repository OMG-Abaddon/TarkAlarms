using System.ComponentModel;
using System.Runtime.CompilerServices;
using TarkAlarms.HowLeeWouldDoit.Annotations;

namespace TarkAlarms.HowLeeWouldDoit
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
