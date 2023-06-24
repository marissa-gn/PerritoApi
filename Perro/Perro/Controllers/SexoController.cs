using Microsoft.AspNetCore.Mvc;
using Perro.Services.Interface;
using Perro.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Perro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SexoController : ControllerBase
    {
        private readonly ISexoServicio _sexoServicio;
        public SexoController(ISexoServicio sexoServicio)
        {
            this._sexoServicio = sexoServicio;
        }
        // GET: api/<SexoController>
        [HttpGet]
        public async Task<IEnumerable<Sexo>> Get()
        {
            return await this._sexoServicio.GetSexos();
        }

        // GET api/<SexoController>/5
        [HttpGet("{id}")]
        public async Task<Sexo> Get(int id)
        {
            return await this._sexoServicio.GetSexosById(id);
        }

        // POST api/<SexoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SexoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SexoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
