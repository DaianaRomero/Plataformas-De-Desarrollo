using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class DetalleService
    {

        public Detalle[] GetDetalle()
        {



            Detalle[] resultado = new Detalle[5];

            resultado[0] = new Detalle(1, new DateTime(2016, 6, 1, 6, 34, 53), "10 meses");
            resultado[1] = new Detalle(2, new DateTime(2016, 6, 1, 6, 34, 53), "1 mes");
            resultado[2] = new Detalle(3, new DateTime(2016, 6, 1, 6, 34, 53), "5 meses");
            resultado[3] = new Detalle(4, new DateTime(2016, 6, 1, 6, 34, 53), "6 meses");
            resultado[4] = new Detalle(5, new DateTime(2016, 6, 1, 6, 34, 53), "1 año");


            return resultado;
        }

    }
}
