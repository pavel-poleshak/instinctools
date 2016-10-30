using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public static class Extensions
    {
        public static IEnumerable<T> ToConsole<T>(this IEnumerable<T> source, Func<T, string> projector)
        {
            if (source.Count() != 0)
                foreach (var p in source)
                {
                    Console.WriteLine(projector(p));
                    yield return p;
                }
            else
            {
                Console.WriteLine("Аэропорт не имеет самолетов");
                yield break;
            }
        }
    }
}
