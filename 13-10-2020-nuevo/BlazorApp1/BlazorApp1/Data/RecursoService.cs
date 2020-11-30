using Microsoft.EntityFrameworkCore;
using Refit;
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
            //return await context.Recursos.Where(i => i.Id == id).SingleAsync();
            var remoteService = RestService.For<IRemoteService>("https://localhost:44358/api/");
            return await remoteService.GetRecurso(id);
        }

        public async Task<List<Recurso>> GetAll()
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44358/api/");
            return await remoteService.GetAllRecurso();
        }

        public async Task<Recurso> Save(Recurso value)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44358/api/");
            return await remoteService.GuardarRecurso(value);

        }

        public async Task<Recurso> GuardaRecurso(Recurso valor)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44358/api/");
            return await remoteService.CrearRecurso(valor);

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
