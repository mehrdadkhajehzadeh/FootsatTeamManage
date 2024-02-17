using FootsalTeamManage.Service.Players.Contract.Dtos;

namespace FootsalTeamManage.Service.Players.Contract
{
    public interface PlayerService
    {
        public Task AddPlayer(AddPlayerDto dto);
        public Task UpdatePlayer(UpdatePlayerDto dto);
        public Task DeletePlayer(int id);
        public List<GetAllPlayerDto> GetAllPlayers();
    }
}
