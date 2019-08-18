using System;

namespace _01_binary_search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 6, 8, 43, 55, 77, 87, 89 };
            int key = 77;

            int result = binarySearch(array, key, 0, array.Length - 1);

            System.Console.WriteLine(result);            
            System.Console.ReadLine();
        }

        static int binarySearch(int[] array, int key, int low, int high)
        {
            if (low > high) return -1;
            int mid = low + ((high - low) / 2);

            if (array[mid] == key) return mid;

            if (key < array[mid])
            {
                return binarySearch(array, key, low, mid - 1);
            }
            else
            {
                return binarySearch(array, key, mid, high);
            }
        }
    }
}
