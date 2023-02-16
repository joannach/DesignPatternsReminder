using DesignPatternsReminder.SOLID.DependecyInversion;

namespace DesignPatternsReminder.Creational.Builder.FacetedBuilder
{
    public class PersonJobBuilder : PersonBuilder
    {
        public PersonJobBuilder(Person person)
        {
            this.Person = person;
        }

        public PersonJobBuilder AtCompany(string companyName)
        {
            Person.CompanyName = companyName;
            return this;
        }

        public PersonJobBuilder AsA(string position)
        {
            Person.Position = position;
            return this;
        }

        public PersonJobBuilder WithSalary(int annualIncome)
        {
            Person.AnnulIncome = annualIncome;
            return this;
        }
    }
}
