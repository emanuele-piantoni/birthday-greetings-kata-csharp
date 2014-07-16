using System.Collections.Generic;

namespace BirthdayGreetings
{
    public interface IGreetingSender
    {
        void SendGreetings(IEnumerable<Employee> employees);
    }
}