using DesignPatternsReminder.Creational.BuilderRecursiveGeneric;
using System;
using System.Collections.Generic;

namespace DesignPatternsReminder.OCPProduct
{
    public enum Color
    {
        Red, Green, Blue
    }

    public enum Size
    {
        Small, Medium, Large, Yuge
    }

    public class Product
    {
        public string Name;
        public Color Color;
        public Size Size;

        public Product()
        {}

        public Product(string name, Color color, Size size)
        {
            Name = name ?? throw new ArgumentNullException(paramName: nameof(name));
            Color = color;
            Size = size;
        }

        public class Builder : ProductColorBuilder<Builder>
        {

        }

        public static Builder New => new Builder();

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Color)}: {Color}, {nameof(Size)}: {Size}";
        }
    }
}
