#pragma warning disable
using System;
using System.Globalization;
using System.Diagnostics;

namespace CSharpFundamental
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Challenge 1 */
            string text = "this is a text";
            string newText = toTitleCase(text);
            Console.WriteLine(newText); // expect to see "This Is A Text"

            /* Challenge 2 */
            int[,] arrayA = { { 3, 5, 4, 6 }, { 3, 7, 8, 3 } };
            int[,] arrayB = { { 5, 1 }, { 8, 4 }, { 2, 9 }, { 2, 3 } };
            
            int[,] result = matrixMultiply(arrayA, arrayB);
            PrintMatrix(result);
            
        }
        static string toTitleCase(string input)
        {
            string[] tmpStr = input.Split(' ');
            string result = "";

            foreach (var item in tmpStr)
            {
                var tmpItem = (char)((short)item[0] - 32);
                result +=  tmpItem + item.Substring(1) + ' ';
            }
            return result.TrimEnd();
        }
        static int[,] matrixMultiply(int[,] array1, int[,] array2)
        {
            var result = new int[array1.GetLength(0),array2.GetLength(1)];
            
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    int temp = 0;
                    for (int k = 0; k < array1.GetLength(1); k++)
                    {
                        temp += array1[i, k] * array2[k, j];
                    }
                    result[i, j] = temp;
                }
            }
            return result;
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.Write(Environment.NewLine);
            }
        }
    }
}