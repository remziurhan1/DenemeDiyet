using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diyet_Deneme_DaLL.Seed
{
    public class YemekKategorileri
    {
        public void AddYemekKategorileri(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<YemekKategorileri>().HasData(

                new YemekKategorileri { ID = 1, Adı = "Kahvaltı" },
                new YemekKategorileri { ID = 2, Adı = "Tahıl Ürünleri" },
                new YemekKategorileri { ID = 3, Adı = "Süt Ürünleri" },
                new YemekKategorileri { ID = 4, Adı = "Sebzeler" },
                new YemekKategorileri { ID = 5, Adı = "Atıştırmalık" },
                new YemekKategorileri { ID = 6, Adı = "Haşlanmış Sebzeler" },
                new YemekKategorileri { ID = 7  Adı = "Salata" },
                new YemekKategorileri { ID = 8  Adı = "Yağlar" },
                new YemekKategorileri { ID = 9  Adı = "Çorbalar" }
                );















                 
        }
    }
}
