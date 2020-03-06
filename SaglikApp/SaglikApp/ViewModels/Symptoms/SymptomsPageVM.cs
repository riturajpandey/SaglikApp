﻿using Rg.Plugins.Popup.Extensions;
using SaglikApp.Views.Popups;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SaglikApp.ViewModels.Symptoms
{
    public class SymptomsPageVM :BaseViewModel
    {
        //TODO : To Define Local Class Level Variables..
        BreastPopupPage BreastPopup;

        #region CONSTRUCTOR
        public SymptomsPageVM(INavigation nav)
        {
            Navigation = nav;
            NextCommand = new Command(OnNextAsync);
            BackCommand = new Command(OnBackAsync);
            BreastPopupCommand = new Command(OnBreastPopupAsync);

        }
        #endregion

        #region COMMANDS
        public Command NextCommand { get; set; }
        public Command BackCommand { get; set; }
        public Command BreastPopupCommand { get; set; }

        #endregion

        #region Properties

        #endregion

        #region Methods

        /// <summary>
        /// TODO : To Open Start Log Popup Page...
        /// </summary>
        /// <param name="obj"></param>
        private async void OnBreastPopupAsync(object obj)
        {
            //Show Popup;
            BreastPopup = new BreastPopupPage(this);
            await Navigation.PushPopupAsync(BreastPopup, true);
        }

        /// <summary>
        /// TODO : To Navigate On Select Box Page...
        /// </summary>
        private async void OnNextAsync(object obj)
        {
           // await Navigation.PushModalAsync(new Views.SelectBox.SelectBoxPage());
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
