using Salon.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Salon.Commands
{
    class FinishedAddingSalonistCommand : ICommand
    {
        public SalonistAccountViewModel SalonistAccountViewModel { get; set; }
        public FinishedAddingSalonistCommand(SalonistAccountViewModel salonistAccountViewModel)
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
            SalonistAccountViewModel.FinishedAddingSalonists();
        }
    }
}
