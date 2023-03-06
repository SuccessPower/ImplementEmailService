using EmailService;
using EmailService.Interface;
using Microsoft.AspNetCore.Mvc;
using NETCore.MailKit.Core;

namespace ExamRoomV2Demo.ClientAPI.Controllers
{
    public class EmailController : Controller
    {
        private readonly IEmailSender _emailSender;

        public EmailController(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        [HttpPost("send-alert-email")]
        public IActionResult SendAlertEmail(string recipientEmail)
        {
            var message = new Message(new string[] { recipientEmail }, $"Reminder to start test", $"Dear {recipientEmail} This is to remind you that you are yet to start your exam. Kindly login and start your exam. If you are experiencing any challenges or delays, Please inform us immediately.");
            _emailSender.SendEmail(message);
            return Ok();
        }

    }
}
