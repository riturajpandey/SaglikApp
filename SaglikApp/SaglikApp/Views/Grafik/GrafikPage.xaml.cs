using SaglikApp.ViewModels.Grafik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace SaglikApp.Views.Grafik
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GrafikPage : ContentPage
    {
        //TODO : To Define class Level Variables...
        GrafikPageVM GrafikVM;

        public GrafikPage()
        {
            InitializeComponent();
            GrafikVM = new GrafikPageVM(this.Navigation);
            this.BindingContext = GrafikVM;

            // iOS Platform
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }
    }
}