using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _02._02._2023
{
    internal class Program
    {
        static void EndErr(int code)
        {
            Console.WriteLine("Error Task " + code);
            Console.ReadKey();
            Environment.Exit(code);
        }

        static void InitArr(int[] arr, int min, int max)
        { 
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = min + r.Next() % (max - min + 1);
            }
        }
        static void PrintArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine();
        }

        static int EvenInArr(int[] arr, bool even = true)
        {
            int res = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == (even ? 0 : 1)) res++;
            }
            return res;
        }

        static int UniqueElArr(int[] arr)
        {
            int res = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (Array.IndexOf(arr, arr[i]) == i) res++;
            }
            return res;
        }

        static int SmallerTo(int[] arr, int num)
        {
            int res = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < num) res++;
            }
            return res;
        }

        static int MultSerch(int[] arr, int[] mult)
        {
            int res = 0;
            int repet = arr.Length - mult.Length + 1;
            for (int i = 0; i < repet; i++)
            {
                for (int y = 0; y < mult.Length; y++)
                {
                    if (arr[i + y] != mult[y]) break;
                    else if (y == mult.Length - 1) res++;
                }
            }
            return res;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[50];
            InitArr(arr, 0, 10);
            PrintArr(arr);

            #region Task 1
            Console.WriteLine($"Even: {EvenInArr(arr)}");
            Console.WriteLine($"Not Even: {EvenInArr(arr, false)}");
            Console.WriteLine($"Unique: {UniqueElArr(arr)}");
            #endregion

            #region Task 2
            Console.WriteLine($"Smaller (5): {SmallerTo(arr, 5)}");
            #endregion

            #region Task 3
            const int mLen = 3;
            int[] mult = new int[mLen];

            Console.WriteLine($"Write {mLen} num: ");

            for (int i = 0; i < mLen; i++)
            {
                Console.Write($"{i + 1}: ");
                string input = Console.ReadLine();
                if (!int.TryParse(input, out mult[i])) EndErr(1);
            }
            
            Console.WriteLine($"Answer: {MultSerch(arr, mult)}");

            #endregion

            Console.ReadKey();
        }
    }
}
