using Acr.UserDialogs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SaglikApp.ViewModels.Three
{
    public class ThreePageVM : BaseViewModel
    {
        //TODO : To Define Local Class Level Variables..

        #region CONSTRUCTOR
        public ThreePageVM(INavigation nav)
        {
            Navigation = nav;
            NextCommand = new Command(OnNextAsync);
            BackCommand = new Command(OnBackAsync);
            YesCommand = new Command(OnYesAsync);
            NoCommand = new Command(OnNoAsync);
        }
        #endregion

        #region COMMANDS
        public Command NextCommand { get; set; }
        public Command BackCommand { get; set; }
        public Command YesCommand { get; set; }
        public Command NoCommand { get; set; }

        #endregion

        #region Properties

        private string _SelectYes;
        public string SelectYes
        {
            get { return _SelectYes; }
            set
            {
                if (_SelectYes != value)
                {
                    _SelectYes = value;
                    OnPropertyChanged("SelectYes");
                }
            }
        }

        private string _SelectNo;
        public string SelectNo
        {
            get { return _SelectNo; }
            set
            {
                if (_SelectNo != value)
                {
                    _SelectNo = value;
                    OnPropertyChanged("SelectNo");
                }
            }
        }

        private bool _IsActiveYes;
        public bool IsActiveYes
        {
            get { return _IsActiveYes; }
            set
            {
                if (_IsActiveYes != value)
                {
                    _IsActiveYes = value;
                    OnPropertyChanged("IsActiveYes");
                }
            }
        }

        private bool _IsActiveNo;
        public bool IsActiveNo
        {
            get { return _IsActiveNo; }
            set
            {
                if (_IsActiveNo != value)
                {
                    _IsActiveNo = value;
                    OnPropertyChanged("IsActiveNo");
                }
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// TODO : To select Yes option...
        /// </summary>
        private async void OnYesAsync(object obj)
        {
            SelectYes = "#0072C3";
            SelectNo = "#FFFFFF";
            IsActiveYes = true;
            IsActiveNo = false;
        }

        /// <summary>
        /// TODO : To select No option ...
        /// </summary>
        private async void OnNoAsync(object obj)
        {
            SelectYes = "#FFFFFF";
            SelectNo = "#0072C3";
            IsActiveYes = false;
            IsActiveNo = true;
        }

        /// <summary>
        /// TODO : To Navigate On Select Box Page...
        /// </summary>
        private async void OnNextAsync(object obj)
        {
            //Apply Validations..
            if (!await Validate()) return;
            try
            {
                await Navigation.PushModalAsync(new Views.SelectBox.SelectBoxPage());
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
        /// TODO : To Validate Yes and NO Fields...
        /// </summary>
        /// <returns></returns>
        private async Task<bool> Validate()
        {
            if ((IsActiveYes == false && IsActiveNo == false))
            {
                UserDialogs.Instance.Alert("Lütfen Evet ve Hayır seçin.");
                return false;
            }

            return true;
        }

        #endregion
    }
}



