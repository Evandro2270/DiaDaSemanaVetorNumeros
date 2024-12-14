using System;
using System.Globalization;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                CultureInfo CI = CultureInfo.InvariantCulture;

                int[,] numeros = new int[5,3];

                numeros = new int[,] { { 3, 13 }, { 4, 6 }, { 8, 2 }, { 9, 1 }, { 10, 2 }, };

                Console.WriteLine();
                foreach (int resultado in numeros)
                {
                    Console.WriteLine(resultado);
                }

            }
        }
    }
}