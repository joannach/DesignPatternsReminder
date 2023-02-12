using DesignPatternsReminder.OCPProduct;

namespace DesignPatternsReminder.Creational.BuilderRecursiveGeneric
{
    public class ProductInfoBuilder<SELF> : ProductBuilder
        where SELF : ProductInfoBuilder<SELF>
    {
        public SELF ProductInfoBuild(string name, Size size)
        {
            product.Name = name;
            product.Size = size;
            return (SELF)this;
        }
    }
}
