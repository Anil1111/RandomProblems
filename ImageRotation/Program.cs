using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] inputArray = new int[][]
            {
                new int[] {1, 2, 3 },
                new int[] {4, 5, 6 },
                new int[] {7, 8, 9 }
            };

            Console.Write("Input Array: " + Environment.NewLine);
            PrintArray(inputArray);

            int[][] rotatedImage = RotateImage(inputArray);
            Console.Write("Output Array [After a clockwise rotation of 90 degrees]: ");
            PrintArray(rotatedImage);

            Console.WriteLine("The program has finished executing, please press any key to exit");

            Console.ReadKey();
        }

        private static int[][] RotateImage(int[][] a)
        {
            int[][] b = new int[a.Length][];
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = new int[a[i].Length];
                for (int j = 0; j < a[i].Length; j++)
                {
                    b[i][j] = a[a[i].Length - j - 1][i];
                }
            }

            return b;
        }

        private static void PrintArray(int[][] inputArray)
        {
            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = 0; j < inputArray[i].Length; j++)
                {
                    Console.Write("{0} ", inputArray[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
