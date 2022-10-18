using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcOld.Models
{
    public class Movies
    {
        public int MovieId { get; set; }
        public string Name { get; set; }
        public string Director { get; set;}
        public int Boxoffice { get; set; }

        
    }
}