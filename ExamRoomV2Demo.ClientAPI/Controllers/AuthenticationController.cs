using AutoMapper;
using ExamRoomV2Client.DataAccess.IService;
using ExamRoomV2Client.DataAccess.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace ExamRoomV2Demo.ClientAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {

        private readonly IAuthenticationuser _authentication;
        private IMapper _mapper;
        public AuthenticationController(IAuthenticationuser authentication,IMapper mapper)
        {
            _authentication = authentication;
            _mapper = mapper;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterUserDto user,string role )
        {
            //var newUser = _mapper.Map<RegisterUserDto>(user);
            var response = await _authentication.Register(user, role);
            if (response.Succeeded)
            {
                return Ok(response);
            }
            return BadRequest(response);

        }
    

    }
}
