using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ClientXMessanger.Libs
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        #region Basic Event
        /// <summary>
        /// Base event Property Changeing
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion 

        #region Public Members
        /// <summary>
        /// Change the property by the name
        /// </summary>
        /// <param name="PropertyName">The Property string FullName</param>
        public virtual void OnPropertyChanged([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        public virtual bool Set<T>(ref T field, T value, [CallerMemberName] string PropertyName = null)
        {
            // If them the same return false
            if (Equals(field, value))
                return false;

            // Change value
            field = value;

            // Enter changing
            OnPropertyChanged(PropertyName);

            // Go back    
            return true;
        }
        #endregion
    }
}
