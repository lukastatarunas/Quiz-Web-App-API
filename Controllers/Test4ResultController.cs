using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Test4ResultController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public Test4ResultController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Test4Result
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Test4Result>>> GetTest4Results()
        {
            return await _context.Test4Results.ToListAsync();
        }

        // GET: api/Test4Result/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Test4Result>> GetTest4Result(long id)
        {
            var test4Result = await _context.Test4Results.FindAsync(id);

            if (test4Result == null)
            {
                return NotFound();
            }

            return test4Result;
        }

        // PUT: api/Test4Result/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTest4Result(long id, Test4Result test4Result)
        {
            if (id != test4Result.Id)
            {
                return BadRequest();
            }

            _context.Entry(test4Result).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Test4ResultExists(id))
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

        // POST: api/Test4Result
        [HttpPost]
        public async Task<ActionResult<Test4Result>> PostTest4Result(Test4Result test4Result)
        {
            _context.Test4Results.Add(test4Result);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTest4Result", new { id = test4Result.Id }, test4Result);
        }

        // DELETE: api/Test4Result/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Test4Result>> DeleteTest4Result(long id)
        {
            var test4Result = await _context.Test4Results.FindAsync(id);
            if (test4Result == null)
            {
                return NotFound();
            }

            _context.Test4Results.Remove(test4Result);
            await _context.SaveChangesAsync();

            return test4Result;
        }

        private bool Test4ResultExists(long id)
        {
            return _context.Test4Results.Any(e => e.Id == id);
        }
    }
}
