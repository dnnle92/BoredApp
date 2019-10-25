using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BoredApi.Data;
using BoredDTO;

namespace BoredApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResponsesController : ControllerBase
    {
        private readonly BoredDbContext _context;

        public ResponsesController(BoredDbContext context)
        {
            _context = context;
        }

        // GET: api/Responses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Response>>> GetResponses()
        {
            return await _context.Responses.ToListAsync();
        }

        // GET: api/Responses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Response>> GetResponse(int id)
        {
            var response = await _context.Responses.FindAsync(id);

            if (response == null)
            {
                return NotFound();
            }

            return response;
        }

        // PUT: api/Responses/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutResponse(int id, Response response)
        {
            if (id != response.Id)
            {
                return BadRequest();
            }

            _context.Entry(response).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ResponseExists(id))
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

        // POST: api/Responses
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Response>> PostResponse(Response response)
        {
            _context.Responses.Add(response);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetResponse", new { id = response.Id }, response);
        }

        // DELETE: api/Responses/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Response>> DeleteResponse(int id)
        {
            var response = await _context.Responses.FindAsync(id);
            if (response == null)
            {
                return NotFound();
            }

            _context.Responses.Remove(response);
            await _context.SaveChangesAsync();

            return response;
        }

        private bool ResponseExists(int id)
        {
            return _context.Responses.Any(e => e.Id == id);
        }
    }
}
