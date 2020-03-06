using SaglikApp.ViewModels.Three;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace SaglikApp.Views.Three
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ThreePage : ContentPage
    {
        //TODO : To Define class Level Variables...
        ThreePageVM ThreeVM;
        public ThreePage()
        {
            InitializeComponent();
            ThreeVM = new ThreePageVM(this.Navigation);
            this.BindingContext = ThreeVM;

            // iOS Platform
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }
    }
}