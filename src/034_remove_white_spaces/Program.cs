using System;

namespace _034_remove_white_spaces
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] s = getCharArray("Hello World!");

            RemoveWhiteSpaces(s);

            for (int i = 0; i < s.Length; i++)
            {
                System.Console.Write(s[i]);
            }

            Console.ReadLine();
        }

        static void RemoveWhiteSpaces(char[] s)
        {
            int read_index = 0;
            int write_index = 0;

            while (read_index < s.Length && s[read_index] != '\0') 
            {
                if (!isWhiteSpace(s[read_index]))
                {
                    s[write_index] = s[read_index];
                    write_index++;
                }
                read_index++;               
            }

            s[write_index] = '\0';
        }

        static bool isWhiteSpace(char c)
        {
            if (c == ' ' || c == '\t') return true;

            return false;
        }

        static char[] getCharArray(string value)
        {
            char[] charArray = new char[value.Length + 1];

            for (int i = 0; i < value.Length; i++)
            {
                charArray[i] = value[i];                
            }
            
            return charArray;
        }
    }
}


