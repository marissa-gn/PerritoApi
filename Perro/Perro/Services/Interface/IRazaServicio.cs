using Perro.Models;

namespace Perro.Services.Interface
{
    public interface IRazaServicio
    {
        public void AddRaza(Raza raza);
        Task<Raza> GetRazasById(int id);
        Task<IEnumerable<Raza>> GetRazas();
        public void DeleteRaza(int id);
        public void UpdateRaza(Raza raza);
    }
}
