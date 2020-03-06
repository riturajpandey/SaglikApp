using SaglikApp.ViewModels.Scroll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace SaglikApp.Views.Scroll
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ScrollPage : ContentPage
    {
        //TODO : To Define class Level Variables...
        ScrollPageVM ScrollVM;

        public ScrollPage()
        {
            InitializeComponent();
            ScrollVM = new ScrollPageVM(this.Navigation);
            this.BindingContext = ScrollVM;

            // iOS Platform
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }
    }
}