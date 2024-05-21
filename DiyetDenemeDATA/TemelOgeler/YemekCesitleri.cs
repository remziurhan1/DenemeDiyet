using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetDenemeDATA.TemelOgeler
{
    public class YemekCesitleri
    {
        public int YemekID { get; set; }
        public string YemekAdlari { get; set; }



        public int OgunID { get; set; }
        [ForeignKey("OgunID")]
        public Ogunler Ogun { get; set; }


        // Bir yemek Çeşidi Birden fazla YemekKategorileri ile ilişkilidir.
        public ICollection<DYemekKategorileri> YemekKategorileri { get; set; }

    }
}
