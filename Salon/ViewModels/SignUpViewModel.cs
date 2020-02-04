using Salon.Commands;
using Salon.Models;
using Salon.Views;
using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Salon.ViewModels
{
    class SignUpViewModel : BaseViewModel
    {
        public SignInCommand SignInCommand { get; set; }
        public SignUpCommand SignUpCommand { get; set; }
        public  IsTermsAndConditionsCheckBoxCheckedCommand CheckPolicyCommand { get; set; }
        public SignUpViewModel()
        {
            SignUpCommand = new SignUpCommand(this);
            SignInCommand = new SignInCommand(this);
            CheckPolicyCommand = new  IsTermsAndConditionsCheckBoxCheckedCommand(this);
            SignUp = new SignUp();
        }
        private SignUp signUp;

        public SignUp SignUp
        {
            get { return signUp; }
            set
            {
                signUp = value;
                OnPropertyChanged("SignUpModel");
            }
        }


        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
                SignUp = new SignUp()
                {
                    Name = this.Name,
                    Email = this.Email,
                    Password = this.Password
                };


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
                SignUp = new SignUp()
                {
                    Name = this.Name,
                    Email = this.Email,
                    Password = this.Password
                };
            }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged("Password");
                SignUp = new SignUp()
                {
                    Name = this.Name,
                    Email = this.Email,
                    Password = this.Password
                };
            }
        }
        private string confirmPassword;

        public string ConfirmPassword
        {
            get { return confirmPassword; }
            set
            {
                confirmPassword = value;
                OnPropertyChanged("ConfirmPassword");
            }
        }

        private string modeOfSignUp;

        public string ModeOfSignUp
        {
            get { return modeOfSignUp; }
            set
            {
                modeOfSignUp = value;
                OnPropertyChanged("ModeOfSignUp");
            }
        }

        private bool isTermsAndConditionsCheckBoxChecked;

        public bool IsTermsAndConditionsCheckBoxChecked
        {
            get { return isTermsAndConditionsCheckBoxChecked; }
            set
            {
                isTermsAndConditionsCheckBoxChecked = value;
                OnPropertyChanged("IsTermsAndConditionsCheckBoxChecked");
            }
        }



        public async void  AddCustomer()
        {
            var signUp = new SignUp()
            {
                Name = Name,
                Email = Email,
                Password = Password,
                ModeOfSignUp = ModeOfSignUp,
                IsTermsAndConditionsCheckBoxChecked = IsTermsAndConditionsCheckBoxChecked
            };
            // Send to Database SQlite and Azure
            using (var conn = new SQLiteConnection(App.Databasepath))
            {
                conn.Insert(signUp);

            }
            if (modeOfSignUp == "Salon Owner")
            {
                await App.Current.MainPage.Navigation.PushAsync(new SalonOwnerPage());
            }
            else if (modeOfSignUp == "Salonist")
            {
                await App.Current.MainPage.Navigation.PushAsync(new SalonistAccountPage());
            }
            else
            {
                await App.Current.MainPage.Navigation.PushAsync(new HomePage());
            }

        }
        public async void SignIn()
        {
            //To be implemented
            await App.Current.MainPage.Navigation.PushAsync(new HomePage());
        }
        public void CheckPolicy()
        {
            // Navigate to CheckPolicyPage, or it can pop up
            DisplayAlert("Policy", "Please check the Terms and Conditions before continuing", "Okay");
        }
    }
}
