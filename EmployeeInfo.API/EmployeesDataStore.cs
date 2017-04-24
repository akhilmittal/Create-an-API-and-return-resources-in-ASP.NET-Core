using EmployeeInfo.API.Models;
using System.Collections.Generic;

namespace EmployeeInfo.API
{
  public class EmployeesDataStore
    {
    public static EmployeesDataStore Current { get; } = new EmployeesDataStore();
    public List<EmployeeDto> Employees { get; set; }

    public EmployeesDataStore()
    {
      //Dummy data
      Employees = new List<EmployeeDto>()
            {
                new EmployeeDto()
                {
                     Id = 1,
                     Name = "Akhil Mittal",
                     Designation = "Technical Manager",
                     Salary="$50000"
                },
                new EmployeeDto()
                {
                     Id = 2,
                     Name = "Keanu Reaves",
                     Designation = "Developer",
                     Salary="$20000"
                },
                 new EmployeeDto()
                {
                     Id = 3,
                     Name = "John Travolta",
                     Designation = "Senior Architect",
                     Salary="$70000"
                },
                  new EmployeeDto()
                {
                     Id = 4,
                     Name = "Brad Pitt",
                     Designation = "Program Manager",
                     Salary="$80000"
                },
                   new EmployeeDto()
                {
                     Id = 5,
                     Name = "Jason Statham",
                     Designation = "Delivery Head",
                     Salary="$90000"
                }
            };

    }
  }
}
