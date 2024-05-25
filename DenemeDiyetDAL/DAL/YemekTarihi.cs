using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diyet_Deneme_DaLL.Entities
{
    internal class YemekTarihi:Base
    {
        public int UserID {  get; set; }    
        public string Tarih {  get; set; }  
        public string Yemek {  get; set; }  
        public  double ToplamKalori {  get; set; } 
        
        public double Yağ {  get; set; }    
        public double protein {  get; set; }    
        public double Karbonhidrat {  get; set; }   


    }
}
