using Salon.Commands;
using Salon.Models;
using Salon.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace Salon.ViewModels
{
	class SalonOwnerServicesViewModel : BaseViewModel
	{
		public AddSalonOwnerServiceCommand AddSalonOwnerServiceCommand { get; set; }
		public FinishedAddingServicesCommand FinishedAddingServicesCommand { get; set; }
		public SalonOwnerServicesViewModel()
		{
			FinishedAddingServicesCommand = new FinishedAddingServicesCommand(this);
			AddSalonOwnerServiceCommand = new AddSalonOwnerServiceCommand(this);
			Services = new Services();
		}

		private Services services;

		public Services Services
		{
			get { return services; }
			set
			{
				services = value;
				OnPropertyChanged("SalonOwnerServices");
			}
		}

		private string service;

		public string Service
		{
			get { return service; }
			set
			{
				service = value;
				OnPropertyChanged("Service");
				Services = new Services()
				{
					Service = this.Service,
					Charge = this.Charge
				};

			}
		}
		private decimal charge;

		public decimal Charge
		{
			get { return charge; }
			set
			{
				charge = value;
				OnPropertyChanged("Charge");
				Services = new Services()
				{
					Service = this.Service,
					Charge = this.Charge
				};
			}
		}
		public async void AddService()
		{
			await App.Current.MainPage.Navigation.PushAsync(new SalonOwnerProductsPage());
		}
		public async void FinishedAddingServices()
		{
			await App.Current.MainPage.Navigation.PushAsync(new SalonOwnerProductsPage());
		}



	}
}
