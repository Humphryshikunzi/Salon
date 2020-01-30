using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Salon.ViewModels;

namespace Salon.Commands
{
    class NavigateToAppointmentsPageCommand : ICommand
    {
        public  OrdersViewModel  OrdersViewModel { get; set; }
        public NavigateToAppointmentsPageCommand(OrdersViewModel ordersViewModel)
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
            OrdersViewModel.NavigateToAppointmentsPage();
        }
    }
}
