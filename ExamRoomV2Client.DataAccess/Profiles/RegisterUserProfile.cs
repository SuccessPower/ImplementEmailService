using AutoMapper;
using ExamRoomV2Client.DataAccess.Models.Dto;
using ExamRoomV2Demo.ClientAPI.Models.Authentication.SignUp;

namespace ExamRoomV2Client.DataAccess.Profiles
{
    public class RegisterUserProfile : Profile
    {
        public RegisterUserProfile()
        {
            CreateMap<RegisterUser,RegisterUserDto>().ReverseMap();
                
        }
    }
}
