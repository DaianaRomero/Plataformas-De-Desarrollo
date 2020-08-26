using System;
using System.Diagnostics.CodeAnalysis;

namespace ejer1
{
    class Program
    {
        static void Main(string[] args)
        {


            /*
             Armar un programa que le pida al usuario que adivine un numero que ustedes prefijaron, 
            si adivina le muestran un mensaje de felicitacion, caso contrario que siga participando
             */
            string numero;
            Console.WriteLine("Ingrese un numero");
            numero = Console.ReadLine();



            int num;
            num=int.Parse(numero);
            while(num != 8)
            {
                Console.WriteLine("Intente nuevamente");
                num = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Adivinó");
        }
    }
}
