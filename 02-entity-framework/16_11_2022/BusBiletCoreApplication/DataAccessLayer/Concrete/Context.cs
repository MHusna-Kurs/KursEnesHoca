using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=405-03;" +
                                        "database=DBBusBilet;" +
                                        "Persist Security Info=True;"+
                                        "User ID=sa;"+
                                        "Password=1234");
        }

        public DbSet<Firma> firmalar { get; set; }
        public DbSet<Guzergah> guzergahlar { get; set; }
        public DbSet<Otobus> otobusler { get; set; }
        public DbSet<Kullanici> kullanicilar { get; set; }
        public DbSet<GuzergahOtobus> guzergahOtobusler { get; set; }
        public DbSet<GuzergahOtobusKullanici> guzergahOtobusKullanicilar { get; set; }
    }
}
