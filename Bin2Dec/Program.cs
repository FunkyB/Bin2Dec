using System;
using System.Linq;

namespace Bin2Dec
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter up to 8 binary digits: ");
            string input = Console.ReadLine();
            bool validInt = int.TryParse(input, out int inputValue);
            bool validInput = input.Length < 9 && input.All(ch => ch == '0' || ch == '1') && validInt;
            while (!validInput)
            {
                Console.WriteLine("Invalid Input. Please try again");
                Console.Write("Enter up to 8 binary digits: ");
                input = Console.ReadLine();
                validInt = int.TryParse(input, out inputValue);
                validInput = input.Length < 9 && input.All(ch => ch == '0' || ch == '1') && validInt;
            }
            int decNum = Convert.ToInt32(inputValue.ToString(), 2);

            Console.WriteLine(decNum);
        }
    }
}
