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
    public class Test5ResultController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public Test5ResultController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Test5Result
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Test5Result>>> GetTest5Results()
        {
            return await _context.Test5Results.ToListAsync();
        }

        // GET: api/Test5Result/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Test5Result>> GetTest5Result(long id)
        {
            var test5Result = await _context.Test5Results.FindAsync(id);

            if (test5Result == null)
            {
                return NotFound();
            }

            return test5Result;
        }

        // PUT: api/Test5Result/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTest5Result(long id, Test5Result test5Result)
        {
            if (id != test5Result.Id)
            {
                return BadRequest();
            }

            _context.Entry(test5Result).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Test5ResultExists(id))
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

        // POST: api/Test5Result
        [HttpPost]
        public async Task<ActionResult<Test5Result>> PostTest5Result(Test5Result test5Result)
        {
            _context.Test5Results.Add(test5Result);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTest5Result", new { id = test5Result.Id }, test5Result);
        }

        // DELETE: api/Test5Result/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Test5Result>> DeleteTest5Result(long id)
        {
            var test5Result = await _context.Test5Results.FindAsync(id);
            if (test5Result == null)
            {
                return NotFound();
            }

            _context.Test5Results.Remove(test5Result);
            await _context.SaveChangesAsync();

            return test5Result;
        }

        private bool Test5ResultExists(long id)
        {
            return _context.Test5Results.Any(e => e.Id == id);
        }
    }
}
