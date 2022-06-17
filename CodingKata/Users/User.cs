namespace CodingKata.Users;

public class User
{
    private readonly List<User> _friends = new();

    public IEnumerable<User> GetFriends()
    {
        return _friends;
    }

    public void AddFriend(User friend)
    {
        _friends.Add(friend);
    }
}