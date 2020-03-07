using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SaglikApp.Models
{
    public class MedicalResultModel : BindableObject
    {
        public string Id { get; set; }
        public string DiseaseName { get; set; }
        public string Status { get; set; }
        public string Progesspercent { get; set; }
        public string ProgessColor { get; set; }

    }
}
