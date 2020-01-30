using System;
using Salon.ViewModels;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Salon.Commands
{

    class IsTermsAndConditionsCheckBoxCheckedCommand : ICommand
    {
        public SignUpViewModel  SignUpViewModel { get; set; }
        public event EventHandler CanExecuteChanged;
        public IsTermsAndConditionsCheckBoxCheckedCommand(SignUpViewModel  signUpViewModel)
        {
            SignUpViewModel = signUpViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            SignUpViewModel.CheckPolicy();
        }
    }
}
