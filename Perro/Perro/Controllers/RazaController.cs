using Microsoft.AspNetCore.Mvc;
using Perro.Services.Interface;
using Perro.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Perro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RazaController : ControllerBase
    {
        private readonly IRazaServicio _razaServicio;
        public RazaController(IRazaServicio razaServicio)
        {
            this._razaServicio = razaServicio;
        }
        // GET: api/<RazaController>
        [HttpGet]
        public async Task <IEnumerable<Raza>> Get()
        {
            return await this._razaServicio.GetRazas();
        }

        // GET api/<RazaController>/5
        [HttpGet("{id}")]
        public async Task <Raza> Get(int id)
        {
            return await this._razaServicio.GetRazasById(id);
        }

        // POST api/<RazaController>
        [HttpPost]
        public void Post([FromBody] string  razaPost,string descripcion)
        {
            Raza raza = new Raza();
            raza.Nombre = razaPost;
            raza.Descripcion = descripcion;
            this._razaServicio.AddRaza(raza);
        }

        // PUT api/<RazaController>/5
        [HttpPut]
        public void Put([FromBody] Raza raza)
        {
            this._razaServicio.UpdateRaza(raza);

        }

        // DELETE api/<RazaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            this._razaServicio.DeleteRaza(id);
        }
    }
}
