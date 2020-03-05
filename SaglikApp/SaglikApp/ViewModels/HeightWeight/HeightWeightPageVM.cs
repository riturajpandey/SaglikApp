using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SaglikApp.ViewModels.HeightWeight
{
    public class HeightWeightPageVM : BaseViewModel
    {

        //TODO : To Define Local Class Level Variables..

        #region CONSTRUCTOR
        public HeightWeightPageVM(INavigation nav)
        {
            Navigation = nav;
            NextCommand = new Command(OnNextAsync);
            BackCommand = new Command(OnBackAsync);
        }
        #endregion

        #region COMMANDS
        public Command NextCommand { get; set; }
        public Command BackCommand { get; set; }

        #endregion

        #region Properties
        private string _Centimeter = "00";
        public string Centimeter
        {
            get { return _Centimeter; }
            set
            {
                if (_Centimeter != value)
                {
                    _Centimeter = value;
                    OnPropertyChanged("Centimeter");
                }
            }
        }

        private string _Kilogram = "00";
        public string Kilogram
        {
            get { return _Kilogram; }
            set
            {
                if (_Kilogram != value)
                {
                    _Kilogram = value;
                    OnPropertyChanged("Kilogram");
                }
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// TODO : To Navigate On Radio Page...
        /// </summary>
        private async void OnNextAsync(object obj)
        {
            await Navigation.PushModalAsync(new Views.Radio.RadioPage());
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

