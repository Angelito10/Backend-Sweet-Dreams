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
    public class UnidadMedidumsController : ControllerBase
    {
        private readonly sweetDreamsContext _context;

        public UnidadMedidumsController(sweetDreamsContext context)
        {
            _context = context;
        }

        // GET: api/UnidadMedidums
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UnidadMedidum>>> GetUnidadMedida()
        {
          if (_context.UnidadMedida == null)
          {
              return NotFound();
          }
            return await _context.UnidadMedida.ToListAsync();
        }

        // GET: api/UnidadMedidums/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UnidadMedidum>> GetUnidadMedidum(int id)
        {
          if (_context.UnidadMedida == null)
          {
              return NotFound();
          }
            var unidadMedidum = await _context.UnidadMedida.FindAsync(id);

            if (unidadMedidum == null)
            {
                return NotFound();
            }

            return unidadMedidum;
        }

        // PUT: api/UnidadMedidums/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUnidadMedidum(int id, UnidadMedidum unidadMedidum)
        {
            if (id != unidadMedidum.Id)
            {
                return BadRequest();
            }

            _context.Entry(unidadMedidum).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UnidadMedidumExists(id))
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

        // POST: api/UnidadMedidums
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UnidadMedidum>> PostUnidadMedidum(UnidadMedidum unidadMedidum)
        {
          if (_context.UnidadMedida == null)
          {
              return Problem("Entity set 'sweetDreamsContext.UnidadMedida'  is null.");
          }
            _context.UnidadMedida.Add(unidadMedidum);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUnidadMedidum", new { id = unidadMedidum.Id }, unidadMedidum);
        }

        // DELETE: api/UnidadMedidums/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUnidadMedidum(int id)
        {
            if (_context.UnidadMedida == null)
            {
                return NotFound();
            }
            var unidadMedidum = await _context.UnidadMedida.FindAsync(id);
            if (unidadMedidum == null)
            {
                return NotFound();
            }

            _context.UnidadMedida.Remove(unidadMedidum);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UnidadMedidumExists(int id)
        {
            return (_context.UnidadMedida?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
