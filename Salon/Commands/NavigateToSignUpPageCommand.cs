using Salon.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Salon.Commands
{
    class NavigateToSignUpPageCommand : ICommand
    {
        public IntroductionViewModel IntroductionViewModel { get; set; }
        public NavigateToSignUpPageCommand(IntroductionViewModel introductionViewModel)
        {
            IntroductionViewModel = introductionViewModel;
        }
        public event EventHandler CanExecuteChanged;
      
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            IntroductionViewModel.NavigateToCustomerSignUpPage();
        }
    }
}
