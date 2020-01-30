using Salon.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using Salon.Views;

namespace Salon.ViewModels
{
    class FavoritesViewModel
    {
        public NavigateToFavoriteSalonistsPagePageCommand NavigateToFavoriteSalonistsPagePageCommand { get; set; }
        public NavigateToFavoriteProductsPageCommand NavigateToFavoriteProductsPageCommand { get; set; }
        public FavoritesViewModel()
        {
            NavigateToFavoriteSalonistsPagePageCommand = new NavigateToFavoriteSalonistsPagePageCommand(this);
            NavigateToFavoriteProductsPageCommand = new NavigateToFavoriteProductsPageCommand(this);
        }

        public async void NavigateToFavoriteSalonistsPagePage()
        {
            await App.Current.MainPage.Navigation.PushAsync(new FavoriteStylistsPage());
        }

        public async void NavigateToFavoriteProductsPage()
        {
            await App.Current.MainPage.Navigation.PushAsync(new  FavoriteProductsPage());
        }
    }
}
