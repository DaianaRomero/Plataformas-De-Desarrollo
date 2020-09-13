using System;
using System.Collections.Generic;
using System.Text;

namespace ej1
{
    public abstract class  CalculadoraBase{

        
        public virtual int Resta2(int num1, int num2) //cambio su estructura en las clases heredadas
    {
        return num2 - num1;
    }

        public abstract int Division2(int num1, int num2);

}

    
}

