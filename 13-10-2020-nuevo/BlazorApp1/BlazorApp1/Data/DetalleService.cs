using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class DetalleService
    {


        private DataContext context;

        public DetalleService(DataContext _context)
        {
            context = _context;
        }

        public async Task<Detalle> Get(int id)
        {
            return await context.Detalles.Where(i => i.Id == id).SingleAsync();
        }

        public async Task<List<Detalle>> GetAll()
        {
           // return await context.Detalles.ToListAsync();
            return await context.Detalles.Include(i => i.Recurso).Include(i => i.Tarea).ToListAsync();
        }

        public async Task<Detalle> Save(Detalle value)
        {
            if (value.Id == 0)
            {
                await context.Detalles.AddAsync(value);
            }
            else
            {
                context.Detalles.Update(value);
            }
            await context.SaveChangesAsync();
            return value;
        }

        public async Task<bool> Remove(int id)
        {
            var entidad = await context.Detalles.Where(i => i.Id == id).SingleAsync();
            context.Detalles.Remove(entidad);
            await context.SaveChangesAsync();
            return true;


        }
        public async Task<List<Recurso>> GetRecurso()
        {
            return await context.Recursos.ToListAsync();
        }
        public async Task<List<Tarea>> GetTarea()
        {
            return await context.Tareas.ToListAsync();
        }
    }
}
