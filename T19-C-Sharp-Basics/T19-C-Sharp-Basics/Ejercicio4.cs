using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T19_C_Sharp_Basics
{
    internal class Ejercicio4
    {
        //ATRIBUTOS
        int n = 10;

        //METODOS
        public void Info()
        {
            Console.WriteLine("Valor: {0}", n);
        }

        public void Operaciones()
        {
            Console.WriteLine("N + 77 = {0}", n + 77);
            Console.WriteLine("N - 3 = {0}", n - 3);
            Console.WriteLine("N * 2 = {0}", n * 2);
        }

    }
}
