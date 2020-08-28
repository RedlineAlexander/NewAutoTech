using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewAutoTech.Models
{
    public class Autos
    {
        public int AutoID { get; set; }

        public string AutoName { get; set; }

        public string AutoColor { get; set; } 
        public DateTime YearFromPipeline { get; set; }
        public List<AutosAndOwners> AutosOwners { get; set; }

    }
}
