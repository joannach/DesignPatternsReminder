using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsReminder.Creational.Builder
{
    public class HtmlBuilder
    {
        private readonly string rootName;

        public HtmlBuilder(string rootName)
        {
            this.rootName = rootName;
            root.Name = rootName;
        }

        public void AddChild(string childName, string childText)
        {
            var elem = new HtmlElement(childName, childText);
            root.Elements.Add(elem);
        }

        //Fluent interface
        public HtmlBuilder AddChildFluent(string childName, string childText)
        {
            var elem = new HtmlElement(childName, childText);
            root.Elements.Add(elem);
            return this;
        }

        public override string ToString()
        {
            return root.ToString();
        }

        public void Clear()
        {
            root = new HtmlElement { Name = rootName };
        }

        HtmlElement root = new HtmlElement();
    }
}
