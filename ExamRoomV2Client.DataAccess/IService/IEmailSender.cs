namespace EmailService.Interface
{
    public interface IEmailSender
    {
        void SendEmail(Message message);
    }
}
