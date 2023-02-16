using DesignPatternsReminder.SOLID.DependecyInversion;

namespace DesignPatternsReminder.Creational.Builder.FacetedBuilder
{
    public class PersonLivesBuilder : PersonBuilder
    {
        public PersonLivesBuilder(Person person)
        {
            this.Person = person;
        }

        public PersonLivesBuilder ByStreet(string street)
        {
            Person.Street = street;
            return this;
        }

        public PersonLivesBuilder WithPostCode(string postCode)
        {
            Person.PostCode = postCode;
            return this;
        }

        public PersonLivesBuilder In(string city)
        {
            Person.City = city;
            return this;
        }
    }
}
