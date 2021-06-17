using System;

namespace Bin2Dec
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter up to 8 binary digits: ");

            string input = Console.ReadLine();

            if (input.Length <= 8)

            {
                if (int.TryParse(input, out int number))

                {
                    int decNum = Convert.ToInt32(number.ToString(), 2);

                    Console.WriteLine(decNum);
                }

                else

                {
                    Console.WriteLine("It is not a number");
                }
            }

            else

            {
                Console.WriteLine("You should enter up to 8 binary digits!");
            }
            
        }
    }
}
