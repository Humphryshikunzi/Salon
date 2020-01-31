using Salon.Commands;
using Salon.Models;
using Salon.Views;

namespace Salon.ViewModels
{
	class SalonOwnerViewModel : BaseViewModel
	{
		public CreateSalonAccountCommand CreateSalonAccountCommand { get; set; }
		public UpLoadSalonProfileImageCommand UpLoadSalonProfileImageCommand { get; set; }


		public SalonOwnerViewModel()
		{
			CreateSalonAccountCommand = new CreateSalonAccountCommand(this);
			SalonOwnerAccount = new SalonOwnerAccount();
			UpLoadSalonProfileImageCommand = new UpLoadSalonProfileImageCommand(this);
		}

		private SalonOwnerAccount salonOwnerAccount;

		public SalonOwnerAccount SalonOwnerAccount
		{
			get { return salonOwnerAccount; }
			set
			{
				salonOwnerAccount = value;
				OnPropertyChanged("SalonOwnerAccount");
			}
		}

		private string nameOfSalon;

		public string NameOfSalon
		{
			get { return nameOfSalon; }
			set
			{
				nameOfSalon = value;
				OnPropertyChanged("NameOfSalon");

			}
		}

		private string city;

		public string City
		{
			get { return city; }
			set
			{
				city = value;
				OnPropertyChanged("City");
				SalonOwnerAccount = new SalonOwnerAccount()
				{
					NameOfSalon = this.NameOfSalon,
					City = this.City
				};
			}
		}
		private int numberOfSalonists;

		public int NumberOfSalonists
		{
			get { return numberOfSalonists; }
			set
			{
				numberOfSalonists = value;
				OnPropertyChanged("NumberOfSalonists");
			}
		}


		public async void CreateSalonAccount()
		{
			await App.Current.MainPage.Navigation.PushAsync(new SalonistAccountPage());
		}
		public  void UpLoadSalonProfileImage()
		{
			 DisplayAlert("Hello", "This page will be implemented", "Okay");
		}




	}
}
