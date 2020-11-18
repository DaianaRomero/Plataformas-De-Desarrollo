using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Parcial");
           

    // -----> Acá agrego los datos a las diferentes tablas en la Base de Datos

            //InsertarUsuarios();
           //InsertarRecursos();
           // InsertarTareas();
           //InsertarDetalles();

            Consultar(); // ----> Acá realizo diferentes tipos de consultas


             //Actualizar(); // ---> modifico datos de tablas


            // Borrado(); //---> Acá borro elementos de tablas pasandole un valor (en este ejemplo un ID)




        }

        static void Borrado()
        {

            
            var cxt = new TareasDbContext();

            var usuario = cxt.Usuarios.Where(i => i.Id == 4).Single();
            cxt.Usuarios.Remove(usuario);



           var recurso = cxt.Recursos.Where(i => i.Id == 1).Single();
           cxt.Recursos.Remove(recurso);

           var tarea = cxt.Tareas.Where(i => i.Id == 2).Single();
           cxt.Tareas.Remove(tarea);

            cxt.SaveChanges();
        }

       
        static void Actualizar()
        {
            var cxt = new TareasDbContext();

            var lista = cxt.Usuarios.Where(i => i.Id == 1).ToList();
            lista[0].Clave = "1111";

            var lista2 = cxt.Tareas.Where(i => i.Id == 2).ToList();
            lista2[0].Titulo = "Olvidalo Marge, éste es el barrio Chino!";
            

            cxt.SaveChanges();
        }

        static void Consultar()
        {
            var cxt = new TareasDbContext();

            var lista = cxt.Usuarios.ToList();
            foreach(var item  in lista)
            {
                Console.WriteLine($"Nombre: {item.Nombre} ({item.Id})");
            }

            var lista2 = cxt.Recursos.ToList();
            foreach (var item in lista2)
            {
                Console.WriteLine($"Recurso: {item.Nombre} ({item.Id})");
            }


            var lista3 = cxt.Tareas.ToList();
            foreach (var item in lista3)
            {
                Console.WriteLine($"Id: ({item.Id})- Tarea: {item.Titulo} - Vencimiento: ({item.Vencimiento}) - Estimacion: ({item.Estimacion}) - Estado: ({item.Estado})");
            }


        }



        static void InsertarUsuarios()
        {
            var cxt = new TareasDbContext();
            cxt.Usuarios.Add(new Usuario
            {
                Id = 1,
                Nombre = "Daiana",
                Clave = "1994"
            });
            cxt.Usuarios.Add(new Usuario
            {
                Id = 2,
                Nombre = "Maximiliano",
                Clave = "1234"
            });
            cxt.Usuarios.Add(new Usuario
            {
                Id = 3,
                Nombre = "David",
                Clave = "1478"
            });
            cxt.Usuarios.Add(new Usuario
            {
                Id = 4,
                Nombre = "Agustin",
                Clave = "1993"
            });
            cxt.Usuarios.Add(new Usuario
            {
                Id = 5,
                Nombre = "Florencia",
                Clave = "1992"
            });



            cxt.SaveChanges();
        }

        static void InsertarRecursos()
        {
            var cxt = new TareasDbContext();
            cxt.Recursos.Add(new Recurso
            {
                Id = 1,
                Nombre = "Primer Recurso",
                UsuarioId = 1

            });
          
            cxt.Recursos.Add(new Recurso
            {
                Id = 2,
                Nombre = "Segundo Recurso",
                UsuarioId = 2

            });
            cxt.Recursos.Add(new Recurso
            {
                Id = 3,
                Nombre = "Tercer Recurso",
                UsuarioId = 3

            });
            cxt.Recursos.Add(new Recurso
            {
                Id = 4,
                Nombre = "Cuarto Recurso",
                UsuarioId = 4

            });
            cxt.Recursos.Add(new Recurso
            {
                Id = 5,
                Nombre = "Quinto Recurso",
                UsuarioId = 5

            });

            cxt.SaveChanges();
        }

        static void InsertarTareas()
        {
            var cxt = new TareasDbContext();
            cxt.Tareas.Add(new Tarea
            {

                Id = 1,
                Titulo = "Tarea 1",
                Vencimiento = new DateTime(2016, 6, 1, 6, 34, 53),
                Estimacion = "10 meses",
                RecursoId = 1,
                Estado = false
            });
            cxt.Tareas.Add(new Tarea
            {

                Id = 2,
                Titulo = "Tarea 2",
                Vencimiento = new DateTime(2016, 6, 1, 6, 34, 53),
                Estimacion = "10 meses",
                RecursoId = 2,
                Estado = true
            });
            cxt.Tareas.Add(new Tarea
            {

                Id = 3,
                Titulo = "Tarea 3",
                Vencimiento = new DateTime(2016, 6, 1, 6, 34, 53),
                Estimacion = "10 meses",
                RecursoId = 3,
                Estado = false
            });
            cxt.Tareas.Add(new Tarea
            {

                Id = 4,
                Titulo = "Tarea 4",
                Vencimiento = new DateTime(2016, 6, 1, 6, 34, 53),
                Estimacion = "10 meses",
                RecursoId = 4,
                Estado = true
            });
            cxt.Tareas.Add(new Tarea
            {

                Id = 5,
                Titulo = "Tarea 5",
                Vencimiento = new DateTime(2016, 6, 1, 6, 34, 53),
                Estimacion = "10 meses",
                RecursoId = 5,
                Estado = false
            });

            cxt.SaveChanges();

        }

        static void InsertarDetalles()
        {
            var cxt = new TareasDbContext();
            cxt.Detalles.Add(new Detalle
            {

                Id = 1,
                Fecha = new DateTime(2020, 10, 09, 6, 34, 53),
                Tiempo = "2 meses",
                RecursoId = 1,
                TareaId= 1
            });
            cxt.Detalles.Add(new Detalle
            {

                Id = 2,
                Fecha = new DateTime(2020, 10, 09, 6, 34, 53),
                Tiempo = "2 meses",
                RecursoId = 2,
                TareaId = 2
            });
            cxt.Detalles.Add(new Detalle
            {

                Id = 3,
                Fecha = new DateTime(2020, 10, 09, 6, 34, 53),
                Tiempo = "2 meses",
                RecursoId = 3,
                TareaId = 3
            });
            cxt.Detalles.Add(new Detalle
            {

                Id = 4,
                Fecha = new DateTime(2020, 10, 09, 6, 34, 53),
                Tiempo = "2 meses",
                RecursoId = 4,
                TareaId = 4
            });
            cxt.Detalles.Add(new Detalle
            {

                Id = 5,
                Fecha = new DateTime(2020, 10, 09, 6, 34, 53),
                Tiempo = "2 meses",
                RecursoId = 5,
                TareaId = 5
            });

            cxt.SaveChanges();
        }









         /*
        static void Actualizar2()
        {
            var cxt = new TareasDbContext();

            //devuelve un unico registro
            var usuario = cxt.Usuarios.Where(i => i.Id == 1).Single();
            usuario.Nombre = "Agus";

            //por si no hay registro 3 me devuelve el primero
            var usuario2 = cxt.Usuarios.Where(i => i.Id == 3).FirstOrDefault();
            if (usuario2 != null)
            {
                usuario2.Nombre = "Prueba";
            }

            //si tengo 2 usuarios iguales solamente me trae el primero y a ese lo cambia
            var usuario3 = cxt.Usuarios.Where(i => i.Nombre == "Agus" && i.Id < 4).FirstOrDefault();
            if (usuario3 != null)
            {
                usuario3.Nombre = "Prueba";
            }

            cxt.SaveChanges();
        }

        */

    }
}
