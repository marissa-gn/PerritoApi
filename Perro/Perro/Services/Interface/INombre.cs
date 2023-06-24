using Perro.Models;

namespace Perro.Services.Interface
{
    public interface INombreServicio
    {
        public void AddNombre(Nombre nombre);
        Task<Nombre> GetNombreById(int id);
        Task<IEnumerable<Nombre>> GetNombres();
        public void DeleteNombre(int id);
        public void UpdateNombre(Nombre nombre);
    }
}
