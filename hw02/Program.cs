using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamTraining_hw02
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="array"></param>
        /// <param name="mask">uses for ignore excludet elements (if false then ignore)</param>
        /// <returns>returns index of found element, else -1</returns>
        static int FindSquare(int value, int[] array, bool[] mask)
        {
            int square = value * value;
            for (int i = 0; i < array.Length; i++)
            {
                if (mask[i])
                {
                    if (array[i] == square)
                    {
                        return i;
                    }
                }
            }

            return -1;
        }

        static bool Comp(int[] arrayA, int[] arrayB)
        {
            if (arrayA == null || arrayB == null)
            {
                return false;
            }
            if (arrayA.Length != arrayB.Length)
            {
                throw new Exception("arrays must have the same length!");
            }
            if (arrayA.Length == 0 || arrayB.Length == 0)
            {
                return false;
            }
            

            bool[] mask = new bool[arrayA.Length];
            for (int i = 0; i < mask.Length; i++)
            {
                mask[i] = true;
            }

            for (int i = 0; i < arrayA.Length; i++)
            {
                int foundIndex = FindSquare(arrayA[i], arrayB, mask);
                if (foundIndex == -1)
                {
                    return false;
                }
                else
                {
                    mask[foundIndex] = false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter arrays size:> ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arrayA = new int[n];
            int[] arrayB = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter a[{i}]:> ");
                arrayA[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter b[{i}]:> ");
                arrayB[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();


            Console.WriteLine($"comp(a, b) = {Comp(arrayA, arrayB)}");
            Console.ReadKey();
        }
    }
}
