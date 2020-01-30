using System;
using System.Collections.Generic;
using System.Text;
using Salon.Commands;
using Salon.Views;

namespace Salon.ViewModels
{
    class OrdersViewModel
    {
        public NavigateToAppointmentsPageCommand NavigateToAppointmentsPageCommand { get; set; }
        public NavigateToProductsPageCommand NavigateToProductsPageCommand { get; set; }
        public OrdersViewModel()
        {
            NavigateToAppointmentsPageCommand = new NavigateToAppointmentsPageCommand(this);
            NavigateToProductsPageCommand = new NavigateToProductsPageCommand(this);
        }

        public async void NavigateToAppointmentsPage()
        {
            await App.Current.MainPage.Navigation.PushAsync(new AppointmentsPage());
        }
        public async void NavigateToProductsPage()
        {
            await App.Current.MainPage.Navigation.PushAsync(new OrderedProductsPage());
        }

    }
}
