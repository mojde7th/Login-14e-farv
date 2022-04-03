using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Login.Models
{
    public class Yearmonth
    {
        public List<SelectListItem> cat { get; set; }
        public int selmonthId { get; set; }
        public int selmonthnum { get; set; }
        public int selyearname { get; set; }
        public int selyearnum { get; set; }
        public int selmonthname { get; set; }
        public int selyearId { get; set; }
    }
}