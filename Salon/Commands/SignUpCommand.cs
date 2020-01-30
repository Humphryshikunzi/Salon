using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Salon.ViewModels;

namespace Salon.Commands
{
    class SignUpCommand : ICommand
    {
        public SignUpViewModel SignUpViewModel { get; set; }
        public SignUpCommand(SignUpViewModel signUpViewModel)
        {
            SignUpViewModel = signUpViewModel;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            SignUpViewModel.AddCustomer();
        }
    }
}
