using FantasyFun.API.Models;
using Microsoft.EntityFrameworkCore;

namespace FantasyFun.API.Repositories
{
    public class FootballDbContext : DbContext
    {
        public const string DbPath = "data\\database.sqlite";
        public readonly string ConnectionString;

        public FootballDbContext()
        {
            var folder = Directory.GetCurrentDirectory();
            ConnectionString = Path.Combine(folder, "..", "..", DbPath);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={ConnectionString}");

        public virtual DbSet<League> Leagues { get; set; }
        public virtual DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<League>(entity =>
            {
                entity.ToTable("League");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Leagues)
                    .HasForeignKey(d => d.CountryId);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("Country");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name).HasColumnName("name");
            });
        }
    }
}
