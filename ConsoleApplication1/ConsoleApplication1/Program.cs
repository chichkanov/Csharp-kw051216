using System;
using MyLib;

/*
 * Control work
 * 5.12.2016
 */

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n;
            RadiusVector[][] A;
            bool[][] F;
            do
            {
                Console.Clear();

                Methods.ReadNumber(out m, "Enter m: ", "Error");
                Methods.ReadNumber(out n, "Enter n: ", "Error");
                
                A = Methods.CreateMatrix(m, n);
                F = Methods.GetAttributesMatrix(A);

                Methods.PrintArray(A);
                Methods.PrintArray(F);
                Methods.PrintNotify();
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }

    }
}
