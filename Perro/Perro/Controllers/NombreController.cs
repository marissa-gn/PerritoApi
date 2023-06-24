using Microsoft.AspNetCore.Mvc;
using Perro.Services.Interface;
using Perro.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Perro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NombreController : ControllerBase
    {
        private readonly INombreServicio _nombreServicio;
        public NombreController(INombreServicio nombreServicio)
        {
            this._nombreServicio = nombreServicio;
        }
        // GET: api/<RazaController>
        [HttpGet]
        public async Task<IEnumerable<Nombre>> Get()
        {
            return await this._nombreServicio.GetNombres();
        }

        // GET api/<RazaController>/5
        [HttpGet("{id}")]
        public async Task<Nombre> Get(int id)
        {
            return await this._nombreServicio.GetNombresById(id);
        }

        // POST api/<NombreController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<NombreController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<NombreController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
