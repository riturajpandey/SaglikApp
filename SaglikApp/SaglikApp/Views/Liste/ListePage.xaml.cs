using SaglikApp.ViewModels.Liste;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace SaglikApp.Views.Liste
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListePage : ContentPage
    {
        //TODO : To Define class Level Variables...
        ListePageVM ListeVM;

        public ListePage()
        {
            InitializeComponent();
            ListeVM = new ListePageVM(this.Navigation);
            this.BindingContext = ListeVM;

            // iOS Platform
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }
    }
}