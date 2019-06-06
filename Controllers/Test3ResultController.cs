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
    public class Test3ResultController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public Test3ResultController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Test3Result
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Test3Result>>> GetTest3Results()
        {
            return await _context.Test3Results.ToListAsync();
        }

        // GET: api/Test3Result/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Test3Result>> GetTest3Result(long id)
        {
            var test3Result = await _context.Test3Results.FindAsync(id);

            if (test3Result == null)
            {
                return NotFound();
            }

            return test3Result;
        }

        // PUT: api/Test3Result/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTest3Result(long id, Test3Result test3Result)
        {
            if (id != test3Result.Id)
            {
                return BadRequest();
            }

            _context.Entry(test3Result).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Test3ResultExists(id))
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

        // POST: api/Test3Result
        [HttpPost]
        public async Task<ActionResult<Test3Result>> PostTest3Result(Test3Result test3Result)
        {
            _context.Test3Results.Add(test3Result);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTest3Result", new { id = test3Result.Id }, test3Result);
        }

        // DELETE: api/Test3Result/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Test3Result>> DeleteTest3Result(long id)
        {
            var test3Result = await _context.Test3Results.FindAsync(id);
            if (test3Result == null)
            {
                return NotFound();
            }

            _context.Test3Results.Remove(test3Result);
            await _context.SaveChangesAsync();

            return test3Result;
        }

        private bool Test3ResultExists(long id)
        {
            return _context.Test3Results.Any(e => e.Id == id);
        }
    }
}
