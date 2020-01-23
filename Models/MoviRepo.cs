using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eimdbapi.Models
{
    public class MoviRepo
    {
        List<Movi> MoviList;

        public Movi getMoviById(int moviID) {
            foreach (var movi in MoviList) {
                if (movi.MoviID.Equals(moviID)) {
                    return movi;
                }
            }
            return null;
        }

    }
}