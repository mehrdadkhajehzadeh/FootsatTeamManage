using FootsalTeamManage.Entity;
using FootsalTeamManage.Service.Teams.Contract;
using FootsalTeamManage.Service.Teams.Contract.Dtos;

namespace FootsalTeamManage.Service.Teams
{
    public class TeamAppService : TeamService
    {
        private readonly TeamRepository _repository;
        private readonly UnitOfWork _unit;

        public TeamAppService(TeamRepository repository, UnitOfWork unit)
        {
            _repository = repository;
            _unit = unit;
        }

        public async Task AddTeam(AddTeamDto dto)
        {
            if (_repository.IsCheckName(dto.TeamName))
            {
                throw new Exception("duplicate name ");
            }
            if(dto.FirstClotheColor == dto.SecondClotheColor)
            {
                throw new Exception("pleas choos difrent colore");
            }
            var team = new Team()
            {
                
                TeamName = dto.TeamName,
                FirstClotheColor = dto.FirstClotheColor,
                SecondClotheColor = dto.SecondClotheColor,  
            };
            _repository.AddTeam(team);
            await _unit.Complete();

        }

        public async Task DeleteTeam(int id)
        {
            var team = _repository.GetId(id);
            if (team == null)
            {
                throw new Exception("team not found");
            }
            _repository.DeleteTeam(team);
        }

        public List<GetAllTeamDto> GetAllTeams()
        {
            var teams = _repository.GetAllTeams();
            var teamlist = new List<GetAllTeamDto>();
            foreach(var item in teams)
            {
                var team = new GetAllTeamDto()
                {
                    TeamName=item.TeamName,
                    FirstClotheColor=item.FirstClotheColor,
                    SecondClotheColor=item.SecondClotheColor,
                };
                teamlist.Add(team);
            }
            return teamlist;
        }


        public async Task UpdateTeam(UpdateTeamDto dto)
        {
            if (_repository.IsCheckName(dto.TeamName))
            {
                throw new Exception("duplicate name ");
            }

            var team = new Team()
            {

                TeamName = dto.TeamName,
                FirstClotheColor = dto.FirstClotheColor,
                SecondClotheColor = dto.SecondClotheColor,
            };
            _repository.AddTeam(team);
            await _unit.Complete();
        }
    }
}
