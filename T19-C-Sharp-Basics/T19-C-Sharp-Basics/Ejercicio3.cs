using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T19_C_Sharp_Basics
{
    internal class Ejercicio3
    {
        //ATRIBUTOS
        int x = 4;
        int y = 9;
        double n = 3.3;
        double m = 9.7;

        //METODOS
        public void Info()
        {
            Console.WriteLine("Valor X: {0}", x);
            Console.WriteLine("Valor Y: {0}",y);
            Console.WriteLine("Valor N: {0}", n);
            Console.WriteLine("Valor N: {0}", m);
        }
        public void Operaciones()
        {
            Console.WriteLine("Suma X+Y: {0}", x + y);
            Console.WriteLine("Diferencia X-Y: {0}", x - y);
            Console.WriteLine("Producto X*Y: {0}", x * y);
            Console.WriteLine("Cociente X/Y: {0}", x / y);
            Console.WriteLine("Resto X%Y: {0}", x % y);

            Console.WriteLine("Suma N+M: {0}", n + m);
            Console.WriteLine("Diferencia N-M: {0}", n - m);
            Console.WriteLine("Producto N*M: {0}", n * m);
            Console.WriteLine("Cociente N/M: {0}", n / m);
            Console.WriteLine("Resto N%M: {0}", n % m);

            Console.WriteLine("Suma X+N: {0}", x + n);
            Console.WriteLine("Cociente Y/M: {0}", y / m);
            Console.WriteLine("Resto Y%M: {0}", y % m);

            Console.WriteLine("Doble de X: {0}", x * 2);
            Console.WriteLine("Doble de Y: {0}", y * 2);
            Console.WriteLine("Doble de N: {0}", n * 2);
            Console.WriteLine("Doble de M: {0}", m * 2);

            Console.WriteLine("Suma X+Y+N+M: {0}", x + y + n + m);
            Console.WriteLine("Producto X*Y*N*M: {0}", x * y * n * m);

        }
    }

}
