namespace FantasyFun.DAL.Models
{
    public class Player
    {
        Player()
        {
            PlayerAttributes = new HashSet<Player_Attribute>();
        }

        public int Id { get; set; }
        public int ApiId { get; set; }
        public string Name { get; set; }
        public int FifaApiId { get; set; }
        public  DateTime Birthday { get; set; }

        public virtual ICollection<Player_Attribute> PlayerAttributes { get; set; }
    }
}
