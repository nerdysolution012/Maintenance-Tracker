using Maintenance_Tracker_App.Data;
using Maintenance_Tracker_App.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maintenance_Tracker_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestControllers : ControllerBase
    {
        private readonly DataContext _context;
        public RequestControllers(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Request>>> GetAllRequest()
        {
            var request = await _context.Requests.ToListAsync();
            return Ok(request);
        }

        [HttpGet("{int Id}")]
        public async Task<ActionResult<Request>> GetRequest(int Id)
        {
            var request = await _context.Requests.FirstOrDefaultAsync(x => x.requestId == Id);
            return Ok(request);


        }
    }
}
