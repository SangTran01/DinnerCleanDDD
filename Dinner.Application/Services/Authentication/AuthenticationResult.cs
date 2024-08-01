namespace Dinner.Application.Services.Authentication;

public class AuthenticationResult
{
    public Guid Id { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
    string Email { get; set; }
    string Token { get; set; }
}