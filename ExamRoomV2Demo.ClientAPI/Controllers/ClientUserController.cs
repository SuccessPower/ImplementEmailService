using ExamRoomV2Client.DataAccess.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ExamRoomV2Demo.ClientAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientUserController : ControllerBase
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IClientUser _clientUser;

        public ClientUserController(RoleManager<IdentityRole> roleManager, IClientUser clientUser)
        {
            _roleManager = roleManager;
            _clientUser = clientUser;
        }

        [HttpGet("GetRoles")]
        public async Task<ActionResult<List<IdentityRole>>> GetRolesAsync()
        {
            var roles = await _clientUser.GetAllRolesAsync();
            //var records = _mapper.Map<List<GetCountryDto>>(countries);
            return Ok(roles);
        }
    }
}
