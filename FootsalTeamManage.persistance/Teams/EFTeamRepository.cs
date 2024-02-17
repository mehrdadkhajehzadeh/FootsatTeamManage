using FootsalTeamManage.Entity;
using FootsalTeamManage.Service.Teams.Contract;

namespace FootsalTeamManage.persistance.Teams
{
    public class EFTeamRepository : TeamRepository
    {
        private readonly EFDataContext _context;

        public EFTeamRepository(EFDataContext context)
        {
            _context = context;
        }

        public void AddTeam(Team team)
        {
            
            _context.teams.Add(team);
        }

        public void DeleteTeam(Team team)
        {
            _context.teams.Remove(team);
        }

        public List<Team> GetAllTeams()
        {
            return _context.teams.ToList();
        }

        public Team GetId(int id)
        {
            return _context.teams.FirstOrDefault(_ => _.Id == id);
        }

        public bool IsCheckName(string teamName)
        {
            return _context.teams.Any(_ => _.TeamName == teamName);
        }

        public void UpdateTeam(Team team)
        {
             if(team.Id != _context.teams.First().Id)
            {
                if (team.TeamName == _context.teams.First().TeamName)
                {
                    throw new Exception("Pleas choos another name");
                }
                _context.Add(team);
            }
        }
    }
}
