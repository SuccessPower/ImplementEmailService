using ExamRoomV2Client.DataAccess.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;

namespace ExamRoomV2Demo.ClientAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientUserController : ControllerBase
    {
        private readonly IClientUser _clientUser;

        public ClientUserController(IClientUser clientUser)
        {
            _clientUser = clientUser;
        }

        [HttpGet("GetRoles")]
        public async Task<ActionResult<List<IdentityRole>>> GetRolesAsync()
        {
            var roles = await _clientUser.GetAllRolesAsync();
            //var records = _mapper.Map<List<GetCountryDto>>(countries);
            return Ok(roles);
        }

        //[HttpGet("Id")]
        //public async Task<ActionResult<IdentityUser>> GetUser(string Id)
        //{
        //    var user = await _clientUser.GetUserAsync(Id);

        //    //if (user == null)
        //    //{
        //    //    return BadRequest();
        //    //}

        //    ////var countryDto = _mapper.Map<CountryDto>(country);

        //    return Ok(user);
        //}
    }
}
