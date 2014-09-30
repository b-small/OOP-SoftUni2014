using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncProgramming02LINQExtensions
{
    static class LINQExtensions
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            return collection.Where(a => !predicate(a));
        }

        public static IEnumerable<T> Repeat<T>(this IEnumerable<T> collection, int count)
        {
            for (int i = 0; i < count; i++)
            {
                foreach (var item in collection)
                {
                    yield return item;
                }
            } 
        }

        public static IEnumerable<string> WhereEndsWith(this IEnumerable<string> collection, IEnumerable<string> suffixes)
        {
            var res = new List<string>();
            foreach (var item in collection)
            {
                foreach (var suffix in suffixes)
                {
                    if (item.EndsWith(suffix))
                    {
                        res.Add(item);
                    }
                }

            }
            return res;
        }
    }
}
