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
    public class CustomerCartsController : ControllerBase
    {
        private readonly shop_appContext _context;

        public CustomerCartsController(shop_appContext context)
        {
            _context = context;
        }

        // GET: api/CustomerCarts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerCart>>> GetCustomerCarts()
        {
            return await _context.CustomerCarts.ToListAsync();
        }

        // GET: api/CustomerCarts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerCart>> GetCustomerCart(string id)
        {
            var customerCart = await _context.CustomerCarts.FindAsync(id);

            if (customerCart == null)
            {
                return NotFound();
            }

            return customerCart;
        }

        // PUT: api/CustomerCarts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomerCart(string id, CustomerCart customerCart)
        {
            if (id != customerCart.UserId)
            {
                return BadRequest();
            }

            _context.Entry(customerCart).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerCartExists(id))
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

        // POST: api/CustomerCarts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CustomerCart>> PostCustomerCart(CustomerCart customerCart)
        {
            _context.CustomerCarts.Add(customerCart);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CustomerCartExists(customerCart.UserId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCustomerCart", new { id = customerCart.UserId }, customerCart);
        }

        // DELETE: api/CustomerCarts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomerCart(string id)
        {
            var customerCart = await _context.CustomerCarts.FindAsync(id);
            if (customerCart == null)
            {
                return NotFound();
            }

            _context.CustomerCarts.Remove(customerCart);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CustomerCartExists(string id)
        {
            return _context.CustomerCarts.Any(e => e.UserId == id);
        }
    }
}
