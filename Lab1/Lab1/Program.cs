using System;
using System.Collections.Generic;
using System.Globalization;

namespace Lab1
{
    class Program
    {

        static void Main(string[] args)
        {
            String s = "";
            double totalSum = 0;

            if (args.Length == 1)
            {
               s = args[0];
            } else { 
                Console.WriteLine("Skriv ETT argument till programmet!");
                Environment.Exit(0);
            }

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (Char.IsDigit(s[i]))
                {
                    for(int j = i+1; j < s.Length; j++)
                    {
                        if (Char.IsDigit(s[j]))
                        {
                            if(s[i] == s[j])
                            {
                               totalSum += FoundMatch(s, i, j);
                               break;
                            }
                        } else { 
                            break;
                        }
                    }
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nDen totala summan är: " + totalSum);
            Console.ForegroundColor = ConsoleColor.White;

        }


        static double FoundMatch(String s, int i, int j)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(s.Substring(0, i));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(s.Substring(i, j - (i - 1)));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(s.Substring(j + 1));
            Console.WriteLine();

            return double.Parse(s.Substring(i, (j - (i - 1))));

        }

    }
}
