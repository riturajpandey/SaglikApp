using SaglikApp.ViewModels.Nick;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace SaglikApp.Views.Nick
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NickPage : ContentPage
    {
        //Define Properties Here
        protected NickPageVM NickPageVM;
        public NickPage()
        {
            InitializeComponent();
            NickPageVM = new NickPageVM(this.Navigation);
            BindingContext = NickPageVM;

            // iOS Platform
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }
    }
}