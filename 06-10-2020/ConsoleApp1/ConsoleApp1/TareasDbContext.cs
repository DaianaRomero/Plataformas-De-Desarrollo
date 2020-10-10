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
            modelBuilder.Entity<Usuario>().ToTable("Usuario").Property(p => p.Clave).HasMaxLength(10).IsRequired();
            modelBuilder.Entity<Usuario>().Property(p=>p.Nombre).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Usuario>().Property(p => p.Id).ValueGeneratedOnAdd();
            

            modelBuilder.Entity<Tarea>().ToTable("Tarea").Property(p=> p.Titulo).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Tarea>().Property(p => p.Vencimiento).IsRequired();
            modelBuilder.Entity<Tarea>().Property(p => p.Estimacion).HasDefaultValue(0);
            modelBuilder.Entity<Tarea>().Property(p => p.Estado).HasDefaultValue(false);
            modelBuilder.Entity<Tarea>().Property(p => p.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<Detalle>().ToTable("Detalle").Property(p => p.Fecha).HasColumnType("DateTime");
            modelBuilder.Entity<Detalle>().Property(p => p.Tiempo).IsRequired();
            modelBuilder.Entity<Detalle>().Property(p => p.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<Recurso>().ToTable("Recurso").Property(p=>p.Nombre).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Recurso>().Property(p => p.Id).ValueGeneratedOnAdd();




        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Detalle> Detalles { get; set; }
        public DbSet<Recurso> Recursos { get; set; }
        public DbSet<Tarea> Tareas { get; set; }


    }
}
