using EmailService;
using EmailService.Interface;
using ExamRoomV2Client.DataAccess.Models.Dto;
using ExamRoomV2Demo.ClientAPI.Models.Authentication.SignUp;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NETCore.MailKit.Core;

namespace ExamRoomV2Demo.ClientAPI.Controllers
{
    public class EmailController : Controller
    {
        private readonly IEmailSender _emailSender;
        private readonly UserManager<RegisterUser> _userManager;

        public EmailController(IEmailSender emailSender, UserManager<RegisterUser> userManager)
        {
            _emailSender = emailSender;
            _userManager = userManager;
        }

        [HttpPost("send-alert-email")]
        public IActionResult SendAlertEmail(string recipientEmail)
        {
            var message = new Message(new string[] { recipientEmail }, $"Reminder to start test", $"Dear {recipientEmail} This is to remind you that you are yet to start your exam. Kindly login and start your exam. If you are experiencing any challenges or delays, Please inform us immediately.");
            _emailSender.SendEmail(message);
            return Ok("Email Sent Successfully!");
        }

        [HttpPost("send-alert-email/{userId}")]
        public async Task<IActionResult> SendAlertEmailId(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound("User not found");
            }

            var recipientEmail = user.Email;

            var message = new Message(new string[] { recipientEmail }, $"Reminder to start test", $"Dear {user.Name} This is to remind you that you are yet to start your exam. Kindly login and start your exam. If you are experiencing any challenges or delays, Please inform us immediately.");
            _emailSender.SendEmail(message);
            return Ok("Email Sent Successfully!");
        }


    }
}
