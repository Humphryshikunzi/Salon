﻿using Salon.Commands;
using Salon.Models;
using Salon.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace Salon.ViewModels
{
    class SalonOwnerProductsViewModel : BaseViewModel
    {
        public AddProductCommand AddProductCommand { get; set; }
        public UploadProductImageCommand UploadProductImageCommand { get; set; }
        public FinishedAddingProductsCommand FinishedAddingProductsCommand { get; set; }

        public SalonOwnerProductsViewModel()
        {
            AddProductCommand = new AddProductCommand(this);
            UploadProductImageCommand = new UploadProductImageCommand(this);
            FinishedAddingProductsCommand = new FinishedAddingProductsCommand(this);
            Product = new Product();
        }
        private Product product;

        public Product Product
        {
            get { return product; }
            set
            {
                product = value;
                OnPropertyChanged("Product");
            }
        }



        private string productName;

        public string ProductName
        {
            get { return productName; }
            set
            {
                productName = value;
                OnPropertyChanged("ProductName");
                Product = new Product()
                {
                    ProductName = this.ProductName,
                    Price = this.Price
                };
            }
        }
        private string productImageUri;

        public string ProductImageUri
        {
            get { return productImageUri; }
            set
            {
                productImageUri = value;
                OnPropertyChanged("ProductImageUri");
            }
        }
        private decimal price;

        public decimal Price
        {
            get { return price; }
            set
            {
                price = value;
                OnPropertyChanged("Price");
                Product = new Product()
                {
                    ProductName = this.ProductName,
                    Price = this.Price
                };
            }
        }
        public async void FinishedAddingProducts()
        {
            await App.Current.MainPage.Navigation.PushAsync(new HomePage());
        }
        public void UpLoadProducImage()
        {

        }
        public async void AddProduct()
        {
            await App.Current.MainPage.Navigation.PushAsync(new HomePage());
        }



    }
}
