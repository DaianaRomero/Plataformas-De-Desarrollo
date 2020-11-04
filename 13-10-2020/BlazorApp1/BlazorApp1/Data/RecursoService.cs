using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class RecursoService
    {
        private DataContext context;

        public RecursoService(DataContext _context)
        {
            context = _context;
        }


        public async Task<Recurso> Get(int id)
        {
            return await context.Recursos.Where(i => i.Id == id).SingleAsync();
        }

        public async Task<List<Recurso>> GetAll()
        {
            return await context.Recursos.Include(i => i.UsuarioId).ToListAsync();
        }
         
        public async Task<Recurso> Save(Recurso value)
        {
            if (value.Id == 0)
            {
                await context.Recursos.AddAsync(value);
            }
            else
            {
                context.Recursos.Update(value);
            }
            await context.SaveChangesAsync();
            return value;
        }

        public async Task<bool> Remove(int id)
        {
            var entidad = await context.Recursos.Where(i => i.Id == id).SingleAsync();
            context.Recursos.Remove(entidad);
            await context.SaveChangesAsync();
            return true;


        }

        public async Task<List<Usuario>> GetUsuario()
        {
            return await context.Usuarios.ToListAsync();
        }
    }
}
