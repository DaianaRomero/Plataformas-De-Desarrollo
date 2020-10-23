using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class UsuarioService
    {
        private DataContext context;

        public UsuarioService (DataContext _context)
        {
            context = _context;
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
}
