using eimdbapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace eimdbapi.Controllers.API
{
    public class EmployeesController : ApiController
    {
        private ApplicationDbContext _context;

        public EmployeesController(){
            _context = new ApplicationDbContext();
        }
        
        // Get api/employees
        [Route("api/employees")]
        public IEnumerable<Employee> GetEmployees()
        {
            return _context.Employees.ToList();
        }

    }
}
