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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DiyetDenemeUI
{
    public partial class ParolayıGuncelle : Form
    {
        public ParolayıGuncelle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string yeniSifre = txtSifre.Text;
            string sifreOnayla = txtSifreTekrar.Text;

            UserRepository userRepository = new UserRepository();
            //IsEmailExist bu UserRepository içerisinde yazıyor
            //Eposta var mı kontrolü yoksa güncelleyemezsin

            try
            {
                //IsEmailExist bu UserRepository içerisinde yazıyor
                //Eposta var mı kontrolü yoksa güncelleyemezsin
                if (!userRepository.MailKayitKontrol(email))
                {
                    MessageBox.Show("Girilen e-posta adresi kayıtlı değil. Lütfen kayıtlı bir e-posta adresi giriniz.");
                    return;
                }
                //IsNullOrWhiteSpace: string ifadelerinin boş veya yalnızca boşluklardan oluşup oluşmadığını kontrol etmek için kullanılır. 
                if (string.IsNullOrWhiteSpace(yeniSifre) || string.IsNullOrWhiteSpace(sifreOnayla))
                {
                    MessageBox.Show("Yeni şifre ve şifre tekrarı alanları boş bırakılamaz.");
                    return;
                }
                //iki şifre de aynı mı
                if (yeniSifre != sifreOnayla)
                {
                    MessageBox.Show("Yeni şifre ve şifre tekrarı uyuşmuyor. Lütfen aynı şifreyi iki kez giriniz.");
                    return;
                }
                ////////////////////////////////////////////////////////////////////
                //Kullanıcı şifresi güncelle
                User user = userRepository.GetUserByEmail(email);

                if (user != null)
                {
                    user.KullaniciSifre = yeniSifre;
                    userRepository.Update(user);//update repositoryden geliyor
                    MessageBox.Show("Şifre güncelleme işlemi başarılı.");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Bir hata oluştu. Lütfen tekrar deneyiniz.");
                }
                ////////////////////////////////////////////////////////////////////
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Şifre güncelleme sırasında bir hata oluştu: {ex.Message}");
            }

        }

        private void btnSifreGoster_Click(object sender, EventArgs e)
        {
            


           

        }
    }
}

