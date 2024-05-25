using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


using Microsoft.EntityFrameworkCore;
using Diyet_Deneme_DaLL.Entities;

namespace Diyet_Deneme_DaLL.Seed
{
    public class YemekKalorileri
    {
        public void YemekBilgisiEKle(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Yemek>.HasData(

                new Yemek { ID = 1, Adı = " Peynirli Omlet", Ölçü = 1, Kalori = 254, Karbonhidrat = 2.05, Yağ = 14.9, protein = 15.37, Resim = @ "\ Resim \ 1.jpg" },
                new Yemek { ID = 2, Adı = "Mantarlı Omlet", Ölçü = 1, Kalori = 205, Karbonhidrat = 3.69, Yağ = 9.9, protein = 12.46, Resim = @ "\ Resim \ 2.jpg" },
                new Yemek { ID = 3, Adı = "Menemen ", Ölçü = 1, Kalori = 205, Karbonhidrat = 3.69, Yağ = 9.9, protein = 12.46, Resim = @ "\ Resim \ 3.jpg" },
                new Yemek { ID = 4, Adı = " Kaşarlı Omlet", Ölçü = 1, Kalori = 260.3, Karbonhidrat = 2.2, Yağ = 13.29, protein = 20.27, Resim = @ "\ Resim \ 4.jpg" },
                new Yemek { ID = 5, Adı = "Sebzeli Omlet", Ölçü = 1, Kalori = 205, Karbonhidrat = 3.69, Yağ = 9.9, protein = 12.46, Resim = @ "\ Resim \ 5.jpg" },
                new Yemek { ID = 6, Adı = "Yulaflı Omlet", Ölçü = 1, Kalori = 258, Karbonhidrat = 14.4, Yağ = 10.8, protein = 14.52 }

                


        }


    }
}
