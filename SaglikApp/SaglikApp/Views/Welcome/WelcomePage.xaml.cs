using SaglikApp.ViewModels.Welcome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace SaglikApp.Views.Welcome
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WelcomePage : ContentPage
    {
        //TODO : To Define class Level Variables...
        WelcomePageVM WelcomeVM;

        public WelcomePage()
        {
            InitializeComponent();
            WelcomeVM = new WelcomePageVM(this.Navigation);
            this.BindingContext = WelcomeVM;

            // iOS Platform
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }
    }
}