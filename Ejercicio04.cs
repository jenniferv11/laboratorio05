using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB05_Ejercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float facto = 1.0f;
            Console.Write("Ingrese el numero limite: ");
            int limite = int.Parse(Console.ReadLine());
            Console.WriteLine("============================");
            Console.WriteLine("Ingrese una opcion:");
            Console.WriteLine("1. Numeros pares.");
            Console.WriteLine("2. Numeros impares.");
            Console.WriteLine("3. Factorial.");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    for (int i = 1; i <= limite; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.Write(i + ", ");
                        }
                    }
                    Console.Write("");
                    break;

                case 2:
                    for (int i = 1; i <= limite; i++)
                    {
                        if (i % 2 != 0)
                        {
                            Console.Write(i + ", ");
                        }
                    }
                    Console.Write("");
                    break;

                case 3:
                    for (int i = 1; i <= limite; i++)
                    {
                        facto = facto * i;
                    }
                    Console.Write("" + facto);
                    break;
            }
            Console.ReadKey();
        }
    }
}
