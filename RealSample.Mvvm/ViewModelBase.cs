using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace RealSample.Mvvm
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged ≥…‘±

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        public void RaisePropertyChanged(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propName));
            }
        }
    }
}
