namespace FantasyFun.API.ViewModel
{
    public class PlayerType
    {
        public string Name { get; }
        public long OverallRating { get;}
        public DateTime Date { get; }

        public PlayerType(string name, long overallRating, DateTime date)
        {
            Name = name;
            OverallRating = overallRating;
            Date = date;
        }
    }
}
