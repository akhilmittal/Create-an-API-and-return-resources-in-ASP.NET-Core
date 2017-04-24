using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeInfo.API.Models
{
  public class EmployeeDto
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Designation { get; set; }
    public string Salary { get; set; }

    public int NumberOfCompaniesWorkedWith { get; set; }

  }
}
