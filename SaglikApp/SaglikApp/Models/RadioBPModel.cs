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

        private string _SelectedBackgroundYes;
        public string SelectedBackgroundYes
        {
            get { return _SelectedBackgroundYes; }
            set
            {
                if (_SelectedBackgroundYes != value)
                {
                    _SelectedBackgroundYes = value;
                    OnPropertyChanged("SelectedBackgroundYes");
                }
            }
        }

        private string _SelectedBackgroundNo;
        public string SelectedBackgroundNo
        {
            get { return _SelectedBackgroundNo; }
            set
            {
                if (_SelectedBackgroundNo != value)
                {
                    _SelectedBackgroundNo = value;
                    OnPropertyChanged("SelectedBackgroundNo");
                }
            }
        }

        private string _SelectedBackgroundNotKnow;
        public string SelectedBackgroundNotKnow
        {
            get { return _SelectedBackgroundNotKnow; }
            set
            {
                if (_SelectedBackgroundNotKnow != value)
                {
                    _SelectedBackgroundNotKnow = value;
                    OnPropertyChanged("SelectedBackgroundNotKnow");
                }
            }
        }

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

        public static List<RadioBPModel> RadioBPList()
        {
            return new List<RadioBPModel>
            {
                new RadioBPModel{Id="0", Title="Yüksek tansiyonum var", RadioYes="Evet",RadioNo="Hayır",RadioNotKnow="Bilmiyorum", SelectedBackgroundYes="#FFFFFF", SelectedBackgroundNo="#FFFFFF", SelectedBackgroundNotKnow="#FFFFFF", IsRadioYesImg=true, IsRadioNoImg=false , IsRadioNotKnowImg=false},
                new RadioBPModel{ Id="1", Title="Sigara kullanıyorum",RadioYes="Evet", RadioNo="Hayır",RadioNotKnow="Bilmiyorum", SelectedBackgroundYes="#FFFFFF", SelectedBackgroundNo="#FFFFFF", SelectedBackgroundNotKnow="#FFFFFF", IsRadioYesImg=true, IsRadioNoImg=false , IsRadioNotKnowImg=false },
                 new RadioBPModel{Id="0", Title="Yüksek tansiyonum var", RadioYes="Evet",RadioNo="Hayır",RadioNotKnow="Bilmiyorum", SelectedBackgroundYes="#FFFFFF", SelectedBackgroundNo="#FFFFFF", SelectedBackgroundNotKnow="#FFFFFF", IsRadioYesImg=true, IsRadioNoImg=false , IsRadioNotKnowImg=false},
                new RadioBPModel{ Id="1", Title="Sigara kullanıyorum",RadioYes="Evet", RadioNo="Hayır",RadioNotKnow="Bilmiyorum", SelectedBackgroundYes="#FFFFFF", SelectedBackgroundNo="#FFFFFF", SelectedBackgroundNotKnow="#FFFFFF", IsRadioYesImg=true, IsRadioNoImg=false , IsRadioNotKnowImg=false },
                new RadioBPModel{Id="0", Title="Yüksek tansiyonum var", RadioYes="Evet",RadioNo="Hayır",RadioNotKnow="Bilmiyorum", SelectedBackgroundYes="#FFFFFF", SelectedBackgroundNo="#FFFFFF", SelectedBackgroundNotKnow="#FFFFFF", IsRadioYesImg=true, IsRadioNoImg=false , IsRadioNotKnowImg=false},
                new RadioBPModel{ Id="1", Title="Sigara kullanıyorum",RadioYes="Evet", RadioNo="Hayır",RadioNotKnow="Bilmiyorum", SelectedBackgroundYes="#FFFFFF", SelectedBackgroundNo="#FFFFFF", SelectedBackgroundNotKnow="#FFFFFF", IsRadioYesImg=true, IsRadioNoImg=false , IsRadioNotKnowImg=false }
            };
        }
    }
}
