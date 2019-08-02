using System;

namespace _05_rotate_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }

            rotate_array_left(arr, 3);

            System.Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
        }

        static void rotate_array_right(int[] arr, int n)
        {
            n %= arr.Length;

            int[] tmp = new int[n];

            Array.Copy(arr, arr.Length - n, tmp, 0, n);
            Array.Copy(arr, 0, arr, n, arr.Length - n);
            Array.Copy(tmp, arr, tmp.Length);           
        }

        static void rotate_array_left(int[] arr, int n)
        {
            n %= arr.Length;

            int[] tmp = new int[n];

            Array.Copy(arr, tmp, n);
            Array.Copy(arr, n, arr, 0, arr.Length - n);
            Array.Copy(tmp, 0, arr, arr.Length - n, tmp.Length);           
        }
    }
}
