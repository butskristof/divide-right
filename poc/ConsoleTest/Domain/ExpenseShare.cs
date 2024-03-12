namespace ConsoleTest.Domain;

internal sealed class ExpenseShare
{
    public decimal Amount { get; set; }
    public required User User { get; set; }
}