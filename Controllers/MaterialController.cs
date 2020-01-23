using eimdbapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eimdbapi.Controllers
{
    public class MaterialController : Controller
    {
        private ApplicationDbContext _context;

        public MaterialController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Material/
        [Route("material/home")]
        public ActionResult MaterialHome()
        {
            var employees = _context.Employees.ToList();
            var materials = _context.Materials.ToList();

            Employee emp1 = employees[1];
            Movi movi1 = new Movi(materials, emp1);
            return View(movi1);
        }

        [Route("material/new")]
        public ActionResult New()
        {
            return View();
        }
        [Route("material/list")]
        public ActionResult List()
        {
            var materialList = _context.Materials.ToList();
            return View(materialList);
        }

        [HttpPost]
        public ActionResult Create(Material material) {
            _context.Materials.Add(material);
            _context.SaveChanges();

            return RedirectToAction("List", "Material");
        }

    }
}