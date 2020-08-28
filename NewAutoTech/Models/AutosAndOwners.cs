using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewAutoTech.Models
{
    public class AutosAndOwners
    {

        public int Autoid { get; set; }

        public Autos Autos { get; set; }
        public int Ownerid { get; set; }

        public Owners Owners { get; set; }

    }
}
