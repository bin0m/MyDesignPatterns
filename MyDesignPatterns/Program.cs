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
            //new Observer.RunUsingEventKeyword().Run();
            //new Observer.RunObserver().Run();
            //new Decorator.RunCustomStringBuilder().Run();
            //new Decorator.RunAdapterDecorator().Run();
            //new Decorator.RunRepositoryLogDecorator().Run();
            //new Bridge.RunRenderer().Run();
            new Visitor.RunClassicVisitor().Run();
            Console.ReadLine();
        }
    }
}
