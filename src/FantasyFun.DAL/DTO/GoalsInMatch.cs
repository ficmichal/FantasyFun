namespace FantasyFun.DAL.DTO
{
    public class GoalsInMatch
    {
        public List<GoalInMatch> WhoScored { get; set; } = new List<GoalInMatch>();
    }

    public class GoalInMatch
    {
        public int PlayerId { get; set; }
        public int NumberOfGoals { get; set; }
    }
}
