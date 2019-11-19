using EFCore.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore.WebAPI.Data
{
    public class AppDataContext : DbContext
    {
        public DbSet<Heroi> Herois { get; set; }
       
        public DbSet<Arma> Armas { get; set; }
        
        public DbSet<Batalha> Batalhas { get; set; }

        public DbSet<HeroiBatalha> HeroisBatalhas { get; set; }

        public DbSet<IdentidadeSecreta> IdentidadesSecretas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=den1.mssql8.gear.host;Database=pdadb;User Id=pdadb; Password=Gw6Q_c?VZ9zF");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HeroiBatalha>( entity => 
            {
                entity.HasKey(e => new { e.BatalhaId, e.HeroiId });
                
            });
        }
    

    }

}
