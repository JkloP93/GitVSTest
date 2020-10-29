using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitVSTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "H#$@el#%lo #Wo$%*&(*@rld";

            var result = string.Join(" ", input.Split(new char[] { ' ' }, StringSplitOptions.None)
                .Select(x => string.Concat(x.Where(y => Char.IsLetterOrDigit(y)))));

            Console.WriteLine(result);

            Console.WriteLine("Sasai kudasai");
            var REBASE;

            int[] k = { 1, 5, 3, 6, 7, 4, 3, 9, 0 };

            OneDimArrtoTwo(3, 3, out int[,] twoK, k);

            foreach (int i in twoK)
            {
                Console.Write(", " + i);
            }

            Console.WriteLine();

            TwoDimArrtoOne(twoK, out int[] oneK);

            foreach (int i in oneK)
            {
                Console.Write(", " + i);
            }

            Console.WriteLine();
        }

        public static void TwoDimArrtoOne<T>(T[,] array, out T[] result)
        {
            result = new T[array.Length];

            for (int i = 0; i < array.Rank; i++)
            {
                for (int j = 0; j < array.GetUpperBound(0); j++)
                {
                    result[i * j] = array[i, j];
                }
            }
        }

        public static void OneDimArrtoTwo<T>(int rank, int dimLength, out T[,] result, params T[] array)
        {
            result = new T[rank, dimLength];

            for (int i = 0; i < rank; i++)
            {
                for (int j = 0; j < dimLength; j++)
                {
                    if (i == 0)
                    {
                        result[i, j] = array[j];
                    }
                    else
                        result[i, j] = array[dimLength * i + j];
                }
            }
        }
    }
}
