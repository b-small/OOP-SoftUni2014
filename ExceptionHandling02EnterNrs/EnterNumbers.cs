using System;

namespace ExceptionHandling02EnterNrs
{
    class EnterNumbers
    {
        public static void ReadNumbers(int start, int end)
        {
            string input = Console.ReadLine();
            try
            {
                int num = int.Parse(input);
                if (num <= start || num >= end)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid number! Try again.");
                ReadNumbers(start, end);
            }
        }

        static void Main(string[] args)
        {
                for (int i = 0; i < 10; i++)
                {
                    ReadNumbers(1, 100);
                }
        }
    }
}
