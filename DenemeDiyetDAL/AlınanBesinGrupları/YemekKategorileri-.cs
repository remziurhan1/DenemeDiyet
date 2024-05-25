using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diyet_Deneme_DaLL.Seed
{
    public class YemekKategorileri_
    {
        public void AddYemekKategorileriDara(ModelBuilder modelBuilder)
        {
            new YemekKategorileri_ { YemekID=1,  YemekKategorileriID=1},
            new YemekKategorileri_ { YemekID=2,  YemekKategorileriID=2 },
            new YemekKategorileri_ { YemekID=3,  YemekKategorileri_ID=3 }, 
            new YemekKategorileri_ { YemekID=4,  YemekKategorileri_ID=4 },   
            new YemekKategorileri_ { YemekID=5,  YemekKategorileri_ID=5 },  

        }
    }
}
