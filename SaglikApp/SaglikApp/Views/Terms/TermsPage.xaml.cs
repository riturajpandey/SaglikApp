using SaglikApp.ViewModels.Terms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace SaglikApp.Views.Terms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TermsPage : ContentPage
    {
        //TODO : To Define class Level Variables...
        TermsPageVM TermsVM;

        public TermsPage()
        {
            InitializeComponent();
            TermsVM = new TermsPageVM(this.Navigation);
            this.BindingContext = TermsVM;

            // iOS Platform
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }
    }
}