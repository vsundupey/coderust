using System;
using System.Collections.Generic;

namespace _02_max_in_sliding_window
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrange
            int windowSize = 3;
            int[] sourceArray = { -4, 2, -5, 3, 6 };
            int[] expectedResult = { 2, 3, 6 };
            IList<int> actualResult = new List<int>();
            Queue<int> window = new Queue<int>();

            for (int i = 0; i < windowSize; i++)
            {
                window.Enqueue(sourceArray[i]);
            }

            // Act
            for (int i = windowSize - 1; i < sourceArray.Length; i++)
            {
                actualResult.Add(getMaxInWindow(window));
                
                if (i + 1 < sourceArray.Length)
                {
                    window.Dequeue();
                    window.Enqueue(sourceArray[i + 1]);
                }
            }

            // Assert
            for (int i = 0; i < expectedResult.Length; i++)
            {
                if (expectedResult[i] != actualResult[i])
                {
                    System.Console.ForegroundColor = ConsoleColor.Red;
                    throw new Exception("Failed");
                }
            }
            
            System.Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine("Success");
            System.Console.ForegroundColor = ConsoleColor.White;
        }

        private static int getMaxInWindow(Queue<int> window)
        {
            int result = 0;

            foreach (var item in window)
            {
                if (result < item)
                {
                    result = item;
                }
            }

            return result;
        }
    }
}
