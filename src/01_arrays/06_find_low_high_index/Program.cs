using System;

namespace _06_find_low_high_index
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = 2;
            int[] array = {1, 2, 2, 2, 2, 3, 4, 4, 4, 5, 5, 6, 6, 6, 7, 8, 9};
            Console.WriteLine("Lower index is {0}, Higher index is {1}", bin_search(array, key, false), bin_search(array, key, true));
            Console.ReadLine();
        }

        private static int bin_search(int[] array, int key, Boolean isHigher)
        {
            return bin_search_rec(array, key, 0, array.Length - 1, isHigher);
        }

        private static int bin_search_rec(int[] array, int key, int low, int high, Boolean isHigher)
        {
            if (low > high)
            {
                return -1;
            }

            int mid = low + (high - low)/2;

            if (array[mid] == key)
            {
                do
                {
                    if (isHigher && array[mid + 1] != key  || !isHigher && array[mid - 1] != key)
                    {
                        break;
                    }

                    mid = isHigher ? ++mid : --mid;

                    if (mid < 0 || mid > array.Length - 1)
                    {
                        break;
                    }
                }
                while (array[mid] == key);

                return mid;
            }
            
            if (key > array[mid])
            {
                return bin_search_rec(array, key, mid + 1, high, isHigher);
            }
            else
            {
                return bin_search_rec(array, key, 0, mid - 1, isHigher);
            }
        }
    }
}
