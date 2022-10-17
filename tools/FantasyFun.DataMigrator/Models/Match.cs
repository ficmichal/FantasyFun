using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyFun.DataMigrator.Models
{
    public class Match
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public int CountryId { get; set; }
        public int LeagueId { get; set; }
        public string Season { get; set; }
        public int Stage { get; set; }
        public DateTime Date { get; set; }
        public int MatchApiId { get; set; }
        public int HomeTeamApiId { get; set; }
        public int AwayTeamApiId { get; set; }
        public int HomeTeamGoal { get; set; }
        public int AwayTeamGoal { get; set; }
        public int? HomePlayerX1 { get; set; }
        public int? HomePlayerX2 { get; set; }
        public int? HomePlayerX3 { get; set; }
        public int? HomePlayerX4 { get; set; }
        public int? HomePlayerX5 { get; set; }
        public int? HomePlayerX6 { get; set; }
        public int? HomePlayerX7 { get; set; }
        public int? HomePlayerX8 { get; set; }
        public int? HomePlayerX9 { get; set; }
        public int? HomePlayerX10 { get; set; }
        public int? HomePlayerX11 { get; set; }
        public int? AwayPlayerX1 { get; set; }
        public int? AwayPlayerX2 { get; set; }
        public int? AwayPlayerX3 { get; set; }
        public int? AwayPlayerX4 { get; set; }
        public int? AwayPlayerX5 { get; set; }
        public int? AwayPlayerX6 { get; set; }
        public int? AwayPlayerX7 { get; set; }
        public int? AwayPlayerX8 { get; set; }
        public int? AwayPlayerX9 { get; set; }
        public int? AwayPlayerX10 { get; set; }
        public int? AwayPlayerX11 { get; set; }
        public int? HomePlayerY1 { get; set; }
        public int? HomePlayerY2 { get; set; }
        public int? HomePlayerY3 { get; set; }
        public int? HomePlayerY4 { get; set; }
        public int? HomePlayerY5 { get; set; }
        public int? HomePlayerY6 { get; set; }
        public int? HomePlayerY7 { get; set; }
        public int? HomePlayerY8 { get; set; }
        public int? HomePlayerY9 { get; set; }
        public int? HomePlayerY10 { get; set; }
        public int? HomePlayerY11 { get; set; }
        public int? AwayPlayerY1 { get; set; }
        public int? AwayPlayerY2 { get; set; }
        public int? AwayPlayerY3 { get; set; }
        public int? AwayPlayerY4 { get; set; }
        public int? AwayPlayerY5 { get; set; }
        public int? AwayPlayerY6 { get; set; }
        public int? AwayPlayerY7 { get; set; }
        public int? AwayPlayerY8 { get; set; }
        public int? AwayPlayerY9 { get; set; }
        public int? AwayPlayerY10 { get; set; }
        public int? AwayPlayerY11 { get; set; }
        public int? HomePlayer1 { get; set; }
        public int? HomePlayer2 { get; set; }
        public int? HomePlayer3 { get; set; }
        public int? HomePlayer4 { get; set; }
        public int? HomePlayer5 { get; set; }
        public int? HomePlayer6 { get; set; }
        public int? HomePlayer7 { get; set; }
        public int? HomePlayer8 { get; set; }
        public int? HomePlayer9 { get; set; }
        public int? HomePlayer10 { get; set; }
        public int? HomePlayer11 { get; set; }
        public int? AwayPlayer1 { get; set; }
        public int? AwayPlayer2 { get; set; }
        public int? AwayPlayer3 { get; set; }
        public int? AwayPlayer4 { get; set; }
        public int? AwayPlayer5 { get; set; }
        public int? AwayPlayer6 { get; set; }
        public int? AwayPlayer7 { get; set; }
        public int? AwayPlayer8 { get; set; }
        public int? AwayPlayer9 { get; set; }
        public int? AwayPlayer10 { get; set; }
        public int? AwayPlayer11 { get; set; }
        public string? Goal { get; set; }
        public string? Card { get; set; }
    }
}
