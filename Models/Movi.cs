using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eimdbapi.Models
{
    public class Movi
    {
       
        public List<Material> MaterialsList { get; set; }
        public Employee Requester { get; set; }
        public int MoviID { get; set; }
        public string Obra { get; set; }

        public Movi(List<Material> materialsList, Employee req)
        {
            MaterialsList = materialsList;
            Requester = req;
        }
        public Movi(List<Material> materialsList)
        {
            MaterialsList = materialsList;
        }
        public Movi()
        {
            MaterialsList = new List<Material>();
            Requester = new Employee();
        }

        public void includeMaterial(Material material) {
            MaterialsList.Add(material);
        }

        public bool checkIfMaterialAlreadyIncluded(Material material) {
            foreach (var mat in MaterialsList) {
                if (material.Equals(mat)) {
                    return true;
                }
            }
            return false;
        }
    }
}