using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ExamRoomV2Demo.ClientAPI.Models.Authentication.SignUp
{
    public class RegisterUser : IdentityUser
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        public string Password { get; set; }
        public DateTime Created_Date { get; set; } = DateTime.Now;  
        public string Group { get; set; }
        public string Status { get; set; }
        [EmailAddress]
        public string Email { get; set; }

    }
}
