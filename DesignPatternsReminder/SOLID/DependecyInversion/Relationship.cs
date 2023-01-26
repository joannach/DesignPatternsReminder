using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternsReminder.SOLID.DependecyInversion
{
    public class Relationship : IRelationshipBrowser
    {
        private List<(Person, RelationshipEnum, Person)> relations = new List<(Person, RelationshipEnum, Person)>();

        public void AddParentAndChild(Person parent, Person child)
        {
            relations.Add((parent, RelationshipEnum.Parent, child));
            relations.Add((child, RelationshipEnum.Child, parent));
        }

        public IEnumerable<Person> FindAllChildrenOf(string name)
        {
            return relations
                .Where(p => p.Item1.Name == name && p.Item2 == RelationshipEnum.Parent)
                .Select(p => p.Item3);
        }
    }
}
