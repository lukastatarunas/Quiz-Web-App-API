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
    public class Test2ResultController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public Test2ResultController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Test2Result
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Test2Result>>> GetTest2Results()
        {
            return await _context.Test2Results.ToListAsync();
        }

        // GET: api/Test2Result/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Test2Result>> GetTest2Result(long id)
        {
            var test2Result = await _context.Test2Results.FindAsync(id);

            if (test2Result == null)
            {
                return NotFound();
            }

            return test2Result;
        }

        // PUT: api/Test2Result/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTest2Result(long id, Test2Result test2Result)
        {
            if (id != test2Result.Id)
            {
                return BadRequest();
            }

            _context.Entry(test2Result).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Test2ResultExists(id))
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

        // POST: api/Test2Result
        [HttpPost]
        public async Task<ActionResult<Test2Result>> PostTest2Result(Test2Result test2Result)
        {
            _context.Test2Results.Add(test2Result);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTest2Result", new { id = test2Result.Id }, test2Result);
        }

        // DELETE: api/Test2Result/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Test2Result>> DeleteTest2Result(long id)
        {
            var test2Result = await _context.Test2Results.FindAsync(id);
            if (test2Result == null)
            {
                return NotFound();
            }

            _context.Test2Results.Remove(test2Result);
            await _context.SaveChangesAsync();

            return test2Result;
        }

        private bool Test2ResultExists(long id)
        {
            return _context.Test2Results.Any(e => e.Id == id);
        }
    }
}
