using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SaglikApp.Models
{
    public class SymptomsNameModel : BindableObject
    {
        public string Id { get; set; }
        //public string SymptomsName { get; set; }

        private string _SymptomsName;
        public string SymptomsName
        {
            get { return _SymptomsName; }
            set
            {
                if (_SymptomsName != value)
                {
                    _SymptomsName = value;
                    OnPropertyChanged("SymptomsName");
                }
            }
        }

        private bool _IsActiveSymptoms;
        public bool IsActiveSymptoms
        {
            get { return _IsActiveSymptoms; }
            set
            {
                if (_IsActiveSymptoms != value)
                {
                    _IsActiveSymptoms = value;
                    OnPropertyChanged("IsActiveSymptoms");
                }
            }
        }

        private string _SymptomsTextColor;
        public string SymptomsTextColor
        {
            get { return _SymptomsTextColor; }
            set
            {
                if (_SymptomsTextColor != value)
                {
                    _SymptomsTextColor = value;
                    OnPropertyChanged("SymptomsTextColor");
                }
            }
        }

        private string _SymptomsFontFamily;
        public string SymptomsFontFamily
        {
            get { return _SymptomsFontFamily; }
            set
            {
                if (_SymptomsFontFamily != value)
                {
                    _SymptomsFontFamily = value;
                    OnPropertyChanged("SymptomsFontFamily");
                }
            }
        }

        private string _InputkitBorderColor;
        public string InputkitBorderColor
        {
            get { return _InputkitBorderColor; }
            set
            {
                if (_InputkitBorderColor != value)
                {
                    _InputkitBorderColor = value;
                    OnPropertyChanged("InputkitBorderColor");
                }
            }
        }

        private string _InputkitBackgroundColor;
        public string InputkitBackgroundColor
        {
            get { return _InputkitBackgroundColor; }
            set
            {
                if (_InputkitBackgroundColor != value)
                {
                    _InputkitBackgroundColor = value;
                    OnPropertyChanged("InputkitBackgroundColor");
                }
            }
        }

    }
}
