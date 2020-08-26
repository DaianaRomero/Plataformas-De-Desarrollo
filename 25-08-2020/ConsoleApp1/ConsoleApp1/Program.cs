using System;
using System.Xml;

namespace ConsoleApp1 //similar a los package de java
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine("Ingrese su edad por favor");
            //    string mensaje;
            //    int dato;
            //    string valor = Console.ReadLine();
            //    dato = int.Parse(valor);

            //    if(dato < 18)
            //    {
            //        mensaje = "No podés tomar alcohol";
            //    }else  if (dato>18 && dato <= 70)
            //    {
            //        mensaje = "Podes tomar alcohol de forma moderada";
            //    }
            //    else
            //    {
            //        mensaje = "Podes tomar alcohol pero no es recomendable";
            //    }

            //    Console.WriteLine(mensaje);
            int numero = 0;
            int dato;
            for(int i = 0; i < 10; i++) { 
            Console.WriteLine("Escribe un numero");
                string valor = Console.ReadLine();
                  dato = int.Parse(valor);
                numero+=dato;
                if (numero >= 50)
                {
                    break;
                }
               
            }

            Console.WriteLine("La suma es " + numero);


        }
    }
}
