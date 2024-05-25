using DenemeDiyetDAL.Mappings;
using DiyetDenemeDATA.TemelOgeler;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenemeDiyetDAL
{
    public class AppDbContext : DbContext
    {
        public DbSet<Ogunler> Ogunler {  get; set; }
        public DbSet<YemekCesitleri> YemekCesitleri {  get; set; }
        public DbSet<DYemekKategorileri> YemekKategorileri {  get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-MIJ2PSH;Initial Catalog=Yemek2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new OgunlerMapping());
            //modelBuilder.ApplyConfiguration(new YemekCesitleriMapping());
            //modelBuilder.ApplyConfiguration(new YemekKategorileriMapping());
            //base.OnModelCreating(modelBuilder);

            new OgunlerMapping().Configure(modelBuilder.Entity<Ogunler>());
            new YemekCesitleriMapping().Configure(modelBuilder.Entity<YemekCesitleri>());
            new YemekKategorileriMapping().Configure(modelBuilder.Entity<DYemekKategorileri>());
        }

    }
}
