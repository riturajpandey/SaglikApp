using Acr.UserDialogs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
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
            FemaleCommand = new Command(OnFemaleAsync);
            MaleCommand = new Command(OnMaleAsync);
        }
        #endregion

        #region COMMANDS

        public Command NextCommand { get; set; }
        public Command BackCommand { get; set; } 
        public Command FemaleCommand { get; set; }
        public Command MaleCommand { get; set; }

        #endregion

        #region Properties

        private string _SelectFemale ;
        public string SelectFemale
        {
            get { return _SelectFemale; }
            set
            {
                if (_SelectFemale != value)
                {
                    _SelectFemale = value;
                    OnPropertyChanged("SelectFemale");
                }
            }
        }

        private string _SelectMale;
        public string SelectMale
        {
            get { return _SelectMale; }
            set
            {
                if (_SelectMale != value)
                {
                    _SelectMale = value;
                    OnPropertyChanged("SelectMale");
                }
            }
        }

        private bool _IsActiveFemale;
        public bool IsActiveFemale
        {
            get { return _IsActiveFemale; }
            set
            {
                if (_IsActiveFemale != value)
                {
                    _IsActiveFemale = value;
                    OnPropertyChanged("IsActiveFemale");
                }
            }
        }

        private bool _IsActiveMale;
        public bool IsActiveMale
        {
            get { return _IsActiveMale; }
            set
            {
                if (_IsActiveMale != value)
                {
                    _IsActiveMale = value;
                    OnPropertyChanged("IsActiveMale");
                }
            }
        }

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
        /// TODO : To select Female option...
        /// </summary>
        private async void OnFemaleAsync(object obj)
        {
            SelectFemale ="#0072C3";
            SelectMale = "#FFFFFF";
            IsActiveFemale = true;
            IsActiveMale = false;
        }

        /// <summary>
        /// TODO : To select Male option ...
        /// </summary>
        private async void OnMaleAsync(object obj)
        {
            SelectFemale ="#FFFFFF";
            SelectMale = "#0072C3";
            IsActiveFemale = false;
            IsActiveMale = true;
        }

        /// <summary>
        /// TODO : To Navigate On Height Weight Page...
        /// </summary>
        private async void OnNextAsync(object obj)
        {
            //Apply Validations..
            if (!await Validate()) return;
            try
            {
                await Navigation.PushModalAsync(new Views.HeightWeight.HeightWeightPage());
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
        /// TODO : To Validate User Male and female Fields...
        /// </summary>
        /// <returns></returns>
        private async Task<bool> Validate()
        {
            if ((IsActiveFemale == false && IsActiveMale == false ))
            {
                UserDialogs.Instance.Alert("Lütfen kadın ve erkek seçin.");
                return false;
            }

            return true;
        }

        #endregion
    }
}
