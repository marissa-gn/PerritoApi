using Perro.Data;
using Perro.Models;
using Perro.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace Perro.Services
{
    public class RazaServicio : IRazaServicio
    {
        private readonly  PerroContext _perroContext;
        public RazaServicio(PerroContext perroContext)
        {
            this._perroContext = perroContext;
        }

        public void AddRaza(Raza raza)
        {
            this._perroContext.Razas.Add(raza);
            this.Save();
        }

        public async Task<IEnumerable<Raza>> GetRazas()
        {
            return await this._perroContext.Razas.Include(x=>x.Nombres).ToListAsync();
        }

        public async Task<Raza> GetRazasById(int id)
        {
            return await this._perroContext.Razas.Include(x => x.Nombres).FirstOrDefaultAsync(x => x.IdRaza.Equals(id));
        }
        public void DeleteRaza(int id)
        {
            Raza raza = this._perroContext
                .Razas.FirstOrDefault(x => x.IdRaza.Equals(id));
            this._perroContext.Razas.Remove(raza);
            this.Save();
        }
        public void UpdateRaza(Raza raza)
        {
            Raza razalocal = this._perroContext
              .Razas.AsNoTracking().FirstOrDefault(x => x.IdRaza.Equals(raza.IdRaza));
            if (raza.Nombre.Equals(""))
            {
                raza.Nombre = razalocal.Nombre;
            }
            this._perroContext.Entry<Raza>(raza).State = EntityState.Modified;
            this.Save();
        }

        public void Save()
        {
            this._perroContext.SaveChanges();
        }

    }
}
