using SaglikApp.ViewModels.SexAge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace SaglikApp.Views.SexAge
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SexAgePage : ContentPage
    {
        //TODO : To Define class Level Variables...
        SexAgePageVM SexAgeVM;
        public SexAgePage()
        {
            InitializeComponent();
            SexAgeVM = new SexAgePageVM(this.Navigation);
            this.BindingContext = SexAgeVM;

            // iOS Platform
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }
    }
}