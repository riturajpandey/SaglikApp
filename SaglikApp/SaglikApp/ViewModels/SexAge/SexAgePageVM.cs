using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SaglikApp.ViewModels.SexAge
{
    //TODO : To Define Local Class Level Variables..
    // var month = Utility.Utility.ConvertMonthIntoTrukishLanguage(DatePck.Date.Month.ToString());
    //   SexAgeVM.Month = month;

    public class SexAgePageVM : BaseViewModel
    {

        #region CONSTRUCTOR

        /// <summary>
        /// Initializes a new instance of the <see cref="SexAgePageVM"/> class.
        /// </summary>
        /// <param name="nav"></param>
        public SexAgePageVM(INavigation nav)
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

        private string _Date = DateTime.Today.Day.ToString();
        public string Date
        {
            get { return _Date; }
            set
            {
                if (_Date != value)
                {
                    _Date = value;
                    OnPropertyChanged("Date");
                }
            }
        }

        private string _Month = Utility.Utility.ConvertMonthIntoTrukishLanguage(DateTime.Now.Month.ToString());
        public string Month
        {
            get { return _Month; }
            set
            {
                if (_Month != value)
                {
                    _Month = value;
                    OnPropertyChanged("Month");
                }
            }
        }

        private string _Year = DateTime.Today.Year.ToString();
        public string Year
        {
            get { return _Year; }
            set
            {
                if (_Year != value)
                {
                    _Year = value;
                    OnPropertyChanged("Year");
                }
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// TODO : To Navigate On Height Weight Page...
        /// </summary>
        private async void OnNextAsync(object obj)
        {
           await Navigation.PushModalAsync(new Views.HeightWeight.HeightWeightPage());
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
