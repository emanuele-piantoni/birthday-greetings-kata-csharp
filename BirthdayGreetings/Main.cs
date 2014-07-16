using System.IO;

namespace BirthdayGreetings
{
	class MainClass
	{
		public static void Main (string[] args)
		{
		    var fileService = new FileService("../../employee_data.txt");
		    var repository = new EmployeeRepository(fileService);
		    var emailSender = new EmailSender("localhost", 25);
		    var greetingFactory = new GreetingFactory();
		    var greetingSender = new GreetingSender(emailSender, greetingFactory);
		    var service = new BirthdayService(repository, greetingSender);
			service.SendGreetings(new XDate());
		}
	}
}
