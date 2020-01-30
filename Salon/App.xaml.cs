using Salon.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Salon
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new  SplashscreenPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
