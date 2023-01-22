using System.Collections.Generic;

namespace DesignPatternsReminder.OCPProduct
{
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
    }
}
