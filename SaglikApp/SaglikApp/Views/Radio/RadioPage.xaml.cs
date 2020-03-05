using SaglikApp.ViewModels.Radio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace SaglikApp.Views.Radio
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RadioPage : ContentPage
    {
        //TODO : To Define class Level Variables...
        RadioPageVM RadioVM;
        public RadioPage()
        {
            InitializeComponent();
            RadioVM = new RadioPageVM(this.Navigation);
            this.BindingContext = RadioVM;

            // iOS Platform
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }
    }
}