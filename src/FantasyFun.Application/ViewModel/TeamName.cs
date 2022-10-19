namespace FantasyFun.Application.ViewModel
{
    public class TeamName
    {
        public string LongName { get; }
        public string ShortName { get; }
        public string CommonName { get; }

        public TeamName(string longName, string shortName, string commonName)
        {
            LongName = longName;
            ShortName = shortName;
            CommonName = commonName;
        }
    }
}
