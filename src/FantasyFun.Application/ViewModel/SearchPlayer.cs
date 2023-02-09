namespace FantasyFun.Application.ViewModel
{
    public class SearchPlayer
    {
        public SearchPlayer(string name, long overall)
        {
            Name = name;
            Overall = overall;
        }

        public string Name { get; }
        public long Overall { get; }
    }
}
