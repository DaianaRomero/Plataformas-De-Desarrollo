using Microsoft.EntityFrameworkCore;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class UsuarioService
    {
        private DataContext context;

        public UsuarioService(DataContext _context)
        {
            context = _context;
        }

       

        public async Task<Usuario> Get(int id)
        {
           /// return await context.Usuarios.Where(i => i.Id == id).SingleAsync();
            var remoteService = RestService.For<IRemoteService>("https://localhost:44358/api/");
            return await remoteService.GetUsuario(id);
        }

        public async Task<List<Usuario>> GetAll()
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44358/api/");
            return await remoteService.GetAllUsuario();
        }

        public async Task<Usuario> Save(Usuario value)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44358/api/");
            return await remoteService.GuardarUsuario(value);

        }
        public async Task<Usuario> GuardaUsuario(Usuario valor)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44358/api/");
            return await remoteService.CrearUsuario(valor);

        }
        public async Task<Usuario> Remove(int id)
        {
            //var entidad = await context.Usuarios.Where(i => i.Id == id).SingleAsync();
            //context.Usuarios.Remove(entidad);
            //await context.SaveChangesAsync();
            //return true;
            var remoteService = RestService.For<IRemoteService>("https://localhost:44358/api/");
            return await remoteService.BorrarUsuario(id);


        }

        



        }


    //public Usuario[] GetUsuario()
    //{



    //    Usuario[] resultado = new Usuario[5];

    //    resultado[0] = new Usuario(1, "Agustin Collado", "1234");
    //    resultado[1] = new Usuario(2, "Daiana Romero", "1478" );
    //    resultado[2] = new Usuario(3, "Florencia Ibarra", "5896");
    //    resultado[3] = new Usuario(4, "Maximiliano Torres", "3652" );
    //    resultado[4] = new Usuario(5, "David Chen", "1254");


    //    return resultado;
    //}
}

