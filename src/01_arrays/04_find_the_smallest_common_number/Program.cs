using System;

namespace _04_find_the_smallest_common_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 8, 5, 4, 3, 1 };
            int[] arr2 = { 15, 13, 10, 8, 4, 2, 1, 0 };
            int[] arr3 = { 15, 8, 4, 2 };

            System.Console.WriteLine(find_least_common_number(arr1, arr2, arr3));
        }

        static int find_least_common_number(int[] arr1, int[] arr2, int[] arr3)
        {
            int result = -1;
            int[] arrayWithMinLenght = new int[0];
            
            if (arr1.Length <= arr2.Length && arr1.Length <= arr3.Length)
            {
                arrayWithMinLenght = arr1;
            } 
            else if (arr2.Length <= arr1.Length && arr2.Length <= arr3.Length)
            {
                arrayWithMinLenght = arr2;
            } 
            else if (arr3.Length <= arr1.Length && arr3.Length <= arr2.Length)
            {
                arrayWithMinLenght = arr3;
            }

            for (int i = arrayWithMinLenght.Length - 1 ; i >= 0; i--)
            {
                if (isExist(arr1, arrayWithMinLenght[i]) && isExist(arr2, arrayWithMinLenght[i]) && isExist(arr3, arrayWithMinLenght[i]))
                {
                    return arrayWithMinLenght[i];
                }                
            }

            return result;
        }

        static bool isExist(int[] array, int key)
        { 
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == key)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
