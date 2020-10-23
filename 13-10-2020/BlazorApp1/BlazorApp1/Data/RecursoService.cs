using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class RecursoService
    {
        public Recurso[] GetRecurso()
        {



            Recurso[] resultado = new Recurso[5];

            resultado[0] = new Recurso(1, "Recurso 1");
            resultado[1] = new Recurso(2, "Recurso 2");
            resultado[2] = new Recurso(3, "Recurso 3");
            resultado[3] = new Recurso(4, "Recurso 4");
            resultado[4] = new Recurso(5, "Recurso 5");


            return resultado;
        }
    }
}
