using SaglikApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace SaglikApp.ViewModels.Symptoms
{
    public class DistinctiveSymptomsPageVM : BaseViewModel
    {
        //TODO : To Define Local Class Level Variables..

        #region CONSTRUCTOR
        public DistinctiveSymptomsPageVM(INavigation nav)
        {
            Navigation = nav;
            NextCommand = new Command(OnNextAsync);
            BackCommand = new Command(OnBackAsync);

            //TODO : Dummy Data in list
            TempSymptoms = new ObservableCollection<SymptomsNameModel>
            {
                 new SymptomsNameModel{Id="0", SymptomsName="Halsizlik" ,SymptomsTextColor="#2F3542" ,IsActiveSymptoms=false,
                 InputkitBackgroundColor="#FFFFFF",InputkitBorderColor="#FFFFFF"},
                 new SymptomsNameModel{Id="1", SymptomsName="Halsizlik" ,SymptomsTextColor="#2F3542" ,IsActiveSymptoms=false ,
                 InputkitBackgroundColor="#FFFFFF",InputkitBorderColor="#FFFFFF"},
                 new SymptomsNameModel{Id="2", SymptomsName="Sarılık" ,SymptomsTextColor="#2F3542" ,IsActiveSymptoms=false,
                 InputkitBackgroundColor="#FFFFFF",InputkitBorderColor="#FFFFFF"},
                 new SymptomsNameModel{Id="3", SymptomsName="Sarılık" ,SymptomsTextColor="#2F3542" ,IsActiveSymptoms=false,
                 InputkitBackgroundColor="#FFFFFF",InputkitBorderColor="#FFFFFF"},
                 new SymptomsNameModel{Id="4", SymptomsName="Nefes Darlığı" ,SymptomsTextColor="#2F3542" ,IsActiveSymptoms=false,
                 InputkitBackgroundColor="#FFFFFF",InputkitBorderColor="#FFFFFF"},
                 new SymptomsNameModel{Id="5", SymptomsName="Nefes Darlığı" ,SymptomsTextColor="#2F3542" ,IsActiveSymptoms=false,
                 InputkitBackgroundColor="#FFFFFF",InputkitBorderColor="#FFFFFF"},
                 new SymptomsNameModel{Id="6", SymptomsName="İştahsızlık" ,SymptomsTextColor="#2F3542" ,IsActiveSymptoms=false,
                 InputkitBackgroundColor="#FFFFFF",InputkitBorderColor="#FFFFFF"},
                 new SymptomsNameModel{Id="7", SymptomsName="İştahsızlık" ,SymptomsTextColor="#2F3542" ,IsActiveSymptoms=false,
                 InputkitBackgroundColor="#FFFFFF",InputkitBorderColor="#FFFFFF"},
                 new SymptomsNameModel{Id="8", SymptomsName="Kilo Kaybı" ,SymptomsTextColor="#2F3542" ,IsActiveSymptoms=false,
                 InputkitBackgroundColor="#FFFFFF",InputkitBorderColor="#FFFFFF"},
                 new SymptomsNameModel{Id="9", SymptomsName="Kilo Kaybı" ,SymptomsTextColor="#2F3542" ,IsActiveSymptoms=false,
                 InputkitBackgroundColor="#FFFFFF",InputkitBorderColor="#FFFFFF"},
                 new SymptomsNameModel{Id="10", SymptomsName="Halsizlik" ,SymptomsTextColor="#2F3542" ,IsActiveSymptoms=false,
                 InputkitBackgroundColor="#FFFFFF",InputkitBorderColor="#FFFFFF"},
                 new SymptomsNameModel{Id="11", SymptomsName="Halsizlik" ,SymptomsTextColor="#2F3542" ,IsActiveSymptoms=false,
                 InputkitBackgroundColor="#FFFFFF",InputkitBorderColor="#FFFFFF"},
                 new SymptomsNameModel{Id="12", SymptomsName="Ateş" ,SymptomsTextColor="#2F3542" ,IsActiveSymptoms=false,
                 InputkitBackgroundColor="#FFFFFF",InputkitBorderColor="#FFFFFF"},
                 new SymptomsNameModel{Id="13", SymptomsName="Ateş" ,SymptomsTextColor="#2F3542" ,IsActiveSymptoms=false,
                 InputkitBackgroundColor="#FFFFFF",InputkitBorderColor="#FFFFFF"},
                 new SymptomsNameModel{Id="14", SymptomsName="Keyifsizlik" ,SymptomsTextColor="#2F3542" ,IsActiveSymptoms=false,
                 InputkitBackgroundColor="#FFFFFF",InputkitBorderColor="#FFFFFF"},
                 new SymptomsNameModel{Id="15", SymptomsName="Keyifsizlik" ,SymptomsTextColor="#2F3542" ,IsActiveSymptoms=false,
                 InputkitBackgroundColor="#FFFFFF",InputkitBorderColor="#FFFFFF"},
                 new SymptomsNameModel{Id="16", SymptomsName="Halsizlik" ,SymptomsTextColor="#2F3542" ,IsActiveSymptoms=false,
                 InputkitBackgroundColor="#FFFFFF",InputkitBorderColor="#FFFFFF"},
                 new SymptomsNameModel{Id="17", SymptomsName="Halsizlik" ,SymptomsTextColor="#2F3542" ,IsActiveSymptoms=false,
                 InputkitBackgroundColor="#FFFFFF",InputkitBorderColor="#FFFFFF"},
                 new SymptomsNameModel{Id="18", SymptomsName="Sarılık" ,SymptomsTextColor="#2F3542" ,IsActiveSymptoms=false,
                 InputkitBackgroundColor="#FFFFFF",InputkitBorderColor="#FFFFFF"},
                 new SymptomsNameModel{Id="19", SymptomsName="Sarılık" ,SymptomsTextColor="#2F3542" ,IsActiveSymptoms=false,
                 InputkitBackgroundColor="#FFFFFF",InputkitBorderColor="#FFFFFF"},
                 new SymptomsNameModel{Id="20", SymptomsName="Nefes Darlığı" ,SymptomsTextColor="#2F3542" ,IsActiveSymptoms=false,
                 InputkitBackgroundColor="#FFFFFF",InputkitBorderColor="#FFFFFF"},
                 new SymptomsNameModel{Id="21", SymptomsName="Nefes Darlığı" ,SymptomsTextColor="#2F3542" ,IsActiveSymptoms=false,
                 InputkitBackgroundColor="#FFFFFF",InputkitBorderColor="#FFFFFF"},
                 new SymptomsNameModel{Id="22", SymptomsName="İştahsızlık" ,SymptomsTextColor="#2F3542" ,IsActiveSymptoms=false,
                 InputkitBackgroundColor="#FFFFFF",InputkitBorderColor="#FFFFFF"},
                 new SymptomsNameModel{Id="23", SymptomsName="İştahsızlık" ,SymptomsTextColor="#2F3542" ,IsActiveSymptoms=false,
                 InputkitBackgroundColor="#FFFFFF",InputkitBorderColor="#FFFFFF"},
                 new SymptomsNameModel{Id="24", SymptomsName="Kilo Kaybı" ,SymptomsTextColor="#2F3542" ,IsActiveSymptoms=false,
                 InputkitBackgroundColor="#FFFFFF",InputkitBorderColor="#FFFFFF"},
                 new SymptomsNameModel{Id="25", SymptomsName="Kilo Kaybı" ,SymptomsTextColor="#2F3542" ,IsActiveSymptoms=false,
                 InputkitBackgroundColor="#FFFFFF",InputkitBorderColor="#FFFFFF"},
                 new SymptomsNameModel{Id="26", SymptomsName="Ateş" ,SymptomsTextColor="#2F3542" ,IsActiveSymptoms=false,
                 InputkitBackgroundColor="#FFFFFF",InputkitBorderColor="#FFFFFF"},
                 new SymptomsNameModel{Id="27", SymptomsName="Ateş" ,SymptomsTextColor="#2F3542" ,IsActiveSymptoms=false,
                 InputkitBackgroundColor="#FFFFFF",InputkitBorderColor="#FFFFFF"},
                 new SymptomsNameModel{Id="28", SymptomsName="Keyifsizlik" ,SymptomsTextColor="#2F3542" ,IsActiveSymptoms=false,
                 InputkitBackgroundColor="#FFFFFF",InputkitBorderColor="#FFFFFF"},
                 new SymptomsNameModel{Id="29", SymptomsName="Keyifsizlik" ,SymptomsTextColor="#2F3542" ,IsActiveSymptoms=false,
                 InputkitBackgroundColor="#FFFFFF",InputkitBorderColor="#FFFFFF"},
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
        /// TODO : To Navigate On Distinctive Symptoms Page...
        /// </summary>
        private async void OnNextAsync(object obj)
        {
            await Navigation.PushModalAsync(new Views.Symptoms.SymptomsPage());
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