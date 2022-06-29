using CodingKata.MoneyPots;
using NUnit.Framework;

namespace CodingKata.Tests
{
    public class WalletServiceTest
    {
        [Test]
        public async void TestSomething()
        {
            var mpService = new MoneyPotService();
            var r = await mpService.GetWalletDetails(123);
        }
    }
}