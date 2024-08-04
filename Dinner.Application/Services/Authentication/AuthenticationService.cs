using Dinner.Application.Common.Interfaces;
using Dinner.Application.Services.Persistence;

namespace Dinner.Application.Services.Authentication;

public class AuthenticationService: IAuthenticationService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IUserRepository _userRepository;

    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
        _userRepository = userRepository;
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