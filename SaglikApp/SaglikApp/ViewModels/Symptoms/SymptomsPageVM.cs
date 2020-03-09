using Rg.Plugins.Popup.Extensions;
using SaglikApp.Models;
using SaglikApp.Views.Popups;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        private ObservableCollection<ChestModel> _ChestList;
        public ObservableCollection<ChestModel> ChestList
        {
            get { return _ChestList; }
            set
            {
                if (_ChestList != value)
                {
                    _ChestList = value;
                    OnPropertyChanged("ChestList");
                }
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// TODO : To Open Breast Popup Page...
        /// </summary>
        /// <param name="obj"></param>
        private async void OnBreastPopupAsync(object obj)
        {
            //Show Popup;
            BreastPopup = new BreastPopupPage(this);
            await Navigation.PushPopupAsync(BreastPopup, true);
        }

        /// <summary>
        /// TODO : To Navigate On Distinctive Symptoms Page...
        /// </summary>
        private async void OnNextAsync(object obj)
        {
           await Navigation.PushModalAsync(new Views.Symptoms.AddSymptomsPage());
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
