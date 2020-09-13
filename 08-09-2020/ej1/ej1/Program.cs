using System;
using System.Resources;
using ClassLibrary1;
namespace ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Calculadora calculadora = new Calculadora();
            Class1 clase = new Class1();
           // calculadora.Numero1 = 10;
            Console.WriteLine(calculadora.Sumar(10,20));
            Console.WriteLine(calculadora.Restar(2, 10));
            Console.WriteLine(calculadora.Multiplicar(8, 7));
            Console.WriteLine(calculadora.Dividir(10, 0));
            Console.WriteLine("-----------------");
            CalculadoraCientifica cs = new CalculadoraCientifica();
            Console.WriteLine(cs.Potencia(10, 2));
            Console.WriteLine(cs.Sumar(10, 20));
            Console.WriteLine("-----------------");
            Console.WriteLine(calculadora.Resta2(5, 8));
            Console.WriteLine(cs.Resta2(5, 8));
            Console.WriteLine("-----------------");
            Console.WriteLine(Ayuda.Sumar(2, 2));
            

        }
    }
}
