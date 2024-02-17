using FootsalTeamManage.Service.Players.Contract;
using FootsalTeamManage.Service.Players.Contract.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace FootsalTeamManage.RestApi.Controllers
{
    [Route("api/Players")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly PlayerService _service;

        public PlayersController(PlayerService service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task Add([FromBody] AddPlayerDto dto)
        {
            await _service.AddPlayer(dto);
        }
        [HttpDelete("{id}")]
        public void Delete([FromRoute] int id)
        {
            _service.DeletePlayer(id);
        }
        [HttpGet]
        public List<GetAllPlayerDto> GetAll()
        {
            return _service.GetAllPlayers();
        }
        [HttpPatch]
        public void Update(UpdatePlayerDto dto)
        {
            _service.UpdatePlayer(dto);
        }
    }
}
