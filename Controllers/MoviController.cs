using eimdbapi.Models;
using eimdbapi.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eimdbapi.Controllers
{
    public class MoviController : Controller
    {

        private Movi createdMovi;
        private NewMoviViewModel newMoviViewModel;
        // GET: Movi
        [Route("movi/index/{moviID}")]
        public ActionResult Index(int moviID)
        {
            var model = createNewMovi(moviID);
            return View(model);
        }

       
        public Movi createNewMovi(int moviID) {
            Movi newMovi = new Movi();
            newMovi.Requester = new Employee();
            newMovi.Requester.Name = "Leonardo";
            newMovi.Requester.Job = "Desenvolvedor";
            newMovi.Obra = "Sede";
            newMovi.MoviID = moviID;
            newMovi.MaterialsList = new List<Material>();
            return newMovi;
        }
    }
}