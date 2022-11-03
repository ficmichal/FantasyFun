namespace FantasyFun.DAL.ViewModel
{
    public class TeamName
    {
        public string LongName { get; }
        public string ShortName { get; }

        public TeamName(string longName, string shortName)
        {
            LongName = longName;
            ShortName = shortName;
        }
    }
}
