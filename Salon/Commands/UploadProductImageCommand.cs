using Salon.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Salon.Commands
{
    class UploadProductImageCommand : ICommand
    {
        public SalonOwnerProductsViewModel SalonOwnerProductsViewModel { get; set; }
        public UploadProductImageCommand(SalonOwnerProductsViewModel salonOwnerProductsViewModel)
        {
            SalonOwnerProductsViewModel = salonOwnerProductsViewModel;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public async void Execute(object parameter)
        {
          await SalonOwnerProductsViewModel.UpLoadProductImage();
        }
    }
}
