using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BoredDTO;

namespace BoredApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoredDbController<TEntity, TRepository> : ControllerBase
        where TEntity : class, IEntity
        where TRepository : IDataRepository<TEntity>
    {
        private readonly TRepository repository;

        public BoredDbController(TRepository repository)
        {
            this.repository = repository;
        }

        // GET: api/BoredDb
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TEntity>>> Get()
        {
            return await repository.GetAll();
        }

        // GET: api/BoredDb/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TEntity>> Get(int id)
        {
            var response = await repository.Get(id);
            if (response == null)
            {
                return NotFound();
            }
            return response;
        }

        // PUT: api/BoredDb/5
        [HttpPut("{id}")]
        public async Task<ActionResult<TEntity>> Put(int id, TEntity response)
        {
            if (id != response.Id)
            {
                return BadRequest();
            }
            await repository.Update(response);
            return NoContent();
        }

        // POST: api/BoredDb
        [HttpPost]
        public async Task<ActionResult<TEntity>> Post(TEntity response)
        {
            await repository.Add(response);
            return CreatedAtAction("Get", new { id = response.Id }, response);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TEntity>> Delete(int id)
        {
            var response = await repository.Delete(id);
            if (response == null)
            {
                return NotFound();
            }
            return response;
        }
    }
}
