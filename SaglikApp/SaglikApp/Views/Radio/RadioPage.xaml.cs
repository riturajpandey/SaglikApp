﻿using SaglikApp.Models;
using SaglikApp.ViewModels.Radio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace SaglikApp.Views.Radio
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RadioPage : ContentPage
    {
        //TODO : To Define class Level Variables...
        RadioPageVM RadioVM;
        public RadioPage()
        {
            InitializeComponent();
            RadioVM = new RadioPageVM(this.Navigation);
            this.BindingContext = RadioVM;

            // iOS Platform
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }

        #region EVENTHANDLER
        protected override void OnAppearing()
        {
            base.OnAppearing();
            RadioVM.RadioBPList = new System.Collections.ObjectModel.ObservableCollection<RadioBPModel>(RadioBPModel.RadioBPList());
        }
        /// <summary>
        /// TODO : To Click on Yes...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void YesClick_Tapped(object sender, EventArgs e)
        {
            var radioselect = (sender as SaglikApp.CustomControls.CustomFrameForOpacity).BindingContext as RadioBPModel;
            foreach (var item in RadioVM.RadioBPList)
            {
                if (item.Id == radioselect.Id)
                {
                    item.IsRadioYesImg = true;
                    item.IsRadioNoImg = false;
                    item.IsRadioNotKnowImg = false;
                    item.SelectedBackgroundYes = "#F6FBFF";
                    item.SelectedBackgroundNo = "#FFFFFF";
                    item.SelectedBackgroundNotKnow = "#FFFFFF";
                }
            }
        }

        /// <summary>
        /// To Click on No...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NoClick_Tapped(object sender, EventArgs e)
        {
            var radioselect = (sender as SaglikApp.CustomControls.CustomFrameForOpacity).BindingContext as RadioBPModel;
            foreach (var item in RadioVM.RadioBPList)
            {
                if (item.Id == radioselect.Id)
                {
                    item.IsRadioYesImg = false;
                    item.IsRadioNoImg = true;
                    item.IsRadioNotKnowImg = false;
                    item.SelectedBackgroundYes = "#FFFFFF";
                    item.SelectedBackgroundNo = "#F6FBFF";
                    item.SelectedBackgroundNotKnow = "#FFFFFF";
                }
            }
        }

        /// <summary>
        /// To Click on Not Know...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NotKnowClick_Tapped(object sender, EventArgs e)
        {
            var radioselect = (sender as SaglikApp.CustomControls.CustomFrameForOpacity).BindingContext as RadioBPModel;
            foreach (var item in RadioVM.RadioBPList)
            {
                if (item.Id == radioselect.Id)
                {
                    item.IsRadioYesImg = false;
                    item.IsRadioNoImg = false;
                    item.IsRadioNotKnowImg = true;
                    item.SelectedBackgroundYes = "#FFFFFF";
                    item.SelectedBackgroundNo = "#FFFFFF";
                    item.SelectedBackgroundNotKnow = "#F6FBFF";
                }
            }
        } 
        #endregion

    }
}