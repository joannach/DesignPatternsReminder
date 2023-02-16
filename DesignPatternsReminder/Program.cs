using DesignPatternsReminder.Creational.Builder;
using DesignPatternsReminder.Creational.Builder.FacetedBuilder;
using DesignPatternsReminder.Creational.Builder.FunctionalBuilder;
using DesignPatternsReminder.Creational.Factory;
using DesignPatternsReminder.OCPProduct;
using DesignPatternsReminder.SOLID.DependecyInversion;
using DesignPatternsReminder.SOLID.Liskov;
using System;
using static System.Console;

namespace DesignPatternsReminder
{
    public class Program
    {
        static void Main(string[] args)
        {
            PointFactoryMethod();
        }

        public static void PointFactoryMethod()
        {
            var point = Point.NewPolarPoint(2, 5);
            WriteLine(point);
        }

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

        public static void Liskov()
        {
            var countArea = new Area();
            var rect = new Rectangle(3, 5);

            WriteLine($"{rect}");
            WriteLine($"Area: {countArea.GetArea(rect)}");

            Rectangle square = new Square();
            square.Width = 7;
            WriteLine($"{square}");
            WriteLine($"Area: {countArea.GetArea(square)}");
        }

        public static void DependencyInversion()
        {
            var parent = new Person { Name = "Konstantyn" };
            var child1 = new Person { Name = "Dzesika" };
            var child2 = new Person { Name = "Borys" };

            // low-level module
            var relationships = new Relationship();
            relationships.AddParentAndChild(parent, child1);
            relationships.AddParentAndChild(parent, child2);

            new Reaserch(relationships);
        }

        public static void Builder()
        {
            var elemTest = new HtmlBuilder("asia");
            elemTest.AddChildFluent("div", "some text in div");
            elemTest.AddChildFluent("p", "title in p").AddChildFluent("a", "b");
            WriteLine(elemTest.ToString());
        }

        public static void BuilderRecursiveGeneric()
        {
            WriteLine(Product.New
                .ColourOfProcuct(Color.Blue)
                .ProductInfoBuild("TestProd", Size.Large)
                .Build()
                .ToString());
        }

        public static void BuilderFunctional()
        {
            var mealBuilder = new MealBuilder();

            WriteLine(mealBuilder
                .ClassifyByType("Cake")
                .PreparesIn(30)
                .Build()
                .ToString());
        }

        public static void BuilderFacadePerson()
        {
            var personBuilder = new PersonBuilder();

            //explicit
            Person person = (Person)personBuilder
                .Works
                    .AtCompany("Microsoft")
                    .AsA("Developer")
                    .WithSalary(123456)
                .Lives
                    .In("Poznan")
                    .WithPostCode("343534")
                    .ByStreet("Created 1");

            WriteLine(person.ToString());
        }
    }
}
