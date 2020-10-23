using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class TareaService
    {


        public Tarea[] GetTareas()
        {
            


            Tarea[] resultado = new Tarea[5];

            resultado[0] = new Tarea(1, "Tarea 1", new DateTime(2016, 6, 1, 6, 34, 53), "10", false);
            resultado[1] = new Tarea(2, "Tarea 2", new DateTime(2016, 6, 1, 6, 34, 53), "10", false);
            resultado[2] = new Tarea(3, "Tarea 3", new DateTime(2016, 6, 1, 6, 34, 53), "10", false);
            resultado[3] = new Tarea(4, "Tarea 4", new DateTime(2016, 6, 1, 6, 34, 53), "10", false);
            resultado[4] = new Tarea(5, "Tarea 5", new DateTime(2016, 6, 1, 6, 34, 53), "10", false);


            return resultado;
        }

    }
}
