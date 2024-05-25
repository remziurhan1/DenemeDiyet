using DenemeDiyetDAL;
using DenemeDiyetDAL.Repository;
using DiyetDenemeDATA.TemelOgeler;
using Microsoft.AspNetCore.Identity;
using Microsoft.VisualBasic.Logging;
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
    public partial class Ayarlar : Form
    {
        AppDbContext context = new AppDbContext();
        UserRepository userRepository = new UserRepository();
        public Ayarlar()
        {
            InitializeComponent();
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var guncellenecek = context.Users.First(x => x.Email == KullaniciYönetim.HazirKullanici.Email);
            guncellenecek.KullaniciAdi = txtAd.Text;
            guncellenecek.KullaniciSoyadi = txtSoyad.Text;
            guncellenecek.Boy = Convert.ToDouble(txtBoy.Text);
            guncellenecek.Kilo = Convert.ToDouble(txtAgirlik.Text);
            guncellenecek.DogumTarihi = Convert.ToDateTime(dtpDogumTarihi.Text);

            KullaniciYönetim.HazirKullanici.KullaniciAdi = txtAd.Text;
            KullaniciYönetim.HazirKullanici.KullaniciSoyadi = txtSoyad.Text;
            KullaniciYönetim.HazirKullanici.Boy = Convert.ToDouble(txtBoy.Text);
            KullaniciYönetim.HazirKullanici.Kilo = Convert.ToDouble(txtAgirlik.Text);
            KullaniciYönetim.HazirKullanici.DogumTarihi = Convert.ToDateTime(dtpDogumTarihi.Text);

            DialogResult result = MessageBox.Show("Bilgileriniz Güncellemek İstiyor musunuz?", "Onaylayınız", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                userRepository.Update(guncellenecek);
                MessageBox.Show("Profile updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var sil = context.Users.FirstOrDefault(x => x.Email == KullaniciYönetim.HazirKullanici.Email);

            DialogResult result = MessageBox.Show("Silmek İstiyor musunuz", "Onaylayın", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                userRepository.Delete(sil);
                MessageBox.Show("Profil başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Giris login = new Giris();
                login.Show();
                this.Hide();
            }
        }

        private void txtBoy_Leave(object sender, EventArgs e)
        {
            string boyBilgisi = txtBoy.Text;
            if (double.TryParse(boyBilgisi, out double boy))
            {
                if (boy >= 100 && boy <= 250)
                {
                    return;
                }
            }
            MessageBox.Show("Lütfen 100cm ile 250cm arasında giriş yapınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtBoy.Focus();
        }

        private void txtAgirlik_Leave(object sender, EventArgs e)
        {
            string agirlikGiris = txtAgirlik.Text;
            if (double.TryParse(agirlikGiris, out double agirlik))
            {
                if (agirlik >= 30 && agirlik <= 300)
                {
                    return;
                }
            }
            MessageBox.Show("Lütfen 30kg ile 250kg arasında giriş yapınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtAgirlik.Focus();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            
        }

        private void txtCikis_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Hide();
        }
    }
}
