namespace DesignPatternsReminder.OCPProduct
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T t);
    }
}
