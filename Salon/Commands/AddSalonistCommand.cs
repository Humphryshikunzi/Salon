using Salon.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Salon.Commands
{
    class AddSalonistCommand : ICommand
    {
        public SalonistAccountViewModel SalonistAccountViewModel { get; set; }
        public AddSalonistCommand(SalonistAccountViewModel salonistAccountViewModel)
        {
            SalonistAccountViewModel = salonistAccountViewModel;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            SalonistAccountViewModel.AddSalonist();
        }
    }
}
