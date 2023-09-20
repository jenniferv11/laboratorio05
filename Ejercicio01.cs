using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB05_Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el primer numero: ");
            int prinro1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo numero: ");
            int segnro2 = int.Parse(Console.ReadLine());
            int resultado = 0;

            for (int i = 0; i < segnro2; i++)
            {
                resultado = resultado + prinro1;
            }
            Console.Write("El resultado es: " + resultado);
            Console.ReadKey();
        }
    }
}
