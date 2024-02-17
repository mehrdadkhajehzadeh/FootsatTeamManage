using FootsalTeamManage.Entity;

namespace FootsalTeamManage.Service.Teams.Contract
{
    public interface TeamRepository
    {
        public void AddTeam(Team team);
        public void UpdateTeam(Team team);
        public void DeleteTeam(Team team);
        public List<Team> GetAllTeams();
        public Team GetId(int id);
        bool IsCheckName(string teamName);
    }
}
