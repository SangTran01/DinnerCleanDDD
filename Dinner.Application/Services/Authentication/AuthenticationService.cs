using Dinner.Application.Common.Interfaces;

namespace Dinner.Application.Services.Authentication;

public class AuthenticationService: IAuthenticationService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;

    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
    }
    public AuthenticationResult Login(string email, string password)
    {
        return new AuthenticationResult()
        {
            Id = Guid.NewGuid()
        };
    }

    public AuthenticationResult Register(string firstName, string lastName,  string email, string password)
    {
        //check if user already reg 
        var newGuid = Guid.NewGuid();
        string token = _jwtTokenGenerator.GenerateToken(newGuid, firstName, lastName);
        return new AuthenticationResult()
        {
            Id = newGuid,
            FirstName = firstName,
            LastName = lastName,
            Email = email,
            Token = token
        };
    }
}