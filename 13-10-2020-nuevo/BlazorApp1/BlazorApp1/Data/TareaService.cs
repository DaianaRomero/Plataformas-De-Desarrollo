using Microsoft.EntityFrameworkCore;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class TareaService
    {
       
            private DataContext context;

            public TareaService(DataContext _context)
            {
                context = _context;
            }


        public async Task<Tarea> Get(int id)
        {
            //return await context.Tareas.Where(i => i.Id == id).SingleAsync();
            var remoteService = RestService.For<IRemoteService>("https://localhost:44358/api/");
            return await remoteService.GetTarea(id);
        }

        public async Task<List<Tarea>> GetAll()
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44358/api/");
            return await remoteService.GetAllTarea();
        }
        public async Task<List<Recurso>> GetRecurso()
        {
            return await context.Recursos.ToListAsync();
        }

        public async Task<Tarea> Save(Tarea value)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44358/api/");
            return await remoteService.GuardarTarea(value);
        }
        public async Task<Tarea> GuardaTarea(Tarea valor)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44358/api/");
            return await remoteService.CrearTarea(valor);

        }
        public async Task<bool> Remove(int id)
        {
            var entidad = await context.Tareas.Where(i => i.Id == id).SingleAsync();
            context.Tareas.Remove(entidad);
            await context.SaveChangesAsync();
            return true;


        }

        
    }

    
}
