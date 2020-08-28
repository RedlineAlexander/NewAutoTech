using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewAutoTech.Models
{
    public class Owners
    {
        public int OwnerID { get; set; } 
        public string LastName { get; set; }
          
        public string FirstName { get; set; }

        public string FatherName { get; set; }
        public DateTime BirthDate { get; set; }
        public List<AutosAndOwners> OwnersAutos { get; set; }
     }
}
