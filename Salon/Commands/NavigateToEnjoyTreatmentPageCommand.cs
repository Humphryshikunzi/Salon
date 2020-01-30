using System;
using Salon.ViewModels;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Salon.Commands
{
    class NavigateToEnjoyTreatmentPageCommand : ICommand
    {
        IntroductionViewModel IntroductionViewModel { get; set; }
        public NavigateToEnjoyTreatmentPageCommand(IntroductionViewModel introductionViewModel)
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
            IntroductionViewModel.NavigateToEnjoyTreatmentPage();
        }
    }
}
