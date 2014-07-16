using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayGreetings
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IFileService _fileService;

        public EmployeeRepository( IFileService fileService)
        {
            _fileService = fileService;
        }

        public IEnumerable<Employee> Get(Func<Employee, bool> func)
        {
            var result = new List<Employee>();

            var lines = _fileService.GetLines();

            foreach (var line in lines)
            {
                var employeeData = line.Split(new[] { ',' }, 1000);
                result.Add(new Employee(employeeData[1].Trim(), employeeData[0].Trim(), employeeData[2].Trim(), employeeData[3].Trim()));
            }

            return result.Where(func);
        }
    }
}