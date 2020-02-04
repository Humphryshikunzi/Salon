using Salon.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Salon.Helpers;

namespace Salon
{
    public partial class App : Application
    {
        public static string Databasepath;
        public App(string databasepath)
        {
            InitializeComponent();
            Databasepath = databasepath;
            CreateDatabases.Create();
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
