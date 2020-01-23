using eimdbapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace eimdbapi.Controllers.API
{
    public class MovisController : ApiController
    {
        private List<Movi> moviList;
        
        private ApplicationDbContext _context;

        public MovisController()
        {
            _context = new ApplicationDbContext();
            
        }

        [Route("api/movi/{id}")]
        public Movi GetMovi(int id) {
            populateMoviList();
            return moviList[id];

        }
        public void populateMoviList() {
            var materials = _context.Materials.ToList();
            var employees = _context.Employees.ToList();
            var employee = employees[2];
            var movi1 = new Movi();
            movi1.MaterialsList = materials;
            movi1.Requester = employee;
            movi1.MoviID = 1;
            movi1.Obra = "Brilux";
            var movi2 = new Movi();
            movi2.MaterialsList = materials;
            movi2.Requester = employees[0];
            movi2.MoviID = 2;
            movi2.Obra = "Aeris";
            moviList = new List<Movi>();
            moviList.Add(movi1);
            moviList.Add(movi2);
        }

    }
}
