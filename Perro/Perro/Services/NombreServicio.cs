using Perro.Data;
using Perro.Models;
using Perro.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace Perro.Services
{
    public class NombreServicio : INombreServicio
    {
        private readonly PerroContext _perroContext;
        public NombreServicio(PerroContext perroContext)
        {
            this._perroContext = perroContext;
        }

        public void AddNombre(Nombre nombre)
        {
            this._perroContext.Razas.Add(nom);
            this.Save();
        }

        public async Task<IEnumerable<Nombre>> GetNombres()
        {
            return await this._perroContext.Nombres.Include(x => x.Name).ToListAsync();
        }

        public async Task<Nombre> GetNombresById(int id)
        {
            return await this._perroContext.Nombres.Include(x => x.Nombres).FirstOrDefaultAsync(x => x.Id.Equals(id));
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
