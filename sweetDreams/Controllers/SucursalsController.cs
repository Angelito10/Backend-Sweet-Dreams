using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sweetDreams.Models;

namespace sweetDreams.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SucursalsController : ControllerBase
    {
        private readonly sweetDreamsContext _context;

        public SucursalsController(sweetDreamsContext context)
        {
            _context = context;
        }

        // GET: api/Sucursals
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sucursal>>> GetSucursals()
        {
          if (_context.Sucursals == null)
          {
              return NotFound();
          }
            return await _context.Sucursals.ToListAsync();
        }

        // GET: api/Sucursals/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Sucursal>> GetSucursal(int id)
        {
          if (_context.Sucursals == null)
          {
              return NotFound();
          }
            var sucursal = await _context.Sucursals.FindAsync(id);

            if (sucursal == null)
            {
                return NotFound();
            }

            return sucursal;
        }

        // PUT: api/Sucursals/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSucursal(int id, Sucursal sucursal)
        {
            if (id != sucursal.Id)
            {
                return BadRequest();
            }

            _context.Entry(sucursal).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SucursalExists(id))
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

        // POST: api/Sucursals
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Sucursal>> PostSucursal(Sucursal sucursal)
        {
          if (_context.Sucursals == null)
          {
              return Problem("Entity set 'sweetDreamsContext.Sucursals'  is null.");
          }
            _context.Sucursals.Add(sucursal);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSucursal", new { id = sucursal.Id }, sucursal);
        }

        // DELETE: api/Sucursals/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSucursal(int id)
        {
            if (_context.Sucursals == null)
            {
                return NotFound();
            }
            var sucursal = await _context.Sucursals.FindAsync(id);
            if (sucursal == null)
            {
                return NotFound();
            }

            _context.Sucursals.Remove(sucursal);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SucursalExists(int id)
        {
            return (_context.Sucursals?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
