using SaglikApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace SaglikApp.ViewModels.Radio
{
    public class RadioPageVM :BaseViewModel
    {
        //TODO : To Define Local Class Level Variables..

        #region CONSTRUCTOR
        public RadioPageVM(INavigation nav)
        {
            Navigation = nav;
            NextCommand = new Command(OnNextAsync);
            BackCommand = new Command(OnBackAsync);
           

            //TODO : Dummy Data in list
            RadioBPList = new ObservableCollection<RadioBPModel>
            {
                 new RadioBPModel{Id="0", Title="Yüksek tansiyonum var", RadioYes="Evet",RadioNo="Hayır",RadioNotKnow="Bilmiyorum", IsRadioYesImg=true, IsRadioNoImg=false , IsRadioNotKnowImg=false},
                 new RadioBPModel{Id="1", Title="Sigara kullanıyorum",RadioYes="Evet", RadioNo="Hayır",RadioNotKnow="Bilmiyorum", IsRadioYesImg=true, IsRadioNoImg=false , IsRadioNotKnowImg=false},
            };
        }
        #endregion

        #region COMMANDS
        public Command NextCommand { get; set; }
        public Command BackCommand { get; set; }
       

        #endregion

        #region Properties

        private ObservableCollection<RadioBPModel> _RadioBPList;
        public ObservableCollection<RadioBPModel> RadioBPList
        {
            get { return _RadioBPList; }
            set
            {
                if (_RadioBPList != value)
                {
                    _RadioBPList = value;
                    OnPropertyChanged("RadioBPList");
                }
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// TODO : To Navigate On Next Page...
        /// </summary>
        private async void OnNextAsync(object obj)
        {
            await Navigation.PushModalAsync(new Views.Three.ThreePage());
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


