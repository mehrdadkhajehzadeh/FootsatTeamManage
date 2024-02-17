using FootsalTeamManage.Entity;

namespace FootsalTeamManage.Service.Players.Contract.Dtos
{
    public class GetAllPlayerDto
    {
        public int Id { get; set; }
        public string PlayerName { get; set; }
        public DateTime Age { get; set; }
        public PlayerRole playerRole { get; set; }
    }
}