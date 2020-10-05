using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //intro();

            

        }
        

        public static void EF()
        {
            //es como la "conexion a la base de datos"
            AppContext ctx = new AppContext();

            //es como un select* de esa tabla
            var lista = ctx.Actividades.ToList();
            //lo mismo con where    
            var lista2 = ctx.Actividades.Where(i => i.Fecha < DateTime.Now).ToList();

            //aca tengo el primer obj de la lista y lo modifico
            Actividad actividad = lista[0];
            actividad.Nombre = "nuevo nombre";

            //aca lo traigo y despues borro
            var actividad1 = ctx.Actividades.Where(i => i.Id == 15).First();
            ctx.Actividades.Remove(actividad1);

            //agrego a la tabla Actividades los registros
            ctx.Actividades.Add(new Actividad { Lugar = "caba", Nombre = "Clase" });
            ctx.Actividades.Add(new Actividad { Lugar = "caba", Nombre = "Clase" });
            ctx.Actividades.Add(new Actividad { Lugar = "caba", Nombre = "Clase" });
            ctx.Actividades.Add(new Actividad { Lugar = "caba", Nombre = "Clase" });
            ctx.Actividades.Add(new Actividad { Lugar = "caba", Nombre = "Clase" });
             // esto "commitea"
            ctx.SaveChanges();

        }

        public static void Agregado(string orden)
        {
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

            //promedio
            Console.WriteLine(numeros.Average());
            //cantidad
            Console.WriteLine(numeros.Count());
            Console.WriteLine(numeros.Sum());
            Console.WriteLine(numeros.Max());
            Console.WriteLine(numeros.Min());
            Console.WriteLine(numeros.First());
            Console.WriteLine(numeros.Last());
        }

        public static void Tarea()
        {
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            //filtrar por par y ordenarlos
            var resultado = numeros.Where(n => n%2 == 0).OrderByDescending(n => n);

            foreach (var item in resultado)
            {
                Console.WriteLine(resultado);
            }


        }

        public static void Todo(string orden)
        {
            List<Actividad> eventos = new List<Actividad>();
            eventos.Add(new Actividad { Lugar = "Caba", Nombre = "Ms build", Fecha = new DateTime(2020, 11, 9) });
            eventos.Add(new Actividad { Lugar = "Online", Nombre = "Amazon summit", Fecha = new DateTime(2020, 9, 29) });
            eventos.Add(new Actividad { Lugar = "Online", Nombre = "Ms ignite", Fecha = new DateTime(2020, 9, 25) });

            var resultado = eventos
                .Where(i => i.Fecha < DateTime.Now)
                .OrderBy(i => i.Fecha)
                .Select(i => new ActividadDto { Nombre = i.Nombre, Lugar = i.Lugar });

            var resultado2 = eventos
                .Where(i => i.Fecha < DateTime.Now);

            if (orden == "fecha")
            {
                resultado2 = resultado2.OrderBy(i => i.Fecha);
            }
            else
            {
                resultado2 = resultado2.OrderBy(i => i.Nombre);
            }

            var resultado3 = resultado2
                .Select(i => new ActividadDto { Nombre = i.Nombre, Lugar = i.Lugar });

        }

        public static void Proyeccion()
        {
            List<Actividad> eventos = new List<Actividad>();
            eventos.Add(new Actividad { Lugar = "Caba", Nombre = "Ms build", Fecha = new DateTime(2020, 11, 9) });
            eventos.Add(new Actividad { Lugar = "Online", Nombre = "Amazon summit", Fecha = new DateTime(2020, 9, 29) });
            eventos.Add(new Actividad { Lugar = "Online", Nombre = "Ms ignite", Fecha = new DateTime(2020, 9, 25) });

            var nombres = eventos.Select(actividad => actividad.Nombre);

            //lista con  nombre y lugar, creo objeto anonimo
            var nombres2 = eventos.Select(i => new { i.Nombre, i.Lugar });
            //proyeccion solo con el obj
            var nombres3 = eventos.Select(i => new ActividadDto { Nombre = i.Nombre, Lugar = i.Lugar });

        }

        public static void GroupBy()
        {
            List<Actividad> eventos = new List<Actividad>();
            eventos.Add(new Actividad { Lugar = "Caba", Nombre = "Ms build", Fecha = new DateTime(2020, 11, 9) });
            eventos.Add(new Actividad { Lugar = "Online", Nombre = "Amazon summit", Fecha = new DateTime(2020, 9, 29) });
            eventos.Add(new Actividad { Lugar = "Online", Nombre = "Ms ignite", Fecha = new DateTime(2020, 9, 25) });

            var grupos = eventos.GroupBy(i => i.Lugar);
            //agrupo por lugar y fecha. creo un objeto anonimo
            var grupos2 = eventos.GroupBy(i => new { i.Lugar, i.Fecha });

            foreach (var item in grupos2)
            {
                //item.Key.Fecha
            }

        }

        public static void Ordenar()
        {
            List<Actividad> eventos = new List<Actividad>();
            eventos.Add(new Actividad { Lugar = "Caba", Nombre = "Ms build", Fecha = new DateTime(2020, 11, 9) });
            eventos.Add(new Actividad { Lugar = "Online", Nombre = "Amazon summit", Fecha = new DateTime(2020, 9, 29) });
            eventos.Add(new Actividad { Lugar = "Online", Nombre = "Ms ignite", Fecha = new DateTime(2020, 9, 25) });

            //ordena descentente por fecha
            var ordenado = eventos.OrderByDescending(i => i.Fecha);
            //ordena descentente por nombre
            var ordenado2 = eventos.OrderBy(i => i.Nombre);
            //ordena descentente por fecha y despues asc nombre
            var ordenado3 = eventos.OrderByDescending(i => i.Fecha).ThenBy(i => i.Nombre);

        }

        public static void PruebaOfType()
        { //arraylist : coleccion no generica que puede tener cualquier cosa dentro
            ArrayList arrayList = new ArrayList();
            arrayList.Add("test");
            arrayList.Add("gabriel");
            arrayList.Add(1);
            arrayList.Add(2);

            //me dan todos los que sean int //oftype es un filtrado
            var numeros = arrayList.OfType<int>();

            List<IActividad> eventos = new List<IActividad>();
            //agrego a eventos
            eventos.Add(new Actividad());
            eventos.Add(new Tarea());
            // solo guardo las que son del tipo tarea. aplico filtro sobre tipo de datos
            var tareas = eventos.OfType<Tarea>();

        }

        public static void intro()
        {
            //SINTAXIS DE CONSULTA CON LINKQ
            string[] nombres = { "Daiana", "Agustin", "Melba", "Dracarys","Daiana" };
            //para hacer lista de unicos
            IEnumerable<string> unicos = nombres.Distinct();
            //para saber si empiezan con X letra -- devuelve TRUE
            //todos los metodods de linq trabajan con : ienumerables y qreable
            IEnumerable<string> empiezanConD = from nombre in nombres where nombre.StartsWith("D") select nombre;

            foreach (var item in empiezanConD)
            {
                Console.WriteLine(item);
            }

            //SINTAXIS DE METODOS (se usa más)
            IEnumerable<string> empiezanConM = nombres.Where(i => i.StartsWith("M"));
            foreach (var item2 in empiezanConM)
            {
                Console.WriteLine(item2);
            }

            //-----------------------con generics------------------------------

            List<Actividad> eventos = new List<Actividad>();

            eventos.Add(new Actividad { Lugar = "Caba", Nombre = "Ms build", Fecha = new DateTime(2020, 11, 9) });
            eventos.Add(new Actividad { Lugar = "Online", Nombre = "Amazon summit", Fecha = new DateTime(2020, 9, 29) });
            eventos.Add(new Actividad { Lugar = "Online", Nombre = "Ms ignite", Fecha = new DateTime(2020, 9, 25) });

            IEnumerable<string> pasados = eventos.Where(i => i.Fecha < DateTime.Now).Select(i => i.Nombre);

            //lo covierto a una Lista. IEnumerable tiene varios metodods que permiten transformarlo en otros objetos (listas, array, hasshet, diccionarios, etc )
            //List<string> pasados = eventos.Where(i => i.Fecha < DateTime.Now).Select(i => i.Nombre).ToList();

            /////FUNFIONES LANDA
            ///los primeros son los parametros y el último es el RETURN
            Func<int, bool> validarEdad = (edad => edad > 18);
            validarEdad(20);

            //Func<int, string, bool> validarEdad2 = (edad, genero) => (edad > 18 && genero == "M") || (edad > 19 && genero == "F");
            //lo mismo pero más facil de entender
            Func<int, string, bool> validarEdad2 = (edad, genero) =>
            {

                if (genero == "M")
                {
                    return edad > 18;
                }
                else
                {
                    return edad > 19;
                }


            };
            validarEdad2(20, "M");

            //las funciones VOID
            Action<int> imprimir = (valor) => Console.WriteLine(valor);
        }


    }
}
