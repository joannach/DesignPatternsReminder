using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsReminder.SOLID.DependecyInversion
{
    public interface IRelationshipBrowser
    {
        IEnumerable<Person> FindAllChildrenOf(string name);
    }
}
