using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestApp
{
    public partial class App : Application
    {
        public HomePage HomePage = new HomePage();
        public OptionPage OptionPage = new OptionPage();
        public CallPage CallPage = new CallPage();
        public AlertPage AlertPage = new AlertPage();

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(HomePage);
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
