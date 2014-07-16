using System.Net.Mail;

namespace BirthdayGreetings
{
    public class EmailSender : IEmailSender
    {
        private readonly string _smtpHost;
        private readonly int _smtpPort;

        public EmailSender(string smtpHost, int smtpPort)
        {
            _smtpHost = smtpHost;
            _smtpPort = smtpPort;
        }

        public void Send(Greeting greeting)
        {
            var client = new SmtpClient(_smtpHost, _smtpPort);
            var message = new MailMessage(greeting.From, greeting.Recipient, greeting.Subject, greeting.Body);
            client.Send(message);
            client.Dispose();
        
        }
    }
}