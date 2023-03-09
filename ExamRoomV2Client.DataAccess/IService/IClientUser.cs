using Microsoft.AspNetCore.Identity;
using Org.BouncyCastle.Bcpg;
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
        //Task<IdentityUser> GetUserAsync(string Id);
    }
}
