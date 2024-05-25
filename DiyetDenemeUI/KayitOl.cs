using DenemeDiyetDAL;
using DenemeDiyetDAL.Repository;
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
        UserRepository userRepository = new UserRepository();


        private void s_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Email=txtEmail.Text;
            user.KullaniciSifre=txtSifre.Text;
            user.KullaniciAdi=txtAd.Text;
            user.KullaniciSoyadi=txtSoyad.Text;
            user.Boy = Convert.ToDouble(txtBoy.Text);
            user.Kilo = Convert.ToDouble(txtKilo.Text);
            user.DogumTarihi = dtmDogumTarihi.Value;

            userRepository.Add(user);        


        }
    }
}
