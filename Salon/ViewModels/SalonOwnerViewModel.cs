using Salon.Commands;
using Salon.Models;
using Salon.Views;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;

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

		private  Image  image;

		public  Image  Image
		{
			get { return  image; }
			set {  image = value; }
		}



		public async void CreateSalonAccount()
		{
			var salonOwner = new SalonOwnerAccount()
			{
				NameOfSalon = NameOfSalon,
				NumberOfSalonists = NumberOfSalonists,
				City = City,
				SalonImageUri = await UpLoadSalonProfileImage()
			};
			using (var conn = new SQLiteConnection(App.Databasepath))
			{
				conn.Insert(salonOwner);
			}
			await App.Current.MainPage.Navigation.PushAsync(new SalonistAccountPage());
		}
		public  Task<string> UpLoadSalonProfileImage()
		{
			
			return PickAndUpLoadImage(Image, "Salon");
;		}




	}
}
