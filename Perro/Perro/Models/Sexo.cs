using System.ComponentModel.DataAnnotations;

namespace Perro.Models
{
    public class Sexo
    {
        [Key]
        public int Id { get; set; }
        public string Genero { get; set; }
    }
}
