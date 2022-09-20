namespace FantasyFun.Application.ViewModel
{
    public class PlayerType
    {
        public string Name { get; }
        public long OverallRating { get;}

        public PlayerType(string name, long overallRating, DateTime date)
        {
            Name = name;
            OverallRating = overallRating;
        }

        public PlayerType(string name, long overallRating)
        {
            Name = name;
            OverallRating = overallRating;
        }
    }
}
