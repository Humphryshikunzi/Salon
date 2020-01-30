using Salon.Views;
using Salon.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Salon.ViewModels
{
    class IntroductionViewModel
    {
        public SkipIntroductionCommand SkipIntroductionCommand { get; set; }
        public NavigateToEnjoyTreatmentPageCommand NavigateToEnjoyTreatmentCommand { get; set; }
        public NavigateToSaveFavoritesPageCommand NavigateToSaveYourFavoriteCommand { get; set; }
        public NavigateToSignUpPageCommand NavigateToSignUpPageCommand { get; set; }

        public IntroductionViewModel()
        {
            SkipIntroductionCommand = new SkipIntroductionCommand(this);
            NavigateToEnjoyTreatmentCommand = new NavigateToEnjoyTreatmentPageCommand(this);
            NavigateToSaveYourFavoriteCommand = new NavigateToSaveFavoritesPageCommand(this);
            NavigateToSignUpPageCommand = new NavigateToSignUpPageCommand(this);
        }              

        public async void SkipIntroductionPage()
        {
            await App.Current.MainPage.Navigation.PushAsync(new SignUpPage());
        }
        public async void NavigateToSaveFavoritesPage()
        {
            await App.Current.MainPage.Navigation.PushAsync(new SaveFavoritesPage());
        }
        public async void NavigateToEnjoyTreatmentPage()
        {
            await App.Current.MainPage.Navigation.PushAsync(new EnjoyTreatmentPage());
        }
        public async void NavigateToCustomerSignUpPage()
        {
            await App.Current.MainPage.Navigation.PushAsync(new SignUpPage());
        }
    }
}
