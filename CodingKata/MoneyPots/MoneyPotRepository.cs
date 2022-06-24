using CodingKata.Exceptions;
using CodingKata.Users;

namespace CodingKata.MoneyPots;

public class MoneyPotRepository
{
    public static List<MoneyPot> FindMoneyPotsByUser(User user)
    {
        throw new ThisIsAStubException($"{nameof(FindMoneyPotsByUser)} should not be called in an unit test");
    }
}