using System;


namespace MyDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //new HtmlBuilder.RunHtmlBuilder().Run();
            //new OpenClosedPrinciple.RunOpenClosedPrinciple().Run();
            new LiskovSubstitutionPrinciple.RunLiskovSubstitutionPrinciple().Run();

            Console.ReadLine();
        }
    }
}
