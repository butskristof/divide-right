namespace ConsoleTest.Domain;

internal sealed class Expense
{
    public required User Owner { get; init; }
    public IEnumerable<ExpenseShare> Shares { get; set; } = [];
    public decimal Amount => Shares.Sum(s => s.Amount);
}