using CodingKata.Exceptions;

namespace CodingKata.Users;

public class UserSession
{
    private static readonly UserSession Session = new();

    private UserSession() { }

    public static UserSession GetInstance()
    {
        return Session;
    }

    public User GetLoggedUser()
    {
        throw new ThisIsAStubException("UserSession.IsUserLoggedIn() should not be called in an unit test");
    }
}