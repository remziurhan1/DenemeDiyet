using DenemeDiyetDAL;
using DiyetDenemeDATA.TemelOgeler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiyetDenemeUI
{
    public partial class KayitOl : Form
    {
        
        public KayitOl()
        {
            InitializeComponent();
        }



        private void s_Click(object sender, EventArgs e)
        {
            AppDbContext context;
            using (context = new AppDbContext()) 
            {
                User user = new User()
                {
                    Email=txtKullaniciAdi.Text,
                    KullaniciSifre=txtSifre.Text,
                    KullaniciAdi=txtAd.Text,
                    Boy=Convert.ToDouble(txtBoy.Text),
                    Kilo=Convert.ToDouble(txtKilo.Text),
                    DogumTarihi=dtmDogumTarihi.Value
                };

                context.Users.Add(user);
                context.SaveChanges();
            }
        }
    }
}
