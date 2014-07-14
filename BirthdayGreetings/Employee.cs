using System;

namespace BirthdayGreetings
{
	public class Employee
	{
		private XDate birthDate;
		private String lastName;
		private String firstName;
		private String email;

		public Employee (String firstName, String lastName, String birthDate, String email) 
		{
			this.firstName = firstName;
			this.lastName = lastName;
			this.birthDate = new XDate(birthDate);
			this.email = email;
		}

		public bool isBirthday(XDate today) {
			return today.isSameDay(birthDate);
		}

		public String getEmail() {
			return email;
		}

		public String getFirstName() {
			return firstName;
		}

	}
}

