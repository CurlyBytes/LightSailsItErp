namespace Domain.Warehouse.Rules
{
    public interface IHaveCodeNameRegexChecker
    {
        bool IsUnique(string codeName);
    }
}