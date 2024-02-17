using FootsalTeamManage.Entity;

namespace FootsalTeamManage.Service.Players.Contract
{
    public interface PlayerRepository
    {
        public void AddPlayer(Player player);
        public void UpdatePlayer(Player player);
        public void DeletePlayer(Player player);
        public List<Player> GetAllPlayer();
        public Player GetId(int id);
        bool IsCheckName(string playerName);
    }
}
