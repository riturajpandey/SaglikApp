using Acr.UserDialogs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SaglikApp.ViewModels.Terms
{
    public class TermsPageVM : BaseViewModel        
    {
        //TODO : To Define Local Class Level Variables..

        #region CONSTRUCTOR

        /// <summary>
        /// Initializes a new instance of the <see cref="TermsPageVM"/> class.
        /// </summary>
        /// <param name="nav"></param>
        public TermsPageVM(INavigation nav)
        {
            Navigation = nav;
            ProceedCommand = new Command(OnProceedAsync);
            BackCommand = new Command(OnBackAsync);
        }

        #endregion

        #region COMMANDS

        public Command ProceedCommand { get; set; }
        public Command BackCommand { get; set; }

        #endregion

        #region Properties
        private bool _AcceptTerm;
        public bool AcceptTerm
        {
            get { return _AcceptTerm; }
            set
            {
                if (_AcceptTerm != value)
                {
                    _AcceptTerm = value;
                    OnPropertyChanged("AcceptTerm");
                }
            }
        }
        #endregion

        #region Methods

        /// <summary>
        /// TODO : To Navigate To Nick Page...
        /// </summary>
        public async void OnProceedAsync()
        {
            //Apply Validations..
            if (!await Validate()) return;
            try
            {
                await Navigation.PushModalAsync(new Views.Nick.NickPage());
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
            if ((AcceptTerm == false ))
            {
                UserDialogs.Instance.Alert("Lütfen Kullanım Koşullarını kabul edin.");
                return false;
            }

            return true;
        }

        #endregion
    }
}
