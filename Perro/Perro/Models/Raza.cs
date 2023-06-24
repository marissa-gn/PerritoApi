using System.ComponentModel.DataAnnotations;

namespace Perro.Models
{
    public class Raza
    {
        public Raza()
        {
            Nombres = new HashSet<Nombre>();
        }
        [Key]
        public int IdRaza { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public ICollection<Nombre> Nombres { get; set; }
    }
}
