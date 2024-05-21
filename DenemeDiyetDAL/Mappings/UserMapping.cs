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
            builder.Property(x=> x.KullaniciAdi).IsRequired().HasMaxLength(20);
            builder.Property(x=>x.KullaniciSoyadi).IsRequired().HasMaxLength(20);
            builder.Property(x=>x.KullaniciSifre).IsRequired().HasMaxLength(15);
            builder.Property(x => x.DogumTarihi).IsRequired();
            builder.Property(x => x.Email).IsRequired().HasMaxLength(100);
            builder.HasIndex(x => x.Email).IsUnique();
            builder.Property(x => x.TelefonNumarasi).IsRequired().HasMaxLength(10);
            builder.Property(x => x.Boy).IsRequired().HasMaxLength(5);
            builder.Property(x => x.Kilo).IsRequired().HasMaxLength(5);
            builder.Property(x => x.GuvenlikSorusuCevap).IsRequired().HasMaxLength(50);

        }
    }
}
