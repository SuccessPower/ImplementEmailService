using AspNetCoreHero.Results;
using ExamRoomV2Client.DataAccess.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamRoomV2Client.DataAccess.IService
{
    public  interface IAuthenticationuser
    {
        Task <Result<string>>Register(RegisterUserDto userDto,string role);
    }
}
