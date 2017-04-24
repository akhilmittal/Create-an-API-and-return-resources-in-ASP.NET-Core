using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeInfo.API.Controllers
{
  [Route("api/employees")]
  public class EmployeesInfoController : Controller
  {
    [HttpGet()]
    public JsonResult GetEmployees()
    {
      return new JsonResult(EmployeesDataStore.Current.Employees);
    }

    [HttpGet("{id}")]
    public JsonResult GetEmployee(int id)
    {
      return new JsonResult(EmployeesDataStore.Current.Employees.FirstOrDefault(emp => emp.Id == id));
    }
  }
}
