using DLToolkit.Forms.Controls;
using SaglikApp.Models;
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

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var symptomsItem = (sender as Grid).BindingContext as SymptomsNameModel;
            foreach (var item in DistinctiveSymptomsVM.SymptomsList)
            {
                if (item.Id == symptomsItem.Id)
                {
                    if (symptomsItem.IsActiveSymptoms == false)
                    {
                        item.IsActiveSymptoms = true;
                        item.SymptomsTextColor = "#0072C3";
                        item.InputkitBackgroundColor = "#F6FBFF";
                        item.InputkitBorderColor = "#F6F6F6";
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
                        item.InputkitBorderColor = "#FFFFFF";
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