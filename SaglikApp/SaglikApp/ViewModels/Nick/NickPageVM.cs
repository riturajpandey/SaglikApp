using Acr.UserDialogs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SaglikApp.ViewModels.Nick
{
    public class NickPageVM : BaseViewModel
    {
        //TODO : To Define Local Class Level Variables..

        #region CONSTRUCTOR
        public NickPageVM(INavigation nav)
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
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set
            {
                if (_Name != value)
                {
                    _Name = value;
                    OnPropertyChanged("Name");
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
            //Apply Validations..
            if (!await Validate()) return;
            try
            {
                await Navigation.PushModalAsync(new Views.SexAge.SexAgePage());
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
            if (string.IsNullOrEmpty(Name))
            {
                UserDialogs.Instance.Alert("Lütfen adınızı giriniz.");
                return false;
            }           
            return true;
        }

        #endregion
    }
}
