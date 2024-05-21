using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetDenemeDATA.TemelOgeler
{
    public class DYemekKategorileri
    {
        public int KategoriID { get; set; }
        public string KategoriName { get; set; }

        public ICollection<YemekCesitleri> YemekCesitleris { get;}
    }
}
