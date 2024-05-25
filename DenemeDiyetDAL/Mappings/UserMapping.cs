using DiyetDenemeDATA.TemelOgeler;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenemeDiyetDAL.Mappings
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x=> x.KullaniciAdi).HasMaxLength(20);
            builder.Property(x=>x.KullaniciSoyadi).HasMaxLength(20);
            builder.Property(x=>x.KullaniciSifre).HasMaxLength(15);
            builder.Property(x => x.DogumTarihi);
            builder.Property(x => x.Email).HasMaxLength(100);
            builder.HasIndex(x => x.Email).IsUnique();
            builder.Property(x => x.TelefonNumarasi).HasMaxLength(10);
            builder.Property(x => x.Boy).HasMaxLength(5);
            builder.Property(x => x.Kilo).HasMaxLength(5);
            //builder.Property(x => x.GuvenlikSorusuCevap).HasMaxLength(50);

        }
    }
}
