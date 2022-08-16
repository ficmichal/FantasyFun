namespace FantasyFun.API.ViewModel
{
    public class TeamName
    {
        public string LongName { get; }
        public string ShortName { get; }
        public long Overall { get; }

        public TeamName(string longName, string shortName)
        {
            LongName = longName;
            ShortName = shortName;
        }

        public TeamName(string LongName, long overall)
        {
            LongName = LongName;
            Overall = overall;
        }
    }
}
