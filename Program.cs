using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Please enter word to be randomly cased: ");
                string text = Console.ReadLine();
                Console.Clear();

                string[] newStringA = new string[text.Length];
                string newChar = null;


                Console.WriteLine("You wrote: " + text);
                for (int i = 0; i < text.Length; i++)
                {
                    Random rnd = new Random();
                    int rng = rnd.Next(0, 2);
                    if (rng == 0)
                    {
                        newChar = text.Substring(i, 1).ToLower();
                    }
                    else
                    {
                        newChar = text.Substring(i, 1).ToUpper();
                    }
                    Console.WriteLine(newChar + " on position " + i);
                    newStringA[i] = newChar;
                }
                string newString = string.Join("", newStringA);
                Console.WriteLine("After randomly casing it, the result is " + newString);
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}