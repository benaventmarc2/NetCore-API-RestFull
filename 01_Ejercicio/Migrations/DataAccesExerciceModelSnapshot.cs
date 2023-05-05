﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _01_Ejercicio.DataAccess;

#nullable disable

namespace _01_Ejercicio.Migrations
{
    [DbContext(typeof(DataAccesExercice))]
    partial class DataAccesExerciceModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("_01_Ejercicio.Models.DataModels.Curso", b =>
                {
                    b.Property<string>("Nombre")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("DescripcionCorta")
                        .HasMaxLength(280)
                        .HasColumnType("nvarchar(280)");

                    b.Property<string>("DescripcionLarga")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Objetivos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PublicoObjetivo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Requisitos")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Nombre");

                    b.ToTable("Curso");
                });
#pragma warning restore 612, 618
        }
    }
}