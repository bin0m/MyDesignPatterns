using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDesignPatterns.HtmlBuilder;

namespace MyDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            (new RunHtmlBuilder()).Run();
            Console.ReadLine();
        }
    }
}
