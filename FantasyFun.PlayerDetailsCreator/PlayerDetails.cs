namespace FantasyFun.PlayerDetailsCreator
{
    public class PlayerDetails
    {
        public int Id { get; set; }

        public List<PlayerDetailsBySeason> PlayerDetailsBySeason { get; set; } = new List<PlayerDetailsBySeason>();
    } 

    public class PlayerDetailsBySeason
    {
        public int Season { get; set; }
        public long Overall { get; set; }
    }
}
