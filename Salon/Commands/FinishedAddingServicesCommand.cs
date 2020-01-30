using Salon.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Salon.Commands
{
    class FinishedAddingServicesCommand : ICommand
    {
        public SalonOwnerServicesViewModel SalonOwnerServicesViewModel { get; set; }
        public FinishedAddingServicesCommand(SalonOwnerServicesViewModel salonOwnerServicesViewModel)
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
            SalonOwnerServicesViewModel.FinishedAddingServices();
        }
    }
}
