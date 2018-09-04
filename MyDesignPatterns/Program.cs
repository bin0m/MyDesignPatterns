using System;
using System.Collections.Generic;
using System.Linq;

namespace MyDesignPatterns
{


    class Program
    {
        public static IEnumerable<int> Square(IEnumerable<int> a)
        {
            foreach (var r in a)
            {
                Console.WriteLine(r * r);
                yield return r * r;
            }
        }

        class Wrap
        {
            private static int init = 0;
            public int Value
            {
                get { return ++init; }
            }
        }

        static void Main(string[] args)
        {
            //new HtmlBuilder.RunHtmlBuilder().Run();
            //new OpenClosedPrinciple.RunOpenClosedPrinciple().Run();
            new LiskovSubstitutionPrinciple.RunLiskovSubstitutionPrinciple().Run();


            var w = new Wrap();
            var wraps = new Wrap[3];
            for (int i = 0; i < wraps.Length; i++)
            {
                wraps[i] = w;
            }

            var values = wraps.Select(x => x.Value);
            var results = Square(values);
            int sum = 0;
            int count = 0;
            foreach (var r in results)
            {
                count++;
                sum += r;
            }
            Console.WriteLine("Count {0}", count);
            Console.WriteLine("Sum {0}", sum);

            Console.WriteLine("Count {0}", results.Count());
            Console.WriteLine("Sum {0}", results.Sum());


            Console.ReadLine();
        }
    }
}
