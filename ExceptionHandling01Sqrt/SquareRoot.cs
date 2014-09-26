using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling01Sqrt
{
    class SquareRoot
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            try
            {
                int number = int.Parse(input);
                if (number < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                double result = Math.Sqrt(number);
                Console.WriteLine("Square root of {0} is {1}", number, result);
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Goodbye");
            }
        }
    }
}
