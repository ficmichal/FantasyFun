using System.ComponentModel.DataAnnotations.Schema;

namespace FantasyFun.DataMigrator.Models
{
    public class League
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public long CountryId { get; set; }

        public string Name { get; set; }

        public virtual Country? Country { get; set; }
    }
}
