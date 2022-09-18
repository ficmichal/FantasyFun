namespace FantasyFun.API.Models
{
    public class Player_Attribute
    {
        public int Id { get; set; }
        public int FifaApiId { get; set; }
        public int ApiId { get; set; }
        public DateTime Date { get; set; }
        public long OverallRating { get; set; }
        public virtual Player Player { get; set; } 
    }
}
