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
    public class YemekKategorileriMapping : IEntityTypeConfiguration<DYemekKategorileri>
    {
        public void Configure(EntityTypeBuilder<DYemekKategorileri> builder)
        {
            builder.HasKey(k=>k.KategoriID);
            builder.Property(k=>k.KategoriName)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
