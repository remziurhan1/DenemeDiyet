using DiyetDenemeDATA.TemelOgeler;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenemeDiyetDAL.Mappings
{
    public class OgunlerMapping : IEntityTypeConfiguration<Ogunler>
    {
        public void Configure(EntityTypeBuilder<Ogunler> builder)
        {
            builder.HasKey(o=>o.OgunID);
            builder.Property(o => o.OgunAdi).IsRequired().HasMaxLength(50);

            //Bir öğün birden fazla Yemekçeşitleri içerebilir
            builder.HasMany(o => o.YemekCesitleris).WithOne(y => y.Ogun).HasForeignKey(y => y.OgunID);
        }
    }
}
