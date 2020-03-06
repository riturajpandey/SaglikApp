using SaglikApp.Models;
using SaglikApp.ViewModels.SelectBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace SaglikApp.Views.SelectBox
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectBoxPage : ContentPage
    {
        //TODO : To Define class Level Variables...
        SelectBoxPageVM SelectBoxVM;

        public SelectBoxPage()
        {
            InitializeComponent();
            SelectBoxVM = new SelectBoxPageVM(this.Navigation);
            this.BindingContext = SelectBoxVM;

            // iOS Platform
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }
        //If User Click On Symptoms Radio Button
        private void Symptoms_CheckChanged(object sender, EventArgs e)
        {
            var symptomsItem = (sender as Plugin.InputKit.Shared.Controls.CheckBox).BindingContext as SymptomsNameModel;
            foreach (var item in SelectBoxVM.SymptomsList)
            {
                if (item.Id == symptomsItem.Id)
                {
                    if (symptomsItem.IsActiveSymptoms == false)
                    {
                        item.IsActiveSymptoms = true;
                        item.SymptomsTextColor = "#0072C3";
                        item.InputkitBackgroundColor = "#FFFFFF";
                        item.InputkitBorderColor = "#0072C3";
                        // item.SymptomsFontFamily = "Poppins-SemiBold.ttf#Poppins-SemiBold";
                        if (Xamarin.Forms.Device.OS == TargetPlatform.Android)
                            item.SymptomsFontFamily = "Poppins-SemiBold.ttf#Poppins-SemiBold";
                        else
                            item.SymptomsFontFamily = "Poppins-SemiBold";
                    }
                    else
                    {
                        item.IsActiveSymptoms = false;
                        item.SymptomsTextColor = "#2F3542";
                        item.InputkitBackgroundColor = "#FFFFFF";
                        item.InputkitBorderColor = "#2F3542";
                        // item.SymptomsFontFamily = "Poppins-SemiBold";
                        if (Xamarin.Forms.Device.OS == TargetPlatform.Android)
                            item.SymptomsFontFamily = "Poppins-Regular.ttf#Poppins-Regular";
                        else
                            item.SymptomsFontFamily = "Poppins-Regular";
                    }
                }
            }
        }
    }
}