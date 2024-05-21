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
    public class YemekCesitleriMapping : IEntityTypeConfiguration<YemekCesitleri>
    {
        public void Configure(EntityTypeBuilder<YemekCesitleri> builder)
        {
            builder.HasKey(o=>o.YemekID);
            builder.Property(y => y.YemekAdlari).IsRequired().HasMaxLength(100);
            builder.HasOne(y => y.Ogun)
                .WithMany(k => k.YemekCesitleris)
                .HasForeignKey(y => y.OgunID);

            builder.HasMany(y => y.YemekKategorileri)
                .WithMany(k => k.YemekCesitleris)
                .UsingEntity<Dictionary<string, string>>("YemekCesidiKategori",
                y => y.HasOne<DYemekKategorileri>().WithMany().HasForeignKey("KategoriID"),
                k => k.HasOne<YemekCesitleri>().WithMany().HasForeignKey("YemekID"));
            
        }
    }
}
