namespace Dinner.Infrastructure.Authentication;

public class JwtSettings 
{
    public const string SectionString = "JwtSettings";
    public string Secret { get; set; } = null!;
    public int ExpiryMinutes { get; set; }
    public string Issuer { get; set; } = null!;
    public string Audience { get; set; } = null!; 
}