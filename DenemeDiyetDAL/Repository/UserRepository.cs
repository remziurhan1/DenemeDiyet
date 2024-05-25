using DiyetDenemeDATA.TemelOgeler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenemeDiyetDAL.Repository
{
    public class UserRepository : IRepository<User>
    {
        AppDbContext context= new AppDbContext();
        public void Add(User item)
        {
            context.Users.Add(item);
            context.SaveChanges();
        }

        public void Delete(User item)
        {
            context.Users.Remove(item);
            context.SaveChanges();
        }

        public List<User> GetAll()
        {
            return context.Users.ToList();
        }

        public User GetID(int id)
        {
            return context.Users.Find(id);
        }

        public void Update(User item)
        {
            context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
        //kayıt olurken email sadece 1 kişi özelinde kayıt olmalı
        public bool MailKayitKontrol(string email)
        {
            return context.Users.Any(u => u.Email.Equals(email));
        }

        //login için
        public User Giriş(string email, string password)
        {
            var kullaniciGirisi = context.Users.FirstOrDefault(u => u.Email.Equals(email) && u.KullaniciSifre.Equals(password));

            return kullaniciGirisi;
        }
        // Veritabanından e-posta adresine göre kullanıcıyı getir
        public User GetUserByEmail(string email)
        {
            return context.Users.FirstOrDefault(u => u.Email.Equals(email));
        }





    }
}
