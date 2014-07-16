namespace BirthdayGreetings
{
    public class BirthdayService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IGreetingSender _greetingSender;

        public BirthdayService(IEmployeeRepository employeeRepository, IGreetingSender greetingSender)
        {
            _employeeRepository = employeeRepository;
            _greetingSender = greetingSender;
        }

        public void SendGreetings(XDate date)
        {
            var employees = _employeeRepository.Get(e => e.isBirthday(date));
            _greetingSender.SendGreetings(employees);
        }
    }
}

