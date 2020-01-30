﻿using Salon.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Salon.Commands
{
    class NavigateToFavoriteSalonistsPagePageCommand : ICommand
    {
        public FavoritesViewModel FavoritesViewModel { get; set; }
        public NavigateToFavoriteSalonistsPagePageCommand(FavoritesViewModel favoritesViewModel)
        {
            FavoritesViewModel = favoritesViewModel;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            FavoritesViewModel.NavigateToFavoriteSalonistsPagePage();
        }
    }
}
