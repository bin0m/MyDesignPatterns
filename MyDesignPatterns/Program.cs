using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var htmlBuilder = new HtmlBuilder.HtmlBuilder("ul");
            htmlBuilder.AddChild("li","hello");
            htmlBuilder.AddChild("li","world");
            Console.WriteLine(htmlBuilder);
            Console.ReadLine();
        }
    }
}
