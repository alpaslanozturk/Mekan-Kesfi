using MekanKesfi.Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MekanKesfi.DataAccess.Concrete.Context
{
    public class MekanKesfiContext : IdentityDbContext<Kullanicilar, Roller, string>
    {
        public MekanKesfiContext(DbContextOptions options) : base (options)
        {
            
        }

        public DbSet<Fotograflar> Fotograflar { get; set; }
        public DbSet<Ilceler> Ilceler { get; set; }
        public DbSet<Iller> Iller { get; set; }
        public DbSet<Mekanlar> Mekanlar { get; set; }
        public DbSet<Reklamlar> Reklamlar { get; set; }
        public DbSet<Urunler> Urunler { get; set; }
    }
}
