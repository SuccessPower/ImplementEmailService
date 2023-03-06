using AspNetCoreHero.Results;
using AutoMapper;
using ExamRoomV2Client.DataAccess.IService;
using ExamRoomV2Client.DataAccess.Models.Dto;
using ExamRoomV2Demo.ClientAPI.Models.Authentication.SignUp;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ExamRoomV2Client.DataAccess.Implementation
{
    public class AuthenticateUser : IAuthenticationuser
    {
        private readonly UserManager<RegisterUser> _userManager;
        private readonly IMapper _mapper;
        private readonly RoleManager<IdentityRole> _roleManager;
        //private RegisterUser _user;

        public AuthenticateUser(UserManager<RegisterUser> userManager, IMapper mapper,
            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _mapper = mapper;
            _roleManager = roleManager;


        }


        //public async Task<Response> Register(RegisterUserDto registerUserDto)
        //{
        //    _user = _mapper.Map<RegisterUser>(registerUserDto);
        //    _user.UserName = registerUserDto.Email;

        //    var result = await _userManager.CreateAsync(_user, _user.Password);
        //    var resp = new Response();
        //    if (result.Succeeded)
        //    {
        //        resp.Message = "Succefully registered";
        //        resp.Status ="200";
        //        return resp;
        //    }
        //    resp.Message = "Failed to registered";
        //    resp.Status = "400";
        //    return resp;
        //}
        public async Task<Result<string>> Register(RegisterUserDto userDto, string role)
        {
            // check if the user with the specified email already exist in the system
            try
            {
                var checkUser = await _userManager.FindByEmailAsync(userDto.Email);
                if (checkUser is not null)
                {
                    return await Result<string>.FailAsync("user already exist");
                }

                var newUser = _mapper.Map<RegisterUser>(userDto);

                var roles = await _roleManager.Roles.ToListAsync();
                // if there is no roles, it create with the name "user"
                if (roles.Count == 0)
                {
                    await _roleManager.CreateAsync(new IdentityRole { Name = role });
                }
                // create a new user to the system
                var result = await _userManager.CreateAsync(newUser, userDto.Password);
                if (!result.Succeeded)
                {
                    return await Result<string>.FailAsync("user could not be created, an error occur");
                }
                // if user is created sucessful , add the new user to the user role
                await _userManager.AddToRoleAsync(newUser, "User");
                return new Result<string>
                {
                    Succeeded = true,
                    Data = "Good",
                    Message = "Registration Sucessful"

                };
            }
            catch (Exception ex)
            {

                return await Result<string>.FailAsync("User could not be created, an error occured");
            }
        }
    }

}
