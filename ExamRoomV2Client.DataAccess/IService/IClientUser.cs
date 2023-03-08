using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamRoomV2Client.DataAccess.IService
{
    public interface IClientUser
    {
        Task<List<IdentityRole>> GetAllRolesAsync();
    }
}
