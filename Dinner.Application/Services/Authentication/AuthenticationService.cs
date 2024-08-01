namespace Dinner.Application.Services.Authentication;

public class AuthenticationService: IAuthenticationService
{
    public AuthenticationResult Login(string email, string password)
    {
        return new AuthenticationResult()
        {
            Id = Guid.NewGuid()
        };
    }

    public AuthenticationResult Register(string firstName, string lastName,  string email, string password)
    {
        return new AuthenticationResult()
        {
            Id = Guid.NewGuid()
        };
    }
}