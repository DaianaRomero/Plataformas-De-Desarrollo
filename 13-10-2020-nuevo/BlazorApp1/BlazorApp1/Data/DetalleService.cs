using Microsoft.EntityFrameworkCore;
using Refit;
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
            //return await context.Detalles.Where(i => i.Id == id).SingleAsync();
            var remoteService = RestService.For<IRemoteService>("https://localhost:44358/api/");
            return await remoteService.GetDetalle(id);
        }

        public async Task<List<Detalle>> GetAll()
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44358/api/");
            return await remoteService.GetAllDetalle();
        }

        public async Task<Detalle> Save(Detalle value)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44358/api/");
            return await remoteService.GuardarDetalle(value);
        }
        public async Task<Detalle> GuardaRecurso(Detalle valor)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44358/api/");
            return await remoteService.CrearDetalle(valor);

        }
        public async Task<Detalle> Remove(int id)
        {
            //var entidad = await context.Detalles.Where(i => i.Id == id).SingleAsync();
            //context.Detalles.Remove(entidad);
            //await context.SaveChangesAsync();
            //return true;
            var remoteService = RestService.For<IRemoteService>("https://localhost:44358/api/");
            return await remoteService.BorrarDetalle(id);



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
