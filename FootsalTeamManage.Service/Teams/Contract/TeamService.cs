using FootsalTeamManage.Service.Teams.Contract.Dtos;

namespace FootsalTeamManage.Service.Teams.Contract
{
    public interface TeamService
    {
       public Task AddTeam(AddTeamDto dto);
       public Task UpdateTeam(UpdateTeamDto dto);
       public Task DeleteTeam(int id);
       public List<GetAllTeamDto> GetAllTeams();
    }
}
