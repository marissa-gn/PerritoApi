using Perro.Models;

namespace Perro.Services.Interface
{
    public interface ISexoServicio
    {
        public void AddSexo(Sexo sexo);
        Task<Sexo> GetSexosById(int id);
        Task<IEnumerable<Sexo>> GetSexos();
        public void DeleteSexo(int id);
        public void UpdateSexo(Sexo sexo);
    }
}
