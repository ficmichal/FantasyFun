namespace FantasyFun.PlayerDetailsCreator
{
    public class Season
    {
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public Season(int id, DateTime start, DateTime end)
        {
            Id = id;
            Start = start;
            End = end;
        }

        public bool IsIn(DateTime time)
        {
            return Start <= time && End > time;
        }
    }
}
