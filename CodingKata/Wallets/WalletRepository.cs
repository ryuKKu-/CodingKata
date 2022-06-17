using CodingKata.Exceptions;
using CodingKata.Users;

namespace CodingKata.Wallets;

public class WalletRepository
{
    public static List<Wallet> FindWalletsByUser(User user)
    {
        throw new ThisIsAStubException("WalletRepository.FindWalletsByUser() should not be called in an unit test");
    }
}