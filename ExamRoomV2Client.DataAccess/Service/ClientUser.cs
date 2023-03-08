using ExamRoomV2Client.DataAccess.IService;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamRoomV2Client.DataAccess.Service
{
    public class ClientUser : IClientUser
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        public ClientUser(RoleManager<IdentityRole> roleManager)
        {

            _roleManager = roleManager;

        }
        public async Task<List<IdentityRole>> GetAllRolesAsync()
        {
            //var siteRoles = await _roleManager.Roles.Select(x => x.Name).ToListAsync();
            return await _roleManager.Roles.ToListAsync();
        }
    }
}
