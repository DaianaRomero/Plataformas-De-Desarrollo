using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //armar un juego para adivinar un numero utilizando una variable random, dar 3 chances al jugador 
            // para que acierte, si acierta salen del bucle y le dan un mensaje y si no aciertan imprimen un mensaje 
            //  dando el numero secreto

          /*  Console.WriteLine("Adivine el número por favor del 1 al 10!");
            Random random = new Random();
            int numSecreto = random.Next(10);
            int num2 = 0;
          

            for(int i=0;i<4;i++)
            {
                num2 = numIngresado("Ingrese el numero");
               // num2 = numIngresado2("Ingrese el numero",ref num2);
                if (num2 == numSecreto)
                {break;}
           }


            if (num2 == numSecreto)
            {
                Console.WriteLine(gano());
            }else
            {
                Console.WriteLine(perdio(numSecreto));
            }

            */
            //--------------------------------------------------------------------//

            //Hacer funcion que le pregunte al usuario el año en que nacio y que diga si es bisiesto o no
            //encapuslar por un lado una funcion que pida el dato y devuelva el año
            // y en otra funcion hacer el calculo si es bisiesto o no y que devuelva un boolean

            Console.WriteLine("Ingrese su año de nacimiento por favor");

            int añoIngresado = ingreseAño();
            bool bisiesto = esBisiesto(añoIngresado);

            if (bisiesto)
            {
                Console.WriteLine("Tu año de nacimiento es bisiesto!");
            }
            else { 
                Console.WriteLine("Tu año de nacimiento NO es bisiesto!");
            }









        }
        static int ingreseAño()
        {
            String año = Console.ReadLine();
            return int.Parse(año);
        }

        static bool esBisiesto(int año)
        {
            if ((año % 4 == 0) && ((año % 100 != 0) || (año % 400 == 0)))
            {
                return true;
            }
            return false;

        }






        /* EJERCICIO ANTERIOR
         * 
                static string gano()
                {
                    return "Adivinó!!!!!!!!";
                }
                static string perdio(int valor)
                {
                    return "Perdio! El numero es " + valor;
                }

                static int numIngresado(string mensaje)
                {
                    Console.WriteLine(mensaje);
                    String num = Console.ReadLine();
                    return int.Parse(num);

                }
        */
        //otra forma por referencia
        /*static void numIngresado2(string mensaje, ref int num2)
        {
            Console.WriteLine(mensaje);
            String num = Console.ReadLine();
            num2 = int.Parse(num);

        }*/

        //-------------------------------------------------


    }
}
