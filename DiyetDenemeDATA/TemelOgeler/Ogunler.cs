using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetDenemeDATA.TemelOgeler
{
    public class Ogunler
    {
        public int OgunID { get; set; }
        public string OgunAdi { get; set; }

        //Birden fazla YemekCesitleri içerir. Bire çok ilişki
        public ICollection<YemekCesitleri> YemekCesitleris { get; set; }


    }
}
