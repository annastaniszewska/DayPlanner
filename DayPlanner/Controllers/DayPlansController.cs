using DayPlanner.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayPlanner.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DayPlansController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public DayPlansController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/DayPlans
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DayPlan>>> GetDayPlans()
        {
            return await _context.DayPlans.ToListAsync();
        }

        // GET: api/DayPlans/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DayPlan>> GetDayPlan(int id)
        {
            var dayPlan = await _context.DayPlans.FindAsync(id);

            if (dayPlan == null)
            {
                return NotFound();
            }

            return dayPlan;
        }

        // PUT: api/DayPlans/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDayPlan(int id, DayPlan dayPlan)
        {
            if (id != dayPlan.Id)
            {
                return BadRequest();
            }

            _context.Entry(dayPlan).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DayPlanExists(id))
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

        // POST: api/DayPlans
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DayPlan>> PostDayPlan(DayPlan dayPlan)
        {
            _context.DayPlans.Add(dayPlan);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetDayPlan), new { id = dayPlan.Id }, dayPlan);
        }

        // DELETE: api/DayPlans/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DayPlan>> DeleteDayPlan(int id)
        {
            var dayPlan = await _context.DayPlans.FindAsync(id);
            if (dayPlan == null)
            {
                return NotFound();
            }

            _context.DayPlans.Remove(dayPlan);
            await _context.SaveChangesAsync();

            return dayPlan;
        }

        private bool DayPlanExists(int id)
        {
            return _context.DayPlans.Any(e => e.Id == id);
        }
    }
}
