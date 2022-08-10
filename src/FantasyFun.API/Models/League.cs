namespace FantasyFun.API.Models
{
    public class League
    {
        public long Id { get; set; }

        public long CountryId { get; set; }

        public string Name { get; set; }

        public virtual Country? Country { get; set; }
    }
}
