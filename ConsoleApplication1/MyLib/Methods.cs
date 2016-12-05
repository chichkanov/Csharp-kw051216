using System;

namespace MyLib
{
    public static class Methods
    {
        public static Random rand = new Random();

        /// <summary>
        /// Init radius vector array
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static RadiusVector[][] CreateMatrix(int m, int n)
        {
            RadiusVector[][] A = new RadiusVector[m][];
            for(int i = 0; i < A.GetLength(0); i++)
            {
                A[i] = new RadiusVector[m];
                for(int j = 0; j < A[i].Length; j++)
                {
                    double x = getRandom();
                    double y = getRandom();
                    A[i][j] = new RadiusVector(x, y);
                }
            }
            return A;
        }

        /// <summary>
        /// Get array with atributes
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static bool[][] GetAttributesMatrix(RadiusVector[][] A)
        {
            bool[][] arr = new bool[A.GetLength(0)][];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                arr[i] = new bool[A[i].Length];
                for(int j = 0; j < A[i].Length; j++)
                {
                    arr[i][j] = A[i][j].Cos < 0.5 ? true : false;
                }
            }
            return arr;
        }

        /// <summary>
        /// Get amount of true atributes for every row
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int[] TrueInRows(bool[][] arr)
        {
            int[] counter = new int[arr.GetLength(0)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j]) counter[i]++;
                }
            }
            return counter;
        }

        /// <summary>
        /// Random element in range -5;5
        /// </summary>
        /// <returns></returns>
        public static double getRandom() => rand.NextDouble() * 10 - 5;

        /// <summary>
        /// Integer reader
        /// </summary>
        /// <param name="n"></param>
        /// <param name="text"></param>
        /// <param name="errorText"></param>
        public static void ReadNumber(out int n, string text, string errorText)
        {
            Console.Write(text);
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine(errorText);
                Console.Write(text);
            }
        }

        /// <summary>
        /// Get total amount of true atributes
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        private static int getTotalAtr(int[] arr)
        {
            int count = 0;
            foreach(int item in arr)
            {
                if (item != 0) count += item;
            }
            return count;
        }

        /// <summary>
        /// Print on screen array with Cos
        /// </summary>
        /// <param name="arr"></param>
        public static void PrintArray(RadiusVector[][] arr)
        {
            int[] counter = TrueInRows(GetAttributesMatrix(arr));
            Console.WriteLine();
            for(int i = 0; i < arr.GetLength(0); i++, Console.WriteLine())
            {
                if (i == 0) Console.Write("A:\t");
                else Console.Write("\t");
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write($"{arr[i][j].Cos:F3}\t");
                }
                Console.Write(counter[i]);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Print on screen array with atributes
        /// </summary>
        /// <param name="arr"></param>
        public static void PrintArray(bool[][] arr)
        {
            Console.WriteLine();
            for (int i = 0; i < arr.GetLength(0); i++, Console.WriteLine())
            {
                if (i == 0) Console.Write("F:\t");
                else Console.Write("\t");
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write($"{arr[i][j]}\t");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Total: " + getTotalAtr(TrueInRows(arr)));
        }

        /// <summary>
        /// Program notification`
        /// </summary>
        public static void PrintNotify()
        {
            Console.WriteLine();
            Console.WriteLine("Press ESC to quit\nPress any other key to repeap program");
        }

    }
}
