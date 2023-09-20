using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB05_Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la base: ");
            int bas = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el exponente: ");
            int exponente = int.Parse(Console.ReadLine());
            int resultado = 1;

            for (int i = 0; i < exponente; i++)
            {
                resultado = resultado * bas;
            }
            Console.Write("El resultado es: " + resultado);
            Console.ReadKey();
        }
    }
}
