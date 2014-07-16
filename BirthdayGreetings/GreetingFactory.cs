namespace BirthdayGreetings
{
    public class GreetingFactory : IGreetingFactory
    {
        public Greeting Create(Employee employee, string subjectTemplate, string bodyTemplate, string from)
        {
            return new Greeting { 
                Body = bodyTemplate.Replace("%NAME%", 
                employee.getFirstName()), 
                Recipient = employee.getEmail(), 
                Subject = subjectTemplate, 
                From = from};
        }
    }
}