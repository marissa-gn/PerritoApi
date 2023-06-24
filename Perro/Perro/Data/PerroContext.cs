using Perro.Models;
using Microsoft.EntityFrameworkCore;

namespace Perro.Data
{
    public class PerroContext:DbContext
    {
        public PerroContext(DbContextOptions<PerroContext>dbContextOptions):
            base(dbContextOptions)
        {
        }
        public DbSet <Sexo> Sexos { get; set; }
        public DbSet <Raza> Razas { get; set; }
        public DbSet <Nombre> Nombres { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Raza>().HasData(
            new Raza { IdRaza = 1, Nombre = "Bulldog", Descripcion="Soy un Bulldog"  },
            new Raza { IdRaza = 2, Nombre = "Labrador", Descripcion = "Soy un Labrador" },
            new Raza { IdRaza = 3, Nombre = "Golden retriever", Descripcion = "Soy un Golden retriever" },
            new Raza { IdRaza = 4, Nombre = "Pastor aleman", Descripcion = "Soy un Pastor Aleman" },
            new Raza { IdRaza = 5, Nombre = "Husky", Descripcion = "Soy un Husky" }

          );
            modelBuilder.Entity<Sexo>().HasData(
            new Sexo { Id=1, Genero = "Macho" },
            new Sexo { Id = 2, Genero = "Hembra" }

           );
            modelBuilder.Entity<Nombre>().HasData(
            new Nombre { Id = 1, Name = "Jumbo", IdRaza=5 },
            new Nombre { Id = 2, Name = "Bolillo", IdRaza=3 },
            new Nombre { Id = 3, Name = "Luna", IdRaza=4 },
            new Nombre { Id = 4, Name = "Dogui" , IdRaza = 1},
            new Nombre { Id = 5, Name = "Chikis",IdRaza=2 },
            new Nombre { Id = 6, Name = "Pato", IdRaza = 1 },
            new Nombre { Id = 7, Name = "Taco", IdRaza = 2 },
            new Nombre { Id = 8, Name = "Pulgoso", IdRaza = 3 },
            new Nombre { Id = 9, Name = "Solovino", IdRaza = 4 },
            new Nombre { Id = 10, Name = "Firulais", IdRaza = 5 }
            );
            modelBuilder.Entity<Raza>()
                .HasMany<Nombre>(x => x.Nombres)
                .WithOne(s => s.Raza)
                .HasForeignKey(s => s.IdRaza);

        }
    }
}
