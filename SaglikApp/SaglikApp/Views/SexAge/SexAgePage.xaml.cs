using SaglikApp.ViewModels.SexAge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace SaglikApp.Views.SexAge
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SexAgePage : ContentPage
    {
        //TODO : To Define class Level Variables...
        SexAgePageVM SexAgeVM;
        public SexAgePage()
        {
            InitializeComponent();
            SexAgeVM = new SexAgePageVM(this.Navigation);
            this.BindingContext = SexAgeVM;

            // iOS Platform
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }       

        private void DatePck_Tapped(object sender, EventArgs e)
        {
            DatePck.Focus();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DatePkr_DateSelected(object sender, DateChangedEventArgs e)
        {
            var DOB = DatePck.Date;
            SexAgeVM.Date = DOB.Day.ToString();          
            SexAgeVM.Year = DOB.Year.ToString();
            var month = Utility.Utility.ConvertMonthIntoTrukishLanguage(DatePck.Date.Month.ToString());
            SexAgeVM.Month = month;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DatePkr_Unfocused(object sender, FocusEventArgs e)
        {
            if (DatePck.Date != null)
            {
                var DOB = DatePck.Date;
                SexAgeVM.Date = DOB.Day.ToString();
                SexAgeVM.Year = DOB.Year.ToString();
                var month = Utility.Utility.ConvertMonthIntoTrukishLanguage(DatePck.Date.Month.ToString());
                SexAgeVM.Month = month;
            }
        }
    }
}