using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SaglikApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage = new Views.Welcome.WelcomePage(); 
            MainPage = new Views.SexAge.SexAgePage();
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
