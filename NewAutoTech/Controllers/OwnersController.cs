using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewAutoTech.Data;
using NewAutoTech.Models;

namespace NewAutoTech.Controllers
{
    public class OwnersController : Controller
    {
        private AppDbContext _context;
        public OwnersController(AppDbContext context)
        {
            _context = context;
        }
        //GET:api/Owners/2
        [HttpGet("{id}")]
        public async Task<ActionResult<Owners>> GetOwners(int id)
        {
            var ownerss = await _context.Owners.FindAsync(id);
            if (ownerss == null)
            {
                return NotFound();
            }
            return ownerss;
        }
        //[HttpPost]
        public Task<ActionResult<Autos>> GetOwnersByAutos()
        {


            var jcoa = from o in _context.Owners
                       join a in _context.Autos on o.OwnerID equals a.AutoID
                       where o.FirstName == "Oleks"
                       orderby a.AutoID
                       select a.AutoID;

            return jcao.ToList();

            // var joinautossowners = await _context.Autos.GroupJoin(autos => autos.OwnerID, owners => owners.AutoID, (autos, owners) => autos);
            //  return joinautossowners;
        }
    }
}
