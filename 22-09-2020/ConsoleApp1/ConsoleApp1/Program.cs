using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            List <Tareas> ListaDeTareas = new List <Tareas>();
            //ctrl. me da atajos de constructir
            ListaDeTareas.Add(new Tareas("Ejercicio1", new DateTime(2020, 9, 22), 10, new Recursos(), false));
            ListaDeTareas.Add(new Tareas("Ejercicio1", new DateTime(2020, 9, 22), 10, new Recursos(), false));
            ListaDeTareas.Add(new Tareas("Ejercicio1", new DateTime(2020, 9, 22), 10, new Recursos(), false));
            ListaDeTareas.Add(new Tareas("Ejercicio1", new DateTime(2020, 9, 22), 10, new Recursos(), false));
            ListaDeTareas.Add(new Tareas("Ejercicio1", new DateTime(2020, 9, 22), 10, new Recursos(), false));



        }
    }
}
