using FantasyFun.DataMigrator.Models;
using Microsoft.EntityFrameworkCore;
using FantasyFun.DataMigrator.Settings;

namespace FantasyFun.DataMigrator.DbContexts
{
    public class FootballDbContext : DbContext
    {

        public FootballDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source = C:\\Users\\mikol\\source\\repos\\C#\\FantasyFun\\data\\database.sqlite");
        
        public virtual DbSet<League> Leagues { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Team> Teams { get; set; } 
        public virtual DbSet<Player> Players { get; set; }  
        public virtual DbSet<Player_Attribute> PlayerAttributes { get; set; }
        public virtual DbSet<Match> Matches { get; set; }

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

            modelBuilder.Entity<Player>(entity =>
            {
                entity.ToTable("Player");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ApiId).HasColumnName("player_api_id");

                entity.Property(e => e.Name).HasColumnName("player_name");

                entity.Property(e => e.FifaApiId).HasColumnName("player_fifa_api_id");

                entity.Property(e => e.Birthday).HasColumnName("birthday");
            });

            modelBuilder.Entity<Player_Attribute>(entity =>
            {
                entity.ToTable("Player_Attributes");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FifaApiId).HasColumnName("player_fifa_api_id");

                entity.Property(e => e.ApiId).HasColumnName("player_api_id");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.OverallRating).HasColumnName("overall_rating");

                entity.HasOne(d => d.Player)
                      .WithMany(p => p.Players)
                      .HasForeignKey(d => d.ApiId)
                      .HasPrincipalKey(p => p.ApiId);
            });

            modelBuilder.Entity<Match>(entity =>
            {
                entity.ToTable("Match");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.LeagueId).HasColumnName("league_id");

                entity.Property(e => e.Season).HasColumnName("season");

                entity.Property(e => e.Stage).HasColumnName("stage");

                entity.Property(e => e.Date).HasColumnName("date");
                
                entity.Property(e => e.MatchApiId).HasColumnName("match_api_id");
                
                entity.Property(e => e.HomeTeamApiId).HasColumnName("home_team_api_id");
                
                entity.Property(e => e.AwayTeamApiId).HasColumnName("away_team_api_id");
                
                entity.Property(e => e.HomeTeamGoal).HasColumnName("home_team_goal");

                entity.Property(e => e.AwayTeamGoal).HasColumnName("away_team_goal");

                entity.Property(e => e.HomePlayerX1).HasColumnName("home_player_X1");

                entity.Property(e => e.HomePlayerX2).HasColumnName("home_player_X2");

                entity.Property(e => e.HomePlayerX3).HasColumnName("home_player_X3");

                entity.Property(e => e.HomePlayerX4).HasColumnName("home_player_X4");

                entity.Property(e => e.HomePlayerX5).HasColumnName("home_player_X5");

                entity.Property(e => e.HomePlayerX6).HasColumnName("home_player_X6");

                entity.Property(e => e.HomePlayerX7).HasColumnName("home_player_X7");

                entity.Property(e => e.HomePlayerX8).HasColumnName("home_player_X8");

                entity.Property(e => e.HomePlayerX9).HasColumnName("home_player_X9");

                entity.Property(e => e.HomePlayerX10).HasColumnName("home_player_X10");

                entity.Property(e => e.HomePlayerX11).HasColumnName("home_player_X11");

                entity.Property(e => e.AwayPlayerX1).HasColumnName("away_player_X1");

                entity.Property(e => e.AwayPlayerX2).HasColumnName("away_player_X2");

                entity.Property(e => e.AwayPlayerX3).HasColumnName("away_player_X3");

                entity.Property(e => e.AwayPlayerX4).HasColumnName("away_player_X4");

                entity.Property(e => e.AwayPlayerX5).HasColumnName("away_player_X5");

                entity.Property(e => e.AwayPlayerX6).HasColumnName("away_player_X6");

                entity.Property(e => e.AwayPlayerX7).HasColumnName("away_player_X7");

                entity.Property(e => e.AwayPlayerX8).HasColumnName("away_player_X8");

                entity.Property(e => e.AwayPlayerX9).HasColumnName("away_player_X9");

                entity.Property(e => e.AwayPlayerX10).HasColumnName("away_player_X10");

                entity.Property(e => e.AwayPlayerX11).HasColumnName("away_player_X11");

                entity.Property(e => e.HomePlayerY1).HasColumnName("home_player_Y1");

                entity.Property(e => e.HomePlayerY2).HasColumnName("home_player_Y2");

                entity.Property(e => e.HomePlayerY3).HasColumnName("home_player_Y3");

                entity.Property(e => e.HomePlayerY4).HasColumnName("home_player_Y4");

                entity.Property(e => e.HomePlayerY5).HasColumnName("home_player_Y5");

                entity.Property(e => e.HomePlayerY6).HasColumnName("home_player_Y6");

                entity.Property(e => e.HomePlayerY7).HasColumnName("home_player_Y7");

                entity.Property(e => e.HomePlayerY8).HasColumnName("home_player_Y8");

                entity.Property(e => e.HomePlayerY9).HasColumnName("home_player_Y9");

                entity.Property(e => e.HomePlayerY10).HasColumnName("home_player_Y10");

                entity.Property(e => e.HomePlayerY11).HasColumnName("home_player_Y11");

                entity.Property(e => e.AwayPlayerY1).HasColumnName("away_player_Y1");

                entity.Property(e => e.AwayPlayerY2).HasColumnName("away_player_Y2");

                entity.Property(e => e.AwayPlayerY3).HasColumnName("away_player_Y3");

                entity.Property(e => e.AwayPlayerY4).HasColumnName("away_player_Y4");

                entity.Property(e => e.AwayPlayerY5).HasColumnName("away_player_Y5");

                entity.Property(e => e.AwayPlayerY6).HasColumnName("away_player_Y6");

                entity.Property(e => e.AwayPlayerY7).HasColumnName("away_player_Y7");

                entity.Property(e => e.AwayPlayerY8).HasColumnName("away_player_Y8");

                entity.Property(e => e.AwayPlayerY9).HasColumnName("away_player_Y9");

                entity.Property(e => e.AwayPlayerY10).HasColumnName("away_player_Y10");

                entity.Property(e => e.AwayPlayerY11).HasColumnName("away_player_Y11");

                entity.Property(e => e.HomePlayer1).HasColumnName("home_player_1");

                entity.Property(e => e.HomePlayer2).HasColumnName("home_player_2");

                entity.Property(e => e.HomePlayer3).HasColumnName("home_player_3");

                entity.Property(e => e.HomePlayer4).HasColumnName("home_player_4");

                entity.Property(e => e.HomePlayer5).HasColumnName("home_player_5");

                entity.Property(e => e.HomePlayer6).HasColumnName("home_player_6");

                entity.Property(e => e.HomePlayer7).HasColumnName("home_player_7");

                entity.Property(e => e.HomePlayer8).HasColumnName("home_player_8");

                entity.Property(e => e.HomePlayer9).HasColumnName("home_player_9");

                entity.Property(e => e.HomePlayer10).HasColumnName("home_player_10");

                entity.Property(e => e.HomePlayer11).HasColumnName("home_player_11");

                entity.Property(e => e.AwayPlayer1).HasColumnName("away_player_1");

                entity.Property(e => e.AwayPlayer2).HasColumnName("away_player_2");

                entity.Property(e => e.AwayPlayer3).HasColumnName("away_player_3");

                entity.Property(e => e.AwayPlayer4).HasColumnName("away_player_4");

                entity.Property(e => e.AwayPlayer5).HasColumnName("away_player_5");

                entity.Property(e => e.AwayPlayer6).HasColumnName("away_player_6");

                entity.Property(e => e.AwayPlayer7).HasColumnName("away_player_7");

                entity.Property(e => e.AwayPlayer8).HasColumnName("away_player_8");

                entity.Property(e => e.AwayPlayer9).HasColumnName("away_player_9");

                entity.Property(e => e.AwayPlayer10).HasColumnName("away_player_10");

                entity.Property(e => e.AwayPlayer11).HasColumnName("away_player_11");

                entity.Property(e => e.Goal).HasColumnName("goal");

                entity.Property(e => e.Card).HasColumnName("card");

            });
        }
    }
}
