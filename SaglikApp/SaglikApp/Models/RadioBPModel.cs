using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SaglikApp.Models
{
    public class RadioBPModel : BindableObject
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string RadioYes { get; set; }
        public string RadioNo { get; set; }
        public string RadioNotKnow { get; set; }
     
        private bool _IsRadioYesImg;
        public bool IsRadioYesImg
        {
            get { return _IsRadioYesImg; }
            set
            {
                if (_IsRadioYesImg != value)
                {
                    _IsRadioYesImg = value;
                    OnPropertyChanged("IsRadioYesImg");
                }
            }
        }

        private bool _IsRadioNoImg;
        public bool IsRadioNoImg
        {
            get { return _IsRadioNoImg; }
            set
            {
                if (_IsRadioNoImg != value)
                {
                    _IsRadioNoImg = value;
                    OnPropertyChanged("IsRadioNoImg");
                }
            }
        }

        private bool _IsRadioNotKnowImg;
        public bool IsRadioNotKnowImg
        {
            get { return _IsRadioNotKnowImg; }
            set
            {
                if (_IsRadioNotKnowImg != value)
                {
                    _IsRadioNotKnowImg = value;
                    OnPropertyChanged("IsRadioNotKnowImg");
                }
            }
        }


    }
}
