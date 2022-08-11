namespace FantasyFun.API.Models
{
    public class Team
    {
        public long Id { get; set; }
        public long FifaApiId { get; set; } 
        public long ApiId { get; set; }
        public string LongName { get; set; }    
        public string ShortName { get; set; }
    }
}
