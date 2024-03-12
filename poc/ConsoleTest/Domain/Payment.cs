namespace ConsoleTest.Domain;

internal sealed class Payment
{
    public required User Sender { get; init; }
    public required User Receiver { get; init; }
}