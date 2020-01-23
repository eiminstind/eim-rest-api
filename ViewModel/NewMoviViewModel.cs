using eimdbapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eimdbapi.ViewModel
{
    public class NewMoviViewModel
    {
        public string RequesterName { get; set; }
        public string RequesterJob { get; set; }
        public List<Material> materialsInMovi { get; set; }

    }   
}