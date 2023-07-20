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
    public class DetalleRecetumsController : ControllerBase
    {
        private readonly sweetDreamsContext _context;

        public DetalleRecetumsController(sweetDreamsContext context)
        {
            _context = context;
        }

        // GET: api/DetalleRecetums
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DetalleRecetum>>> GetDetalleReceta()
        {
          if (_context.DetalleReceta == null)
          {
              return NotFound();
          }
            return await _context.DetalleReceta.ToListAsync();
        }

        // GET: api/DetalleRecetums/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DetalleRecetum>> GetDetalleRecetum(int id)
        {
          if (_context.DetalleReceta == null)
          {
              return NotFound();
          }
            var detalleRecetum = await _context.DetalleReceta.FindAsync(id);

            if (detalleRecetum == null)
            {
                return NotFound();
            }

            return detalleRecetum;
        }

        // PUT: api/DetalleRecetums/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDetalleRecetum(int id, DetalleRecetum detalleRecetum)
        {
            if (id != detalleRecetum.Id)
            {
                return BadRequest();
            }

            _context.Entry(detalleRecetum).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DetalleRecetumExists(id))
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

        // POST: api/DetalleRecetums
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DetalleRecetum>> PostDetalleRecetum(DetalleRecetum detalleRecetum)
        {
          if (_context.DetalleReceta == null)
          {
              return Problem("Entity set 'sweetDreamsContext.DetalleReceta'  is null.");
          }
            _context.DetalleReceta.Add(detalleRecetum);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDetalleRecetum", new { id = detalleRecetum.Id }, detalleRecetum);
        }

        // DELETE: api/DetalleRecetums/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDetalleRecetum(int id)
        {
            if (_context.DetalleReceta == null)
            {
                return NotFound();
            }
            var detalleRecetum = await _context.DetalleReceta.FindAsync(id);
            if (detalleRecetum == null)
            {
                return NotFound();
            }

            _context.DetalleReceta.Remove(detalleRecetum);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DetalleRecetumExists(int id)
        {
            return (_context.DetalleReceta?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
