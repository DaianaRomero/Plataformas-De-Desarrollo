using System;
using System.Collections.Generic;
using System.Text;

namespace ej1
{
    public class Calculadora : CalculadoraBase
    {
        //private int numero1;
        //public int Numero1
        //{
        //    get
        //    {
        //        return numero1;
        //    }
        //    set
        //    {
        //        numero1 = value;
        //    }
        //}
        //public int Numero2 { get; set; }


        //public override sealed int Restar2(int num1, int num2)
        //pongo sealer cuando no quiero que se herede ni sobreescriba de nuevo
        //se puede poner en metodos y clases
        public  int Sumar(int num1,int num2) 
        {
            return num1 + num2;
        }
        public int Restar(int num1, int num2)
        {
            return num1 - num2;
        }
        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }
        public int Dividir(int num1, int num2)
        {
            if (num2 == 0)
            {
                 Console.WriteLine("No es posible realizar  la división");
                return 0;
            }
            else
            {
                return num1 / num2;
            }
        }

        public override int Division2(int num1, int num2)
        {
            if (num1 == 0)
            {
                Console.WriteLine("No es posible realizar  la división");
                return 0;
            }
            else
            {
                return num2 / num1;
            }
        }


        public override int Resta2(int num1, int num2)
        {
            //return base.Resta2(num1, num2);
            return num1-num2;
        }
    }
}
