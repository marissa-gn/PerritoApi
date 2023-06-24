﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Perro.Data;

#nullable disable

namespace Perro.Migrations
{
    [DbContext(typeof(PerroContext))]
    partial class PerroContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Perro.Models.Nombre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdRaza")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdRaza");

                    b.ToTable("Nombres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IdRaza = 5,
                            Name = "Jumbo"
                        },
                        new
                        {
                            Id = 2,
                            IdRaza = 3,
                            Name = "Bolillo"
                        },
                        new
                        {
                            Id = 3,
                            IdRaza = 4,
                            Name = "Luna"
                        },
                        new
                        {
                            Id = 4,
                            IdRaza = 1,
                            Name = "Dogui"
                        },
                        new
                        {
                            Id = 5,
                            IdRaza = 2,
                            Name = "Chikis"
                        },
                        new
                        {
                            Id = 6,
                            IdRaza = 1,
                            Name = "Pato"
                        },
                        new
                        {
                            Id = 7,
                            IdRaza = 2,
                            Name = "Taco"
                        },
                        new
                        {
                            Id = 8,
                            IdRaza = 3,
                            Name = "Pulgoso"
                        },
                        new
                        {
                            Id = 9,
                            IdRaza = 4,
                            Name = "Solovino"
                        },
                        new
                        {
                            Id = 10,
                            IdRaza = 5,
                            Name = "Firulais"
                        });
                });

            modelBuilder.Entity("Perro.Models.Raza", b =>
                {
                    b.Property<int>("IdRaza")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdRaza"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdRaza");

                    b.ToTable("Razas");

                    b.HasData(
                        new
                        {
                            IdRaza = 1,
                            Descripcion = "Soy un Bulldog",
                            Nombre = "Bulldog"
                        },
                        new
                        {
                            IdRaza = 2,
                            Descripcion = "Soy un Labrador",
                            Nombre = "Labrador"
                        },
                        new
                        {
                            IdRaza = 3,
                            Descripcion = "Soy un Golden retriever",
                            Nombre = "Golden retriever"
                        },
                        new
                        {
                            IdRaza = 4,
                            Descripcion = "Soy un Pastor Aleman",
                            Nombre = "Pastor aleman"
                        },
                        new
                        {
                            IdRaza = 5,
                            Descripcion = "Soy un Husky",
                            Nombre = "Husky"
                        });
                });

            modelBuilder.Entity("Perro.Models.Sexo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sexos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Genero = "Macho"
                        },
                        new
                        {
                            Id = 2,
                            Genero = "Hembra"
                        });
                });

            modelBuilder.Entity("Perro.Models.Nombre", b =>
                {
                    b.HasOne("Perro.Models.Raza", "Raza")
                        .WithMany("Nombres")
                        .HasForeignKey("IdRaza")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Raza");
                });

            modelBuilder.Entity("Perro.Models.Raza", b =>
                {
                    b.Navigation("Nombres");
                });
#pragma warning restore 612, 618
        }
    }
}
