using SaglikApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace SaglikApp.ViewModels.Symptoms
{
    public class AddSymptomsPageVM :BaseViewModel
    {
        //TODO : To Define Local Class Level Variables..

        #region CONSTRUCTOR
        public AddSymptomsPageVM(INavigation nav)
        {
            Navigation = nav;
            NextCommand = new Command(OnNextAsync);
            BackCommand = new Command(OnBackAsync);

            //TODO : Dummy Data in list
            SymptomsList = new ObservableCollection<SymptomsNameModel>
            {
                 new SymptomsNameModel{Id="0", SymptomsName="Halsizlik"},
                 new SymptomsNameModel{Id="0", SymptomsName="Sarılık"},
                 new SymptomsNameModel{Id="0", SymptomsName="Nefes Darlığı"},
                 new SymptomsNameModel{Id="0", SymptomsName="İştahsızlık"},
                 new SymptomsNameModel{Id="0", SymptomsName="Kilo Kaybı"},
                 new SymptomsNameModel{Id="0", SymptomsName="Ateş"},
                 new SymptomsNameModel{Id="0", SymptomsName="Keyifsizlik"},
                 new SymptomsNameModel{Id="0", SymptomsName="Üst uzuvlarda şiddetli ağrı"},              
            };
        }
        #endregion

        #region COMMANDS
        public Command NextCommand { get; set; }
        public Command BackCommand { get; set; }

        #endregion

        #region Properties

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
        /// TODO : To Navigate On Liste Page...
        /// </summary>
        private async void OnNextAsync(object obj)
        {
           await Navigation.PushModalAsync(new Views.Liste.ListePage());
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

