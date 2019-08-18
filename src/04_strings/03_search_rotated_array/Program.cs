using System;

namespace _03_search_rotated_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayCase1 = {77, 87, 89, 1, 6, 8, 9, 10, 11 };
            int[] arrayCase2 = {55, 77, 87, 89, 1, 6, 8 };
            int keyCase1 = 10;
            int keyCase2 = 77;
            int result = -1;
            
            result = binarySearchRotated(arrayCase1, keyCase1, 0, arrayCase1.Length - 1);
            System.Console.WriteLine(result);            

            result = binarySearchRotated(arrayCase2, keyCase2, 0, arrayCase2.Length - 1);
            System.Console.WriteLine(result);            
            System.Console.ReadLine();
        }

        static int binarySearchRotated(int[] array, int key, int low, int high)
        {
            if (low > high) return -1;
            int mid = low + (high - low) / 2;

            if (array[mid] == key) return mid;

            if (array[low] <= key && key <= array[mid])
            {
                return binarySearchRotated(array, key, low, mid - 1);
            }
            else
            {
                return binarySearchRotated(array, key, mid + 1, high);
            }
        }
    }
}
