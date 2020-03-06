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
    public partial class DistinctiveSymptomsPage : ContentPage
    {
        //TODO : To Define class Level Variables...
        DistinctiveSymptomsPageVM DistinctiveSymptomsVM;
        public DistinctiveSymptomsPage()
        {
            InitializeComponent();
            DistinctiveSymptomsVM = new DistinctiveSymptomsPageVM(this.Navigation);
            this.BindingContext = DistinctiveSymptomsVM;

            // iOS Platform
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }
    }
}