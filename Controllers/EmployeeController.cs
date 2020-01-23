using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eimdbapi.Models;

namespace eimdbapi.Controllers
{
    public class EmployeeController : Controller
    {
        private ApplicationDbContext _context;

        public EmployeeController() {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Employees
        [Route("employee/employeeindex")]
        public ActionResult EmployeeIndex()
        {
            List<Employee> employees = _context.Employees.ToList();
            //Employee emp = employees[0];
            return View(employees);
        }

        [Route("employee/new")]
        public ActionResult New(){

            return View();
        }
    }
}