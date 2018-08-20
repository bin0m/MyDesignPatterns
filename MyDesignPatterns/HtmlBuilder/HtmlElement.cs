using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDesignPatterns.HtmlBuilder
{
    public class HtmlElement
    {
        public string Name, Text;

        private const int identSize = 2;

        public List<HtmlElement> childElements = new List<HtmlElement>();

        public HtmlElement()
        {
        }


        public HtmlElement(string name, string text)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Text = text ?? throw new ArgumentNullException(nameof(text));
        }


        public string ToStringImpl(int idents)
        {
            var sb = new StringBuilder();
            var identPrefix = new String(' ', identSize * idents);
            sb.AppendLine($"{identPrefix}<{Name}>");
            if (!string.IsNullOrEmpty(Text))
            {
                sb.AppendLine($"{new String(' ', identSize * (idents + 1))}{Text}");
            }

            foreach (var child in childElements)
            {
                sb.Append(child.ToStringImpl(idents + 1));
            }
            sb.AppendLine($"{identPrefix}</{Name}>");
            return sb.ToString();
        }
        public override string ToString()
        {
            return ToStringImpl(0);
        }
    }
}
