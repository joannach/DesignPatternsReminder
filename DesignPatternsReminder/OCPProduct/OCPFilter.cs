﻿using System.Collections.Generic;

namespace DesignPatternsReminder.OCPProduct
{
    public class OCPFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
        {
            foreach (var i in items)
                if (spec.IsSatisfied(i))
                    yield return i;

        }
    }
}
