using SaglikApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace SaglikApp.ViewModels.SelectBox
{
    public class SelectBoxPageVM : BaseViewModel
    {
        //TODO : To Define Local Class Level Variables..

        #region CONSTRUCTOR
        public SelectBoxPageVM(INavigation nav)
        {
            Navigation = nav;
            NextCommand = new Command(OnNextAsync);
            BackCommand = new Command(OnBackAsync);

            //TODO : Dummy Data in list
            TempSymptoms = new ObservableCollection<SymptomsNameModel>
            {
                 new SymptomsNameModel{Id="0", SymptomsName="Yere eğilmede güçlük",SymptomsTextColor="#2F3542",IsActiveSymptoms=false,
                                       InputkitBackgroundColor="#FFFFFF",InputkitBorderColor="#E9F3F3"},
                 new SymptomsNameModel{Id="1", SymptomsName="Kas krampları",SymptomsTextColor="#2F3542",IsActiveSymptoms=false,
                                       InputkitBackgroundColor="#FFFFFF",InputkitBorderColor="#E9F3F3"},
                 new SymptomsNameModel{Id="2", SymptomsName="Alt ekstremitede ağrı",SymptomsTextColor="#2F3542",IsActiveSymptoms=false,
                                       InputkitBackgroundColor="#FFFFFF",InputkitBorderColor="#E9F3F3"},
                 new SymptomsNameModel{Id="3", SymptomsName="ağrısı",SymptomsTextColor="#2F3542",IsActiveSymptoms=false,
                                       InputkitBackgroundColor="#FFFFFF",InputkitBorderColor="#E9F3F3"},
                 new SymptomsNameModel{Id="4", SymptomsName="Bir kaç saat süren sırt ağrıları",SymptomsTextColor="#2F3542",IsActiveSymptoms=false,
                                       InputkitBackgroundColor="#FFFFFF",InputkitBorderColor="#E9F3F3"},
                new SymptomsNameModel{Id="5", SymptomsName="Şiddetli sırt ağrısı",SymptomsTextColor="#2F3542",IsActiveSymptoms=false,
                                       InputkitBackgroundColor="#FFFFFF",InputkitBorderColor="#E9F3F3"},

            };
            foreach (var item in TempSymptoms)
            {
                if (Xamarin.Forms.Device.OS == TargetPlatform.Android)
                    item.SymptomsFontFamily = "Poppins-Regular.ttf#Poppins-Regular";
                else
                    item.SymptomsFontFamily = "Poppins-Regular";
            }
            SymptomsList = new ObservableCollection<SymptomsNameModel>(TempSymptoms);
        }
        #endregion

        #region COMMANDS
        public Command NextCommand { get; set; }
        public Command BackCommand { get; set; }


        #endregion

        #region Properties

        private ObservableCollection<SymptomsNameModel> _TempSymptoms;
        public ObservableCollection<SymptomsNameModel> TempSymptoms
        {
            get { return _TempSymptoms; }
            set
            {
                if (_TempSymptoms != value)
                {
                    _TempSymptoms = value;
                    OnPropertyChanged("TempSymptoms");
                }
            }
        }

        private ObservableCollection<SymptomsNameModel> _SymptomsList;
        public ObservableCollection<SymptomsNameModel> SymptomsList
        {
            get { return _SymptomsList; }
            set
            {
                if (_SymptomsList != value)
                {
                    _SymptomsList = value;
                    OnPropertyChanged("SymptomsList");
                }
            }
        }
        #endregion

        #region Methods

        /// <summary>
        /// TODO : To Navigate On Scroll Page...
        /// </summary>
        private async void OnNextAsync(object obj)
        {
           await Navigation.PushModalAsync(new Views.Scroll.ScrollPage());
        }

        /// <summary>
        /// TODO : To Navigate To Back Page...
        /// </summary>
        public async void OnBackAsync()
        {
            await Navigation.PopModalAsync();
        }

        #endregion
    }
}