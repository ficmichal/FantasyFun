using FantasyFun.API.Models;
using FantasyFun.API.Settings;
using Microsoft.EntityFrameworkCore;

namespace FantasyFun.API.Repositories
{
    public class FootballDbContext : DbContext
    {
        //public const string DbPath = "data\\database.sqlite";
        public readonly string ConnectionString;

        public FootballDbContext(DbSettings dbSettings)
        {
            var folder = Directory.GetCurrentDirectory();
            ConnectionString = Path.Combine(folder, "..", "..", dbSettings.ConnectionString);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={ConnectionString}");

        public virtual DbSet<League> Leagues { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Team> Teams { get; set; } 

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

            modelBuilder.Entity<Team>(entity =>
            {
                entity.ToTable("Team");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ApiId).HasColumnName("team_api_id");

                entity.Property(e => e.FifaApiId).HasColumnName("team_fifa_api_id");

                entity.Property(e => e.LongName).HasColumnName("team_long_name");

                entity.Property(e => e.ShortName).HasColumnName("team_short_name");
            });
        }
    }
}
