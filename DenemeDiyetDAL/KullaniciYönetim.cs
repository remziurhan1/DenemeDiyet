using DiyetDenemeDATA.TemelOgeler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenemeDiyetDAL
{
    public class KullaniciYönetim
    {
        private static User _hazirKullanici;

        public static User HazirKullanici
        {
            get { return _hazirKullanici; }
            set { _hazirKullanici = value; }
        }
    }
}
