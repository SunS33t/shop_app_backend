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
    public class ColorListsController : ControllerBase
    {
        private readonly shop_appContext _context;

        public ColorListsController(shop_appContext context)
        {
            _context = context;
        }

        // GET: api/ColorLists
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ColorList>>> GetColorLists()
        {
            return await _context.ColorLists.ToListAsync();
        }

        // GET: api/ColorLists/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ColorList>> GetColorList(string id)
        {
            var colorList = await _context.ColorLists.FindAsync(id);

            if (colorList == null)
            {
                return NotFound();
            }

            return colorList;
        }

        // PUT: api/ColorLists/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutColorList(string id, ColorList colorList)
        {
            if (id != colorList.ProductId)
            {
                return BadRequest();
            }

            _context.Entry(colorList).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ColorListExists(id))
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

        // POST: api/ColorLists
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ColorList>> PostColorList(ColorList colorList)
        {
            _context.ColorLists.Add(colorList);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ColorListExists(colorList.ProductId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetColorList", new { id = colorList.ProductId }, colorList);
        }

        // DELETE: api/ColorLists/5
        [HttpDelete("{p_id}")]
        public async Task<IActionResult> DeleteAllProductColor(string p_id)
        {
            var colorList = await _context.ColorLists.Where(x=>x.ProductId == p_id).ToListAsync();
            if (colorList == null)
            {
                return NotFound();
            }
            colorList.ForEach(x => _context.ColorLists.Remove(x));
            
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ColorListExists(string id)
        {
            return _context.ColorLists.Any(e => e.ProductId == id);
        }
    }
}
