using DesignPatternsReminder.OCPProduct;

namespace DesignPatternsReminder.Creational.BuilderRecursiveGeneric
{
    public abstract class ProductBuilder
    {
        protected Product product = new Product();
        public Product Build()
        {
            return product;
        }
    }
}