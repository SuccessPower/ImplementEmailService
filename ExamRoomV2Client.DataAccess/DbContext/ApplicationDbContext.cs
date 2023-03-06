using ExamRoomV2Demo.ClientAPI.Models.Authentication.SignUp;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamRoomV2Client.DataAccess.DbContext
{
    public class ApplicationDbContext : IdentityDbContext<RegisterUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedRoles(builder);
        }

        private static void SeedRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData
                (
                    new IdentityRole() { Name = "Admin", ConcurrencyStamp = "1", NormalizedName = "Admin" },
                    new IdentityRole() { Name = "User", ConcurrencyStamp = "2", NormalizedName = "User" },
                    new IdentityRole() { Name = "HR", ConcurrencyStamp = "3", NormalizedName = "HR" },
                    new IdentityRole() { Name = "Subject Head", ConcurrencyStamp = "4", NormalizedName = "Subject Head" },
                    new IdentityRole() { Name = "Faculty Head", ConcurrencyStamp = "5", NormalizedName = "Faculty Head" },
                    new IdentityRole() { Name = "Invigilator", ConcurrencyStamp = "6", NormalizedName = "Invigilator" },
                    new IdentityRole() { Name = "Professor", ConcurrencyStamp = "7", NormalizedName = "Professor" }
                );
        }
    }
}
