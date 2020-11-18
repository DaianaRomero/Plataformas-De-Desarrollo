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
            return await context.Usuarios.Where(i => i.Id == id).SingleAsync();
        }

        public async Task<List<Usuario>> GetAll()
        {
            // return await context.Usuarios.ToListAsync();
            var remoteService = RestService.For<IRemoteService>("https://localhost:44358/api/");
            //await remoteService.CrearUsuario(new Usuario { Nombre = "Florencia"});
            return await remoteService.GetAllUsuario();
        }

        public async Task<Usuario> Save(Usuario value)
        {
            if (value.Id == 0)
            {
                await context.Usuarios.AddAsync(value);
            }
            else
            {
                context.Usuarios.Update(value);
            }
            await context.SaveChangesAsync();
            return value;
        }

        public async Task<bool> Remove(int id)
        {
            var entidad = await context.Usuarios.Where(i => i.Id == id).SingleAsync();
            context.Usuarios.Remove(entidad);
            await context.SaveChangesAsync();
            return true;


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

