using System;
using System.Collections.Generic;
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
        }
        #endregion

        #region COMMANDS
        public Command NextCommand { get; set; }
        public Command BackCommand { get; set; }

        #endregion

        #region Properties
      

        #endregion

        #region Methods

        /// <summary>
        /// TODO : To Navigate On Next Page...
        /// </summary>
        private async void OnNextAsync(object obj)
        {
            await Navigation.PushModalAsync(new Views.SexAge.SexAgePage());
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


