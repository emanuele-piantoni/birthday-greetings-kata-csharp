using System;
using System.Collections.Generic;
using BirthdayGreetings;

public interface IEmployeeRepository 
{
    IEnumerable<Employee> Get(Func<Employee, bool> func);
}