using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T19_C_Sharp_Basics
{
    internal class Ejercicio5
    {
        int a = 1;
        int b = 2;
        int c = 3;
        int d = 4;
    
        public void Info()
        {
            Console.WriteLine("Valor A: {0}", a);
            Console.WriteLine("Valor B: {0}", b);
            Console.WriteLine("Valor C: {0}", c);
            Console.WriteLine("Valor D: {0}", d);
        }

        public void Operaciones()
        {
            int tempB = b;
            b = c;
            c = a;
            a = d;
            d = tempB;
            Console.WriteLine("B = C --> B = {0}", b);
            Console.WriteLine("C = A --> C = {0}", c);
            Console.WriteLine("A = D --> A = {0}", a);
            Console.WriteLine("D = B --> D = {0}", d);
        }
    }
}
