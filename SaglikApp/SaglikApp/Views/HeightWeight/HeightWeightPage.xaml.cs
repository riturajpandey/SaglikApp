using SaglikApp.ViewModels.HeightWeight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace SaglikApp.Views.HeightWeight
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HeightWeightPage : ContentPage
    {
        //Define Properties Here
        protected HeightWeightPageVM HeightWeightVM;
        public HeightWeightPage()
        {
            InitializeComponent();
            HeightWeightVM = new HeightWeightPageVM(this.Navigation);
            BindingContext = HeightWeightVM;

            // iOS Platform
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }
    }
}