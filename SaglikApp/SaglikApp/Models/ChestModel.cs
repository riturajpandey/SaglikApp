using System;
using System.Collections.Generic;
using System.Text;

namespace SaglikApp.Models
{
    public class ChestModel
    {
        public int Id { get; set; }
        public string PainDescription { get; set; }
        public static List<ChestModel> ChestList()
        {
            return new List<ChestModel>
            {
                new ChestModel{Id=0,PainDescription="Üst ekstremitede ağrı"},
                new ChestModel{Id=1,PainDescription="Üst uzuvlarda şiddetli ağrı"},
                new ChestModel{Id=2,PainDescription="Oğmuz ağrısı"},
                new ChestModel{Id=3,PainDescription="Omzu hareket ettirince ağrı hissetme"},
                new ChestModel{Id=4,PainDescription="Üst ekstremitede ağrı"},
                new ChestModel{Id=5,PainDescription="Üst uzuvlarda şiddetli ağrı"},
            };
        }
    }
}
