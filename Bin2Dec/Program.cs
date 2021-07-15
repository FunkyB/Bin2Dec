using System;
using System.Linq;

namespace Bin2Dec
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Enter up to 8 binary digits: ");
                string input = Console.ReadLine();

                if (input.Length < 9 && input.All(ch => ch == '0' || ch == '1'))
                {
                    int decNum = Convert.ToInt32(input, 2);
                    Console.WriteLine($"Decimal value of bin {input} = {decNum}");
                }
                else
                {
                    Console.WriteLine("Invalid Input. Please try again");
                }
            }
            while (true);
        }
    }
}