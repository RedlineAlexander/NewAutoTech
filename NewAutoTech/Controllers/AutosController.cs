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

    }
}
