using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_uniquechars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");
            string input = Console.ReadLine();
            if (IsUnique(input) == true)
                Console.WriteLine("The String " + input
                                  + " has all unique characters");
            else
                Console.WriteLine("The String " + input
                                  + " has duplicate characters");

        }

        private static bool IsUnique(string chars)

        {
            for (int i = 0; i < chars.Length; i++)
            {
                for (int j = i + 1; j < chars.Length; j++)
                {
                    int val = chars[i];
                    if (chars[i] == chars[j])
                    {
                        return false;
                    }

                }


            }
            return true;

        }
    }
}
