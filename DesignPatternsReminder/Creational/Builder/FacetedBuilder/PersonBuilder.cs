using DesignPatternsReminder.SOLID.DependecyInversion;
using System.Text;

namespace DesignPatternsReminder.Creational.Builder.FacetedBuilder
{
    //facade
    public class PersonBuilder
    {
        protected Person Person = new Person();

        public PersonJobBuilder Works => new PersonJobBuilder(Person);
        public PersonLivesBuilder Lives => new PersonLivesBuilder(Person);

        //public static implicit operator Person(PersonBuilder personBuilder)
        //{
        //    return personBuilder.Person;
        //}

        public static explicit operator Person(PersonBuilder personBuilder)
        {
            return personBuilder.Person;
        }
    }
}
