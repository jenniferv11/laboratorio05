using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB05_Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int promedio;
            Console.Write("Ingrese el número de notas: ");
            int nronotas = int.Parse(Console.ReadLine());
            int notas = 1;

            for (int i = 1; i <= nronotas; i++)
            {
                Console.Write("Promedio nota " + i + ": ");
                int nota = int.Parse(Console.ReadLine());
                notas = notas + nota;
            }
            promedio = notas / nronotas;
            Console.WriteLine("El promedio es: " + promedio);
            Console.ReadKey();
        }
    }
}
