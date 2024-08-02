using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Dinner.Application.Common.Interfaces;
using Microsoft.IdentityModel.Tokens;
using JwtRegisteredClaimNames = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames;

namespace Dinner.Infrastructure.Authentication;

public class JwtTokenGenerator: IJwtTokenGenerator
{
    public string GenerateToken(Guid userId, string firstName, string lastName)
    {
        var signingCredentials = new SigningCredentials(
            
            new SymmetricSecurityKey(Encoding.UTF8.GetBytes("super-secret-key-super-secret-key")), 
            SecurityAlgorithms.HmacSha256);

        var claims = new[]
        {
            new Claim(JwtRegisteredClaimNames.Sub, userId.ToString()),
            new Claim(JwtRegisteredClaimNames.GivenName, firstName),
            new Claim(JwtRegisteredClaimNames.FamilyName, lastName),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()) 
        };
 
        var securityToken = new JwtSecurityToken(
            claims:claims,
            issuer:"DinnerClean",
            expires: DateTime.Now.AddDays(1),
            signingCredentials:signingCredentials);

        return new JwtSecurityTokenHandler().WriteToken(securityToken);
    }
}