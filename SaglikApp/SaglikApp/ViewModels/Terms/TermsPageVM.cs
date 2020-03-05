using System;
using System.Collections.Generic;
using System.Text;
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
           // ProceedCommand = new Command(OnProceedAsync);

        }

        #endregion

        #region COMMANDS

        // public Command ProceedCommand { get; set; }

        #endregion

        #region Properties

        #endregion

        #region Methods

        /// <summary>
        /// TODO : To Navigate To hhhhhhh Page...
        /// </summary>
        //public async void OnProceedAsync()
        //{
        //    await Navigation.PushModalAsync(new Views.Accounts.SignupFirstPage());
        //}

        #endregion
    }
}
