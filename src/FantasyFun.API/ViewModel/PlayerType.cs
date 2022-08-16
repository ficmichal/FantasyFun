namespace FantasyFun.API.ViewModel
{
    public class PlayerType
    {
        public string Name { get; }
        public long OverallRating { get;}

        public PlayerType(string name, long overallRating)
        {
            Name = name;
            OverallRating = overallRating;
        }
    }
}
