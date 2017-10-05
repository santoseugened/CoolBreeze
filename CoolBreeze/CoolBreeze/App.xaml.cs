using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace CoolBreeze
{
    public partial class App : Application
    {

        public static MainViewModel ViewModel;
        public static string RegistrationCode = "XBWW63199CCA79B09F4382D613C67AA2";

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new CoolBreeze.StartPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            MobileCenter.Start(typeof(Analytics), typeof(Crashes));
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
