namespace DesignPatternsReminder.SOLID.DependecyInversion
{
    public class Person
    {
        public string Name { get; set; }

        //address
        public string Street { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }

        //amployment
        public string CompanyName { get; set; }
        public string Position { get; set; }
        public int AnnulIncome { get; set; }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Street)}: {Street}, {nameof(PostCode)}: {PostCode}, {nameof(City)}: {City}," +
                $"{nameof(CompanyName)}: {CompanyName}, {nameof(Position)}: {Position}, {nameof(AnnulIncome)}: {AnnulIncome} ";
        }
    }
}
