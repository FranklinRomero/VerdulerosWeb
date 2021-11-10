using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebVerduleros.Data;
using WebVerduleros.Models;

namespace WebVerduleros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VegetalesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public VegetalesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Vegetales
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Verduras>>> GetVerduras()
        {
            return await _context.Verduras.ToListAsync();
        }

        // GET: api/Vegetales/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Verduras>> GetVerduras(int id)
        {
            var verduras = await _context.Verduras.FindAsync(id);

            if (verduras == null)
            {
                return NotFound();
            }

            return verduras;
        }

        // PUT: api/Vegetales/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVerduras(int id, Verduras verduras)
        {
            if (id != verduras.VerduraId)
            {
                return BadRequest();
            }

            _context.Entry(verduras).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VerdurasExists(id))
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

        // POST: api/Vegetales
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Verduras>> PostVerduras(Verduras verduras)
        {
            _context.Verduras.Add(verduras);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVerduras", new { id = verduras.VerduraId }, verduras);
        }

        // DELETE: api/Vegetales/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVerduras(int id)
        {
            var verduras = await _context.Verduras.FindAsync(id);
            if (verduras == null)
            {
                return NotFound();
            }

            _context.Verduras.Remove(verduras);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VerdurasExists(int id)
        {
            return _context.Verduras.Any(e => e.VerduraId == id);
        }
    }
}
