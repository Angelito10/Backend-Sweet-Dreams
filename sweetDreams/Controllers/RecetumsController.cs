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
    public class RecetumsController : ControllerBase
    {
        private readonly sweetDreamsContext _context;

        public RecetumsController(sweetDreamsContext context)
        {
            _context = context;
        }

        // GET: api/Recetums
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Recetum>>> GetReceta()
        {
          if (_context.Receta == null)
          {
              return NotFound();
          }
            return await _context.Receta.ToListAsync();
        }

        // GET: api/Recetums/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Recetum>> GetRecetum(int id)
        {
          if (_context.Receta == null)
          {
              return NotFound();
          }
            var recetum = await _context.Receta.FindAsync(id);

            if (recetum == null)
            {
                return NotFound();
            }

            return recetum;
        }

        // PUT: api/Recetums/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRecetum(int id, Recetum recetum)
        {
            if (id != recetum.Id)
            {
                return BadRequest();
            }

            _context.Entry(recetum).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RecetumExists(id))
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

        // POST: api/Recetums
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Recetum>> PostRecetum(Recetum recetum)
        {
          if (_context.Receta == null)
          {
              return Problem("Entity set 'sweetDreamsContext.Receta'  is null.");
          }
            _context.Receta.Add(recetum);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRecetum", new { id = recetum.Id }, recetum);
        }

        // DELETE: api/Recetums/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRecetum(int id)
        {
            if (_context.Receta == null)
            {
                return NotFound();
            }
            var recetum = await _context.Receta.FindAsync(id);
            if (recetum == null)
            {
                return NotFound();
            }

            _context.Receta.Remove(recetum);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RecetumExists(int id)
        {
            return (_context.Receta?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
