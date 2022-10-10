using System.ComponentModel.DataAnnotations.Schema;

namespace FantasyFun.DataMigrator.Models
{
    public class Country
    {
        public Country()
        {
            Leagues = new HashSet<League>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<League> Leagues { get; set; }
    }
}
