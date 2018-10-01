using System;
using System.Collections.Generic;
using System.Linq;

namespace MyDesignPatterns
{
    class Program
    {       
        static void Main(string[] args)
        {
            //new HtmlBuilder.RunHtmlBuilder().Run();
            //new OpenClosedPrinciple.RunOpenClosedPrinciple().Run();
            //new LiskovSubstitutionPrinciple.RunLiskovSubstitutionPrinciple().Run();
            new Observer.RunUsingEventKeyword().Run();
            Console.ReadLine();
        }
    }
}
