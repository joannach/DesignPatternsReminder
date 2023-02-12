using DesignPatternsReminder.OCPProduct;

namespace DesignPatternsReminder.Creational.BuilderRecursiveGeneric
{
    public class ProductColorBuilder<SELF> : ProductInfoBuilder<ProductColorBuilder<SELF>>
        where SELF : ProductColorBuilder<SELF>
    {
        public new Product product = new Product();
        public SELF ColourOfProcuct(Color color)
        {
            product.Color = color;
            return (SELF) this;
        }
    }
}
