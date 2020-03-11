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

            // Syncfusion Licensing key  //FOR VERSION 17
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("ODM3ODRAMzEzNzJlMzEyZTMwZmlxZnVXdVJ1U0pTRUExVkM3WE10OGx5NktJOEJtOVdCdUdlSTJORmtyYz0=");

            MainPage = new Views.Welcome.WelcomePage();
           //  MainPage = new Views.Symptoms.DistinctiveSymptomsPage();

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
