using SaglikApp.ViewModels.Symptoms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace SaglikApp.Views.Symptoms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SymptomsPage : ContentPage
    {
        //TODO : To Define class Level Variables...
        SymptomsPageVM SymptomsVM;

        public SymptomsPage()
        {
            InitializeComponent();
            SymptomsVM = new SymptomsPageVM(this.Navigation);
            this.BindingContext = SymptomsVM;

            // iOS Platform
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }
    }
}