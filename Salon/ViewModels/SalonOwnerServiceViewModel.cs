using Salon.Commands;
using Salon.Models;
using Salon.Views;
using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Xamarin.Forms;
using System.Threading.Tasks;
using SQLite;

namespace Salon.ViewModels
{
	class SalonOwnerServicesViewModel : BaseViewModel
	{
		public UpLoadServiceImageCommand UpLoadServiceImageCommand { get; set; }
		public AddSalonOwnerServiceCommand AddSalonOwnerServiceCommand { get; set; }
		public FinishedAddingServicesCommand FinishedAddingServicesCommand { get; set; }
		public SalonOwnerServicesViewModel()
		{
			FinishedAddingServicesCommand = new FinishedAddingServicesCommand(this);
			AddSalonOwnerServiceCommand = new AddSalonOwnerServiceCommand(this);
			UpLoadServiceImageCommand = new UpLoadServiceImageCommand(this);
			Services = new Services();
		}
		public  Image  Image { get; set; }

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
			var service = new Services()
			{
				Service = Service,
				Charge = Charge,
				ServiceImageUri = await UpLoadServiceImage()
			};
			using (var conn = new SQLiteConnection(App.Databasepath))
			{
				conn.Insert(service);
			}
			await App.Current.MainPage.Navigation.PushAsync(new SalonOwnerProductsPage());
		}
		public async void FinishedAddingServices()
		{
			await App.Current.MainPage.Navigation.PushAsync(new SalonOwnerProductsPage());
		}
		public async Task<string> UpLoadServiceImage()
		{
			return await PickAndUpLoadImage(Image, "Service");
		}


	}
}
