using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T19_C_Sharp_Basics
{
    class programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Iniciando Ejercicio 1");
            Console.WriteLine("---------------------------------------------");
            //Ejercicio1 1
            Ejercicio1 ejercicio1 = new Ejercicio1();
            ejercicio1.Info();
            Console.WriteLine("----------------");

            ejercicio1.Suma();
            ejercicio1.Resta();
            ejercicio1.Multiplicacion();
            ejercicio1.Division();
            ejercicio1.Modulo();

            Console.ReadLine();

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Iniciando Ejercicio 2");
            Console.WriteLine("---------------------------------------------");
            //Ejercicio1 2
            Ejercicio2 ejercicio2 = new Ejercicio2();
            ejercicio2.Info();
            Console.WriteLine("----------------");

            ejercicio2.Suma();
            ejercicio2.Diferencia();
            ejercicio2.valorNumerico();

            Console.ReadLine();

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Iniciando Ejercicio 3");
            Console.WriteLine("---------------------------------------------");
            //Ejercicio1 2
            Ejercicio3 ejercicio3 = new Ejercicio3();
            ejercicio3.Info();
            Console.WriteLine("----------------");

            ejercicio3.Operaciones();

            Console.ReadLine();
        }
    }
    
}
