
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Salon.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SplashscreenPage : ContentPage
    {
        Image SplashscreenImage;
        public SplashscreenPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            var container = new AbsoluteLayout();
            SplashscreenImage = new Image()
            {
                Source = "Splashscreen.png"
            };
            AbsoluteLayout.SetLayoutFlags(SplashscreenImage, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(SplashscreenImage, new Rectangle(1, 1, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
            container.Children.Add(SplashscreenImage);
            this.Content = container;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await SplashscreenImage.ScaleTo(1, 1500);
            await SplashscreenImage.ScaleTo(0.8, 1500, Easing.Linear);
            await SplashscreenImage.ScaleTo(150, 1200, Easing.Linear);
            App.Current.MainPage = new NavigationPage(new DiscoverSalonPage());
        }
    }

}