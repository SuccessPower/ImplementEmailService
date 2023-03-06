using ExamRoomV2Demo.ClientAPI.Models.Authentication.SignUp;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ExamRoomV2Demo.ClientAPI.Models;
using ExamRoomV2Client.DataAccess.Models.Dto;
using ExamRoomV2Client.DataAccess.IService;
using AutoMapper;

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




            ////Check if user exists
            //var userExist = await _userManager.FindByEmailAsync(register.Email);
            //if (userExist != null)
            //{
            //    return StatusCode(StatusCodes.Status403Forbidden,
            //    new Response { Status = "Error", Message = "User already exists!" });
            //}

            ////Add the user in the database
            //RegisterUser user = new()
            //{
            //    Name = register.Name,
            //    Email = register.Email,
            //    Created_Date = register.Created_Date,
            //    Group = register.Group,
            //    Status = register.Status

            //};

            //var result = await _userManager.CreateAsync(user, register.Password);
            //return result.Succeeded
            //    ? StatusCode(StatusCodes.Status201Created,
            //        new Response { Status = "Success", Message = "User Created Successfully!" })
            //    : (IActionResult)StatusCode(StatusCodes.Status500InternalServerError,
            //        new Response { Status = "Error", Message = "User Failed to Create" });
            ////Assign role

        }
    

    }
}
