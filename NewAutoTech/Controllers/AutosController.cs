using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewAutoTech.Data;
using NewAutoTech.Models;

namespace NewAutoTech.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AutosController : Controller
    {
        private AppDbContext _context;
        public AutosController(AppDbContext context)
        {
            _context = context;
        }
       
        //GET:api/Autos/2
        [HttpGet("{id}")]
        public async Task<ActionResult<Autos>> GetAutos(int id)
        {
            var autoss = await _context.Autos.FindAsync(id);
            if (autoss == null)
            {
                return NotFound();
            }
            return autoss;
        }

        //[HttpPost]
        public  Task<ActionResult<Autos>> GetOwnersByAutos()
        {


            var jcao =  from a in _context.Autos
                       join o in _context.Owners on a.AutoID equals o.OwnerID
                        where o.FirstName == "Oleks"
                       orderby o.FirstName
                      select a;

            return jcao.ToList();

           // var joinautossowners = await _context.Autos.GroupJoin(autos => autos.OwnerID, owners => owners.AutoID, (autos, owners) => autos);
              //  return joinautossowners;
        }

    }
}
