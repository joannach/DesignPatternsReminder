using DesignPatternsReminder.OCPProduct;
using static System.Console;

namespace DesignPatternsReminder
{
    public class Program
    {
        public static void OCPProdDemo()
        {
            var apple = new Product("Apple", Color.Green, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Blue, Size.Large);

            Product[] products = { apple, tree, house };

            var productFilter = new ProductFilter();
            WriteLine("Old approach: ");
            WriteLine("Green products:");
            foreach (var p in productFilter.FilterByColor(products, Color.Green))
                WriteLine($" - {p.Name} is green");

            var ocpFilter = new OCPFilter();
            WriteLine("New approach: ");
            WriteLine("Green products:");
            foreach(var p in ocpFilter.Filter(products, new ColorSpecification(Color.Green)))
                WriteLine($" - {p.Name} is green");

            WriteLine("Large green products:");
            foreach (var p in ocpFilter.Filter(products, new AndSpecification<Product>(
                new ColorSpecification(Color.Green),
                new SizeSpecification(Size.Large))))
                WriteLine($" - {p.Name} is green");
        }
        static void Main(string[] args)
        {
            OCPProdDemo();
        }
    }
}
