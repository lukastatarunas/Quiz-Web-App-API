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
    public class Test1ResultController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public Test1ResultController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Test1Result
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Test1Result>>> GetTest1Results()
        {
            return await _context.Test1Results.ToListAsync();
        }

        // GET: api/Test1Result/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Test1Result>> GetTest1Result(long id)
        {
            var test1Result = await _context.Test1Results.FindAsync(id);

            if (test1Result == null)
            {
                return NotFound();
            }

            return test1Result;
        }

        // PUT: api/Test1Result/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTest1Result(long id, Test1Result test1Result)
        {
            if (id != test1Result.Id)
            {
                return BadRequest();
            }

            _context.Entry(test1Result).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Test1ResultExists(id))
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

        // POST: api/Test1Result
        [HttpPost]
        public async Task<ActionResult<Test1Result>> PostTest1Result(Test1Result test1Result)
        {
            _context.Test1Results.Add(test1Result);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTest1Result", new { id = test1Result.Id }, test1Result);
        }

        // DELETE: api/Test1Result/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Test1Result>> DeleteTest1Result(long id)
        {
            var test1Result = await _context.Test1Results.FindAsync(id);
            if (test1Result == null)
            {
                return NotFound();
            }

            _context.Test1Results.Remove(test1Result);
            await _context.SaveChangesAsync();

            return test1Result;
        }

        private bool Test1ResultExists(long id)
        {
            return _context.Test1Results.Any(e => e.Id == id);
        }
    }
}
