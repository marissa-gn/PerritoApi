using Perro.Data;
using Perro.Models;
using Perro.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace Perro.Services
{
    public class SexoServicio : ISexoServicio
    {
        private readonly PerroContext _perroContext;
        public SexoServicio(PerroContext perroContext)
        {
            this._perroContext = perroContext;
        }

        public void AddSexo(Sexo sexo)
        {
            this._perroContext.Sexos.Add(sexo);
            this.Save();
        }

        public async Task<IEnumerable<Sexo>> GetSexos()
        {
            return await this._perroContext.Sexos.Include(x => x.Genero).ToListAsync();
        }

        public async Task<Sexo> GetSexosById(int id)
        {
            return await this._perroContext.Sexos.Include(x => x.Genero).FirstOrDefaultAsync(x => x.Id.Equals(id));
        }
        public void DeleteSexo(int id)
        {
            Sexo sexo = this._perroContext
                .Sexos.FirstOrDefault(x => x.Id.Equals(id));
            this._perroContext.Sexos.Remove(sexo);
            this.Save();
        }
        public void UpdateSexo(Sexo sexo)
        {
            Sexo sexolocal = this._perroContext
              .Sexos.AsNoTracking().FirstOrDefault(x => x.Id.Equals(sexo.Id));
            if (sexo.Genero.Equals(""))
            {
                sexo.Genero = sexolocal.Genero;
            }
            this._perroContext.Entry<Sexo>(sexo).State = EntityState.Modified;
            this.Save();
        }

        public void Save()
        {
            this._perroContext.SaveChanges();
        }

    }
}
