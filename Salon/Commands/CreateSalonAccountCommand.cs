using System;
using System.Windows.Input;
using Salon.ViewModels;

namespace Salon.Commands
{
    class CreateSalonAccountCommand : ICommand
    {
        public SalonOwnerViewModel SalonOwnerViewModel { get; set; }
        public CreateSalonAccountCommand(SalonOwnerViewModel salonOwnerViewModel)
        {
            SalonOwnerViewModel = salonOwnerViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            SalonOwnerViewModel.CreateSalonAccount();
        }
    }
}
