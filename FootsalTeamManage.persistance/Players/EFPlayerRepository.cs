using FootsalTeamManage.Entity;
using FootsalTeamManage.Service.Players.Contract;

namespace FootsalTeamManage.persistance.Players
{
    public class EFPlayerRepository : PlayerRepository
    {
        private readonly EFDataContext _context;

        public EFPlayerRepository(EFDataContext context)
        {
            _context = context;
        }

        public void AddPlayer(Player player)
        {
            _context.players.Add(player);
        }

        public void DeletePlayer(Player player)
        {
            _context.players.Remove(player);
        }

        public List<Player> GetAllPlayer()
        {
            return _context.players.ToList();
        }

        public Player GetId(int id)
        {
            return _context.players.FirstOrDefault(_ => _.Id == id);
        }

        public bool IsCheckName(string playerName)
        {
            return _context.players.Any(_ => _.PlayerName == playerName);
        }

        public void UpdatePlayer(Player player)
        {
            _context.Add(player);
        }
    }
}
