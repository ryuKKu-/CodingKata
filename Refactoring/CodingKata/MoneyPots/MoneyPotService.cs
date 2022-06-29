using System.Net.Http.Headers;
using System.Text.Json;
using CodingKata.Exceptions;
using CodingKata.Users;

namespace CodingKata.MoneyPots;

public class MoneyPotService
{
    public List<MoneyPot> GetWalletsByUser(User user)
    {
        var moneyPots = new List<MoneyPot>();
        var currentUser = UserSession.GetInstance().GetLoggedUser();
        var isFriend = false;

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
                moneyPots = MoneyPotRepository.FindMoneyPotsByUser(user);
            }

            return moneyPots;
        }
        else
        {
            throw new UserNotLoggedInException();
        }
    }

    public async Task<WalletDTO?> GetWalletDetails(int moneyPotId)
    {
        var httpClient = new HttpClient
        {
            BaseAddress = new Uri("https://api.sandbox.mangopay.com/"),
        };

        var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, "/oauth/token/")
        {
            Content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("grant_type", "client_credentials")
            }),
            Headers = { { "Authorization", "Basic czZCaGRSa3F0MzpnWDFmQmF0M2JW" } }
        };

        var loginResult = await httpClient.SendAsync(httpRequestMessage);
        var token = JsonSerializer.Deserialize<Token>(await loginResult.Content.ReadAsStringAsync());

        httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.AccessToken);
        var result = await httpClient.GetAsync($"/v2.01/leetchi/wallets/{moneyPotId}");
        var content = await result.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<WalletDTO>(content);
    }
}