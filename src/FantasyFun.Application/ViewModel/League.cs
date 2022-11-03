namespace FantasyFun.Application.ViewModel
{
    public class League
    {
        public long Id { get; }
        public string Name { get; }

        public League(long id, string name)
        {
            Id= id;
            Name= name;
        }
    }
}
