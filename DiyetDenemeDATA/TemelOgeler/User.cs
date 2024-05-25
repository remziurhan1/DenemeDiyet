using DiyetDenemeDATA.TemelOgeler.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetDenemeDATA.TemelOgeler
{
    public class User
    {
        [Key]
        public int KullaniciID { get; set; }
        public string KullaniciAdi { get; set; }
        public string KullaniciSoyadi { get; set; }
        public string KullaniciSifre { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string? TelefonNumarasi { get; set; }
        public bool? Cinsiyet { get; set; }
        public string Email { get; set; }
        public GuvenlikSorusu? GuvenlikSorusu { get; set; }
        public string? GuvenlikSorusuCevap { get; set; }
        public double Boy { get; set; }
        public double Kilo { get; set; }

    }

    
}
