using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eimdbapi.Models
{
    public class Material{

        public int Id { get; set; }
        [Display(Name = "Unidade")]
        public string unit { get; set; }
        [Display(Name = "Descrição")]
        public string  name { get; set; }
        [Display(Name = "Cód. GIT")]
        public int gitCode { get; set; }
    }
}