namespace FantasyFun.DAL.Models
{
    public class Country
    {
        public Country()
        {
            Leagues = new HashSet<League>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<League> Leagues { get; set; }
    }
}
