using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public interface IRemoteService
    {
        [Get("/Usuario")]
        Task<List<Usuario>> GetAllUsuario();
        //[Post("/Usuario")]
        //Task<Usuario> CrearUsuario(Usuario valor);
    }
}
