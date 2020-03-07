using SaglikApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace SaglikApp.ViewModels.Grafik
{
    public class GrafikPageVM : BaseViewModel
    {
        //TODO : To Define Local Class Level Variables..

        #region CONSTRUCTOR
        public GrafikPageVM(INavigation nav)
        {
            Navigation = nav;
            NextCommand = new Command(OnNextAsync);
            BackCommand = new Command(OnBackAsync);

            //TODO : Dummy Data in list
            MedicalResulList = new ObservableCollection<MedicalResultModel>
            {
                 new MedicalResultModel{Id="0", DiseaseName="Öksürünce veya hareket edince şiddetlenen karın ağrısı" , ProgessColor="#FA4D56"},
                 new MedicalResultModel{Id="0", DiseaseName="Düzensiz bağırsak harekteleri" , ProgessColor="#62B5F0"},

            };
        }
        #endregion

        #region COMMANDS
        public Command NextCommand { get; set; }
        public Command BackCommand { get; set; }

        #endregion

        #region Properties

        private ObservableCollection<MedicalResultModel> _MedicalResulList;
        public ObservableCollection<MedicalResultModel> MedicalResulList
        {
            get { return _MedicalResulList; }
            set
            {
                if (_MedicalResulList != value)
                {
                    _MedicalResulList = value;
                    OnPropertyChanged("MedicalResulList");
                }
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// TODO : To Navigate On Select Box Page...
        /// </summary>
        private async void OnNextAsync(object obj)
        {
          //  await Navigation.PushModalAsync(new Views.Grafik.GrafikPage());
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