using System;

namespace _07_move_zeros_left
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[] { 1, 10, -1, 11, 5, 0, -7, 0, 25, -35 };
            Console.WriteLine("[{0}]", string.Join(", ", v));
            MoveZerosToLeftInArray(v);
            Console.WriteLine("[{0}]", string.Join(", ", v));
        }

        static void MoveZerosToLeftInArray(int[] arr)
        {
            int write_index = arr.Length - 1;
            int read_index = arr.Length - 1;

            while (read_index >= 0)
            {
                if (arr[read_index] != 0)
                {
                    arr[write_index] = arr[read_index];
                    write_index--;
                }

                read_index--;
            }

            while (write_index >= 0)
            {
                arr[write_index] = 0;
                write_index--;
            }
        }


    }
}
