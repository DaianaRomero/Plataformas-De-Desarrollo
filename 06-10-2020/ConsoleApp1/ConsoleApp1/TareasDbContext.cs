using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class TareasDbContext : DbContext
    {

     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {   //nombre del archivo al que me voy a conectar
            optionsBuilder.UseSqlite("Data Source=tareas.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                .ToTable("Usuario")
                .Property(p => p.Clave).HasMaxLength(10).IsRequired();

            modelBuilder.Entity<Tarea>()
                .ToTable("Tarea")
                .Property(p=> p.Titulo).HasMaxLength(50).IsRequired();

            modelBuilder.Entity<Detalle>()
                .ToTable("Detalle")
                .Property(p => p.Fecha)
                .HasColumnType("DateTime");

            modelBuilder.Entity<Recurso>()
               .ToTable("Recurso")
               .Property(p=>p.Nombre).HasMaxLength(50).IsRequired();





        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Detalle> Detalles { get; set; }
        public DbSet<Recurso> Recursos { get; set; }
        public DbSet<Tarea> Tareas { get; set; }


    }
}
