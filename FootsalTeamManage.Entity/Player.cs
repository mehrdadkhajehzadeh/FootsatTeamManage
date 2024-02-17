namespace FootsalTeamManage.Entity
{
    public class Player
    {
        public int Id { get; set; }
        public string PlayerName { get; set; }
        public DateTime Age { get; set; }
        public PlayerRole playerRole { get; set; }
    }
    public enum PlayerRole
    {
        GoalKepper = 1,
        Defense, 
        Midfielder,
        Aggressive

    }
}
