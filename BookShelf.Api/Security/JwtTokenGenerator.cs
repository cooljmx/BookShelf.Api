using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;

namespace BookShelf.Api.Security;

internal sealed class JwtTokenGenerator : IJwtTokenGenerator
{
    private readonly IJwtTokenValidationProperties _jwtTokenValidationProperties;

    public JwtTokenGenerator(IJwtTokenValidationProperties jwtTokenValidationProperties)
    {
        _jwtTokenValidationProperties = jwtTokenValidationProperties;
    }

    public string Generate(string email)
    {
        var signingCredentials = new SigningCredentials(_jwtTokenValidationProperties.SecurityKey,
            SecurityAlgorithms.HmacSha256Signature);

        var securityTokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity([
                new Claim(ClaimTypes.Email, email),
                new Claim("tvr", "1", ClaimValueTypes.Integer)
            ]),
            Expires = DateTime.UtcNow.AddDays(1),
            SigningCredentials = signingCredentials,
            Audience = _jwtTokenValidationProperties.Audience,
            Issuer = _jwtTokenValidationProperties.Issuer
        };

        var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
        var securityToken = jwtSecurityTokenHandler.CreateToken(securityTokenDescriptor);
        var tokenValue = jwtSecurityTokenHandler.WriteToken(securityToken);

        return tokenValue;
    }
}