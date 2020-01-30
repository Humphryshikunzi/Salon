using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Salon.ViewModels
{
    class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public async void DisplayAlert(string title, string message, string okay)
        {
            await App.Current.MainPage.DisplayAlert(title, message, okay);
        }
        public async void DisplayActioSheet(string title, string cancel, string delete, params string[] others)
        {
            await App.Current.MainPage.DisplayActionSheet(title, cancel, delete, others);
        }
    }
}
