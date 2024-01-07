using ASPCORECALISMA.Models;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace ASPCORECALISMA.Concrete
{
    public class Context:IdentityDbContext<Kullanicilar,KullaniciRol,string>
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLDERS;Database=AspCoreTest3DB;Uid=SA;Password=1;TrustServerCertificate=True;MultiSubnetFailover=True");


        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Firmalar>firmalars { get; set; }
        public DbSet<iller>illers { get; set; }
        public DbSet<Kategoriler>kategorilers { get; set; }
        public DbSet<Kullanicilar>kullanicilars { get; set; }
        public DbSet<Urunler>urunlers { get; set; }
        public DbSet<Carousel> carousels { get; set; }

        public DbSet<CategoriesMonth> categoriesMonths { get; set; }

        public DbSet<Contact> contacts { get; set; }
    }
}
