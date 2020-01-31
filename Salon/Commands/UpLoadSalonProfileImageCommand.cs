using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Salon.ViewModels;

namespace Salon.Commands
{
    class UpLoadSalonProfileImageCommand : ICommand
    {
        public  SalonOwnerViewModel  SalonOwnerViewModel { get; set; }
        public UpLoadSalonProfileImageCommand(SalonOwnerViewModel salonOwnerViewModel)
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
            SalonOwnerViewModel.UpLoadSalonProfileImage();
        }
    }
}
