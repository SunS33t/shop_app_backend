using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using shopApp_BackEnd.Models;

namespace shopApp_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OpeningHoursController : ControllerBase
    {
        private readonly shop_appContext _context;

        public OpeningHoursController(shop_appContext context)
        {
            _context = context;
        }

        // GET: api/OpeningHours
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OpeningHour>>> GetOpeningHours()
        {
            return await _context.OpeningHours.ToListAsync();
        }

        // GET: api/OpeningHours/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OpeningHour>> GetOpeningHour(string id)
        {
            var openingHour = await _context.OpeningHours.FindAsync(id);

            if (openingHour == null)
            {
                return NotFound();
            }

            return openingHour;
        }

        // PUT: api/OpeningHours/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOpeningHour(string id, OpeningHour openingHour)
        {
            if (id != openingHour.ShopId)
            {
                return BadRequest();
            }

            _context.Entry(openingHour).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OpeningHourExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/OpeningHours
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OpeningHour>> PostOpeningHour(OpeningHour openingHour)
        {
            _context.OpeningHours.Add(openingHour);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (OpeningHourExists(openingHour.ShopId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetOpeningHour", new { id = openingHour.ShopId }, openingHour);
        }

        // DELETE: api/OpeningHours/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOpeningHour(string id)
        {
            var openingHour = await _context.OpeningHours.FindAsync(id);
            if (openingHour == null)
            {
                return NotFound();
            }

            _context.OpeningHours.Remove(openingHour);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OpeningHourExists(string id)
        {
            return _context.OpeningHours.Any(e => e.ShopId == id);
        }
    }
}
