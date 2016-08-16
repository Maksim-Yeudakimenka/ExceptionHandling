using System;
using System.IO;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = null;

                try
                {
                    input = Console.ReadLine();
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Input string was too long.");
                }
                catch (OutOfMemoryException)
                {
                    Console.WriteLine("Not enough memory to allocate input string.");
                }
                catch (IOException e)
                {
                    Console.WriteLine($"Input error occured: {e.Message}.");
                }

                if (input == null)
                {
                    continue;
                }

                try
                {
                    Console.WriteLine(input[0]);
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Nothing was entered.");
                }
                catch (IOException e)
                {
                    Console.WriteLine($"Output error occured: {e.Message}.");
                }
            }
        }
    }
}