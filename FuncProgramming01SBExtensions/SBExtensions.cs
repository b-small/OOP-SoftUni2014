using System;
using System.Collections.Generic;
using System.Text;

namespace _01_StringBuilder_Extensions
{
    public static class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder("Applying some extensions");

            Console.WriteLine(text.Substring(7, 14));
            text.RemoveText("some");
            Console.WriteLine(text);

            StringBuilder numbers = new StringBuilder();

            numbers.AppendAll(new List<int>() { 1, 2, 3, 66, 6, 67 })
                .AppendAll(new List<double>() { 5.4, 55, 6.4, 3.3 });
            Console.WriteLine(numbers);

        }


        public static StringBuilder Substring(this StringBuilder sb, int startIdx, int length)
        {
            StringBuilder result = new StringBuilder();
            string str = sb.ToString();

            for (int i = 0; i < length; i++)
            {
                result.Append(str[startIdx]);
                startIdx++;
                if (startIdx > str.Length - 1)
                {
                    break;
                }
            }
            return result;
        }

        public static StringBuilder RemoveText(this StringBuilder sb, string text)
        {
            return sb.Replace(text, "");

        }

        public static StringBuilder AppendAll<T>(this StringBuilder sb, IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                sb.Append(item.ToString());
            }
            return sb;
        }
    }
}