using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDesignPatterns.HtmlBuilder
{
    public class RunHtmlBuilder : IRunInConsole
    {
        public void Run()
        {
            var htmlBuilder = new HtmlBuilder("ul");
            htmlBuilder.AddChild("li", "hello").AddChild("li", "world");
            Console.WriteLine(htmlBuilder);
        }
    }
}