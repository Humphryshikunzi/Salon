using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Salon.ViewModels;

namespace Salon.Commands
{
    class UpLoadServiceImageCommand : ICommand
    {
        public  SalonOwnerServicesViewModel  SalonOwnerServicesViewModel { get; set; }
        public UpLoadServiceImageCommand(SalonOwnerServicesViewModel salonOwnerServicesViewModel)
        {
            SalonOwnerServicesViewModel = salonOwnerServicesViewModel;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            SalonOwnerServicesViewModel.UpLoadServiceImage();
        }
    }
}
