using System.Collections.Generic;

namespace BirthdayGreetings
{
    public interface IGreetingFactory
    {
        Greeting Create(Employee employee, string subjectTemplate, string bodyTemplate, string from);
    }
}