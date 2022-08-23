using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EMployeeService.Controllers
{
    public class EmployeesController : ApiController
    {

        [Authorize]
        public IEnumerable<Employee> Get()
        {
            using(EmployeeDBEntities employeeDBEntities = new EmployeeDBEntities())
            {
                return employeeDBEntities.Employees.ToList();
            }
        }
    }
}
