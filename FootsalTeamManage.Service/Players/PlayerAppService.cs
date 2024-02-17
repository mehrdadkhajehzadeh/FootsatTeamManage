using FootsalTeamManage.Entity;
using FootsalTeamManage.Service.Players.Contract;
using FootsalTeamManage.Service.Players.Contract.Dtos;

namespace FootsalTeamManage.Service.Players
{
    public class PlayerAppService : PlayerService
    {
        private readonly PlayerRepository _repository;
        private readonly UnitOfWork _unit;

        public PlayerAppService(PlayerRepository repository, UnitOfWork unit)
        {
            _repository = repository;
            _unit = unit;
        }

        public async Task AddPlayer(AddPlayerDto dto)
        {
            if (_repository.IsCheckName(dto.PlayerName))
            {
                throw new Exception("duplicate name ");
            }

            var player = new Player()
            {
                PlayerName = dto.PlayerName,
                Age = dto.Age,
                playerRole = dto.playerRole
            };
            _repository.AddPlayer(player);
            await _unit.Complete();
        }

        public async Task DeletePlayer(int id)
        {
            var player = _repository.GetId(id);
            if (player == null)
            {
                throw new Exception("team not found");
            }
            _repository.DeletePlayer(player);
        }

        public List<GetAllPlayerDto> GetAllPlayers()
        {
            var players = _repository.GetAllPlayer();
            var playerlist = new List<GetAllPlayerDto>();
            foreach (var item in players)
            {
                var player = new GetAllPlayerDto()
                {
                   playerRole = item.playerRole,
                   PlayerName = item.PlayerName,
                   Age = item.Age,
                };
                playerlist.Add(player);
            }
            return playerlist;
        }

        public async Task UpdatePlayer(UpdatePlayerDto dto)
        {
            var player = new Player()
            {
                PlayerName = dto.PlayerName,
                Age = dto.Age,
                playerRole = dto.playerRole

            };
            _repository.AddPlayer(player);
            await _unit.Complete();
        }
    }
}
