using Acr.UserDialogs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
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
        private string _Centimeter;
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

        private string _Kilogram;
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
            //Apply Validations..
            if (!await Validate()) return;
            try
            {
                await Navigation.PushModalAsync(new Views.Radio.RadioPage());
            }
            catch (Exception ex)
            { }          
        }

        /// <summary>
        /// TODO : To Navigate To Back Page...
        /// </summary>
        public async void OnBackAsync()
        {
            await Navigation.PopModalAsync();
        }

        /// <summary>
        /// TODO : To Validate User Login Fields...
        /// </summary>
        /// <returns></returns>
        private async Task<bool> Validate()
        {
            if (string.IsNullOrEmpty(Centimeter))
            {
                UserDialogs.Instance.Alert("Lütfen cm girin.");
                return false;
            }
            if (string.IsNullOrEmpty(Kilogram))
            {
                UserDialogs.Instance.Alert("Lütfen kg girin.");
                return false;
            }
            return true;
        }

        #endregion
    }
}

