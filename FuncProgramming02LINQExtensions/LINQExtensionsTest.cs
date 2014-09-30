using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncProgramming02LINQExtensions
{
    class LINQExtensionsTest
    {
        static void Main()
        {
            var numbers = new List<int>() { 2, 4, 6, 22, 13, 11, 5754, 245 };

            Console.WriteLine(string.Join(" ", numbers.WhereNot(a => a % 2 == 0)));

            Console.WriteLine(string.Join(" ", numbers.Repeat<int>(2)));

            IEnumerable<string> stringItems = new List<string>() { "Jivei", "Spokoino", ",", "gledai", "samo", "napred", "Hakuna", "matata" };
            IEnumerable<string> suffixes = new List<string>() { "ei", "ai", ","};
            Console.WriteLine(string.Join(" ", stringItems.WhereEndsWith(suffixes)));
        }
    }
}
