using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace RpnCalculator
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new RpnCalculator.MainPage();
        }

        protected override void OnStart()
        {
            AppCenter.Start("android=7717c1c1-ea1e-4319-9730-b8b5d8d16f4d;", typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
