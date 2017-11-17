using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = new char[] { 'I', ' ', 'l', 'o', 'v', 'e', ' ', 'T', 'a', 'x', 'i', 'f', 'y' };
            Console.WriteLine(input);
            input = GetReverse(input);
            Console.WriteLine(input);
            Console.ReadLine();
        }
        public static char[] GetReverse(char[] input)
        {
            int temp = 0;

            for (int fl = 0; fl <= input.Length - 1; fl++)
            {
                int count = temp;
                int num1 = 1;

                if (input[fl] == ' ' || fl == input.Length - 1)
                {
                    int l2 = 0;
                    if (fl == input.Length - 1)
                        l2 = fl;
                    else
                        l2 = fl - 1;
                    for (int c = l2; c >= temp; c--)
                    {
                        //Swap
                        if (num1 <= (l2 - temp) / 2)
                        {
                            char tempC = input[count];
                            input[count] = input[c];
                            input[c] = tempC;
                            count++;
                            num1++;
                        }
                    }
                    temp = fl + 1;
                }
            }
            return input;
        }


    }

}

