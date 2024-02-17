using FootsalTeamManage.Service.Teams.Contract;
using FootsalTeamManage.Service.Teams.Contract.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace FootsalTeamManage.RestApi.Controllers
{
    [Route("api/Teams")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly TeamService _service;

        public TeamsController(TeamService service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task Add([FromBody]AddTeamDto dto)
        {
            await _service.AddTeam(dto);
        }
        [HttpDelete("{id}")]
        public void Delete([FromRoute] int id)
        {
            _service.DeleteTeam(id);
        }
        [HttpGet]
        public List<GetAllTeamDto> GetAll()
        {
            return _service.GetAllTeams();
        }
        [HttpPatch]
        public void Update(UpdateTeamDto dto)
        {
            _service.UpdateTeam(dto);
        }


    }
}
