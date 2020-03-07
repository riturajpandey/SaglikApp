using SaglikApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace SaglikApp.ViewModels.Liste
{
    public class ListePageVM : BaseViewModel
    {
        //TODO : To Define Local Class Level Variables..

        #region CONSTRUCTOR
        public ListePageVM(INavigation nav)
        {
            Navigation = nav;
            NextCommand = new Command(OnNextAsync);
            BackCommand = new Command(OnBackAsync);

            //TODO : Dummy Data in list
            MedicalResulList = new ObservableCollection<MedicalResultModel>
            {
                 new MedicalResultModel{Id="0", DiseaseName="Huzursuz bağırsak" ,Status="Güçlü kanıt" ,Progesspercent="% 79" , ProgessColor="#FA4D56"},
                 new MedicalResultModel{Id="1", DiseaseName="Mide çepheri iltihabı" ,Status="Orta düzeyde kanıt" ,Progesspercent="% 59" , ProgessColor="#62B5F0"},
                 new MedicalResultModel{Id="2", DiseaseName="Gıda zehirlenmesi" ,Status="Orta düzeyde kanıt" ,Progesspercent="% 33" , ProgessColor="#62B5F0"},
                 new MedicalResultModel{Id="3", DiseaseName="Bağırsak tıkanması ve adinamik ileus" ,Status="Zayıf kanıt" ,Progesspercent="% 23" , ProgessColor="#A5D9FF"},
                 new MedicalResultModel{Id="4", DiseaseName="Diğer" ,Status="Bilinmeyen" ,Progesspercent="% 18" , ProgessColor="#C4C4C4"},
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
          //  await Navigation.PushModalAsync(new Views.SelectBox.SelectBoxPage());
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