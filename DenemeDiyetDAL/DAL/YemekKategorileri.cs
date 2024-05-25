using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diyet_Deneme_DaLL.Entities
{
    internal class YemekKategorileri
    {
        public int YemekKategorileriID {  get; set; }   
        public  Yemek Yemek { get; set; } 
        public string YamekAdı {  get; set; }   
        public virtual ICollection<YemekKategorileri> GetYemekKategorileris {  get; set; } =new List<YemekKategorileri>();
    }
}
