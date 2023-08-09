using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T19_C_Sharp_Basics
{
    internal class Ejercicio2
    {
        //ATRIBUTOS
        int n = 10;
        double a = 4.5;
        char c = 'c';

        //METODOS
        public void Info()
        {
            Console.WriteLine("Valor N: {0}", n);
            Console.WriteLine("Valor A: {0}", a);
            Console.WriteLine("Valor C: {0}", c);
        }
        public void Suma()
        {
            Console.WriteLine("Suma N+A: {0}", n + a);
        }

        public void Diferencia()
        {
            Console.WriteLine("Diferencia A-N: {0}", a - n);
        }

        public void valorNumerico()
        {
            Console.WriteLine("Valor numérico caracter C: {0}", (int)c);
        }
    }

}
