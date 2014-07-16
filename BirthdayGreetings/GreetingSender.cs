using System.Collections.Generic;
using System.Net.Mail;

namespace BirthdayGreetings
{
    public class GreetingSender : IGreetingSender
    {
        private readonly IEmailSender _emailSender;
        private readonly IGreetingFactory _greetingFactory;

        public GreetingSender(IEmailSender emailSender, IGreetingFactory greetingFactory)
        {
            _emailSender = emailSender;
            _greetingFactory = greetingFactory;
        }

        public void SendGreetings(IEnumerable<Employee> employees)
        {
            foreach (var employee in employees)
            {
                var bodyTemplate = "Happy Birthday, dear %NAME%!";
                var subjectTemplate = "Happy Birthday!";
                var from = "sender@here.com";

                var greeting = _greetingFactory.Create(employee, subjectTemplate, bodyTemplate, from);
                _emailSender.Send(greeting);
            }
        }

        
    }
}