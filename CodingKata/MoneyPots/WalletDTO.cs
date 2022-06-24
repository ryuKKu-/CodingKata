namespace CodingKata.MoneyPots;

public class WalletDTO
{
    public string Id { get; init; }

    public List<string> Owners { get; init; }
    
    public string Description { get; init; }

    public Money Balance { get; init; }
}

public record struct Money(string Currency, long Amount);