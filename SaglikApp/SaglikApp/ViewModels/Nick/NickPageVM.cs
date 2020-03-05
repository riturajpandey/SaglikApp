using System;
using System.Collections.Generic;
using System.Text;
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
        }
        #endregion

        #region COMMANDS
        public Command NextCommand { get; set; }
        #endregion

        #region Properties

        #endregion

        #region Methods

        /// <summary>
        /// TODO : To Navigate On Next Page...
        /// </summary>
        private void OnNextAsync(object obj)
        {
           
        }


        #endregion
    }
}
