using System.ComponentModel.DataAnnotations.Schema;

namespace FantasyFun.DataMigrator.Models
{
    public class Team
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }
        public long? FifaApiId { get; set; } 
        public long ApiId { get; set; }
        public string LongName { get; set; }    
        public string ShortName { get; set; }
    }
}
