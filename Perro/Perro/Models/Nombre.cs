using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Perro.Models
{
    public class Nombre
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int IdRaza { get; set; }
        [JsonIgnore]
        public virtual Raza Raza { get; set; }
    }
}
