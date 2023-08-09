using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T19_C_Sharp_Basics
{
    internal class Ejercicio1
    {
        //ATRIBUTOS
        int num1 = 15;
        int num2 = 6;


        public void Info()
        {
            Console.WriteLine("Valor 1: {0}", num1);
            Console.WriteLine("Valor 2: {0}", num2);
        }

        public void Suma()
        {
            Console.WriteLine("Suma: {0}", num1 + num2);
        }

        public void Resta()
        {
            Console.WriteLine("Resta: {0}", num1 - num2);
        }

        public void Multiplicacion()
        {
            Console.WriteLine("Multiplicación: {0}", num1 * num2);
        }

        public void Division()
        {
            Console.WriteLine("División: {0}", num1 / num2);
        }

        public void Modulo()
        {
            Console.WriteLine("Modulo: {0}", num1 % num2);
        }
    }
}
