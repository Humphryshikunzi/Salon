using Salon.Commands;
using Salon.Models;
using Salon.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;

namespace Salon.ViewModels
{
	class SalonistAccountViewModel : BaseViewModel
	{
		public FinishedAddingSalonistCommand FinishedAddingSalonistsCommand { get; set; }
		public  AddSalonistCommand  AddSalonistCommand { get; set; }
		public SalonistAccountViewModel()
		{
			 FinishedAddingSalonistsCommand = new FinishedAddingSalonistCommand(this);
			 AddSalonistCommand = new  AddSalonistCommand(this);
			 Salonist = new Salonist();
		}

		public  Image  Image { get; set; }


		private Salonist salonist;

		public Salonist Salonist
		{
			get { return salonist; }
			set
			{
				salonist = value;
				OnPropertyChanged("Salonist");
			}
		}


		private string email;

		public string Email
		{
			get { return email; }
			set
			{
				email = value;
				OnPropertyChanged("Email");
			}
		}

		private string userName;

		public string UserName
		{
			get { return userName; }

			set
			{
				userName = value;
				OnPropertyChanged("UserName");
			}
		}


		public async void AddSalonist()
		{
			var salonist = new Salonist()
			{
				UserName = UserName,
				Email = Email,
				Password = new Guid().ToString(),
				ProfileImageUri = await UpLoadProfileImage()

		    };
			using (var conn = new SQLiteConnection(App.Databasepath))
			{
				conn.Insert(salonist);
			}
			//Add Salonist Here
			await App.Current.MainPage.Navigation.PushAsync(new SalonOwnerServicePage());
		}
		public async void FinishedAddingSalonists()
		{
			//Add service here
			await App.Current.MainPage.Navigation.PushAsync(new SalonOwnerServicePage());
		}
		public async Task<string> UpLoadProfileImage()
		{
			return await PickAndUpLoadImage(Image, "Salonsit");

		}

	}
}
