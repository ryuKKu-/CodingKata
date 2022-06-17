using CodingKata.Exceptions;
using CodingKata.Users;

namespace CodingKata.Wallets
{
    public class WalletService
    {
        public List<Wallet> GetWalletsByUser(User user)
        {
            List<Wallet> walletList = new List<Wallet>();
            User currentUser = UserSession.GetInstance().GetLoggedUser();
            bool isFriend = false;

            if (currentUser != null)
            {
                foreach (User friend in user.GetFriends())
                {
                    if (friend.Equals(currentUser))
                    {
                        isFriend = true;
                        break;
                    }
                }

                if (isFriend)
                {
                    walletList = WalletRepository.FindWalletsByUser(user);
                }

                return walletList;
            }
            else
            {
                throw new UserNotLoggedInException();
            }
        }
    }
}