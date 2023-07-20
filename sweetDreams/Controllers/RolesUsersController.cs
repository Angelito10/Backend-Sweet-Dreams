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
    public class RolesUsersController : ControllerBase
    {
        private readonly sweetDreamsContext _context;

        public RolesUsersController(sweetDreamsContext context)
        {
            _context = context;
        }

        // GET: api/RolesUsers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RolesUser>>> GetRolesUsers()
        {
          if (_context.RolesUsers == null)
          {
              return NotFound();
          }
            return await _context.RolesUsers.ToListAsync();
        }

        // GET: api/RolesUsers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RolesUser>> GetRolesUser(int id)
        {
          if (_context.RolesUsers == null)
          {
              return NotFound();
          }
            var rolesUser = await _context.RolesUsers.FindAsync(id);

            if (rolesUser == null)
            {
                return NotFound();
            }

            return rolesUser;
        }

        // PUT: api/RolesUsers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRolesUser(int id, RolesUser rolesUser)
        {
            if (id != rolesUser.Id)
            {
                return BadRequest();
            }

            _context.Entry(rolesUser).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RolesUserExists(id))
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

        // POST: api/RolesUsers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RolesUser>> PostRolesUser(RolesUser rolesUser)
        {
          if (_context.RolesUsers == null)
          {
              return Problem("Entity set 'sweetDreamsContext.RolesUsers'  is null.");
          }
            _context.RolesUsers.Add(rolesUser);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRolesUser", new { id = rolesUser.Id }, rolesUser);
        }

        // DELETE: api/RolesUsers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRolesUser(int id)
        {
            if (_context.RolesUsers == null)
            {
                return NotFound();
            }
            var rolesUser = await _context.RolesUsers.FindAsync(id);
            if (rolesUser == null)
            {
                return NotFound();
            }

            _context.RolesUsers.Remove(rolesUser);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RolesUserExists(int id)
        {
            return (_context.RolesUsers?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
