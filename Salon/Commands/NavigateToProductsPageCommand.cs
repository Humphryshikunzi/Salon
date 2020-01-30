using Salon.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Salon.Commands
{
    class NavigateToProductsPageCommand : ICommand
    {
        public OrdersViewModel OrdersViewModel { get; set; }
        public NavigateToProductsPageCommand(OrdersViewModel ordersViewModel)
        {
            OrdersViewModel = ordersViewModel;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            OrdersViewModel.NavigateToProductsPage();
        }
    }
}
