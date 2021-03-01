namespace Domain.WarehouseContext.Rules
{
    public interface IHaveCodeNameRegexChecker
    {
        bool IsUnique(string codeName);
    }
}