using System.ComponentModel.DataAnnotations.Schema;

namespace FantasyFun.DataMigrator.Models
{
    public class Player_Attribute
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public int FifaApiId { get; set; }
        public int ApiId { get; set; }
        public DateTime Date { get; set; }
        public long? OverallRating { get; set; }
        public virtual Player Player { get; set; } 
    }
}
