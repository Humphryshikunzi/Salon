using Salon.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Salon.Commands
{
    class NavigateToSaveFavoritesPageCommand : ICommand
    {
        public IntroductionViewModel IntroductionViewModel { get; set; }
        public NavigateToSaveFavoritesPageCommand(IntroductionViewModel  introductionViewModel)
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
            IntroductionViewModel.NavigateToSaveFavoritesPage();
        }
    }
}
