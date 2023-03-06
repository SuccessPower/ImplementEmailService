using System.ComponentModel.DataAnnotations;

namespace ExamRoomV2Client.DataAccess.Models.Dto
{
    public class RegisterUserDto
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        public DateTime Created_Date { get; set; } = DateTime.Now;
        public string Group { get; set; }
        public string Status { get; set; }

        [RegularExpression(@"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$", ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
