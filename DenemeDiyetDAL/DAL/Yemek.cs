using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diyet_Deneme_DaLL.Entities
{
    internal class Yemek:Base
    {
        public string Adı {  get; set; }    
        public double Ölçü {  get; set; } 
        public  double Kalori {  get; set; }    
        public double Karbonhidrat {  get; set; }
        public double Yağ { get; set; }
        public double protein {  get; set; }    
        public  string Resim {  get; set; }
        public virtual ICollection<YemekKategorileri> YemekKategorileris { get; set; } = new List<YemekKategorileri>();

    }
}
