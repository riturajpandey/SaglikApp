using SaglikApp.Models;
using SaglikApp.ViewModels.Symptoms;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace SaglikApp.Views.Symptoms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddSymptomsPage : ContentPage
    {

        //TODO : To Define class Level Variables...
        AddSymptomsPageVM AddSymptomsVM;

        public AddSymptomsPage()
        {
            InitializeComponent();
            AddSymptomsVM = new AddSymptomsPageVM(this.Navigation);
            this.BindingContext = AddSymptomsVM;

            // iOS Platform
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }

        /// <summary>
        /// TODO : To Search Symptoms name in Searchbar...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SymptomsSearchbar_TextChanged(object sender, TextChangedEventArgs e)
        {
            //if (string.IsNullOrEmpty(e.NewTextValue))
            //{
            //    lvSymptoms.ItemsSource = AddSymptomsVM.SymptomsList;
            //}
            //else
            //{
            //    string filter = SymptomsSearchbar.Text;
            //    lvSymptoms.ItemsSource = AddSymptomsVM.SymptomsList.Where(x => x.SymptomsName.ToLower().Contains(filter.ToLower())).ToList();
            //}
        }

        /// <summary>
        ///  Delete Symptoms name in SymptomsList tap event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Delete_Tapped(object sender, System.EventArgs e)
        {

            var item = (sender as Grid).BindingContext as SymptomsNameModel;

                AddSymptomsVM.SymptomsList.Remove(item);
                lvSymptoms.ItemsSource = null;
                lvSymptoms.ItemsSource = AddSymptomsVM.SymptomsList;
         
        }
    }
}