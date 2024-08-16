using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace BookShelf.Api.Security;

internal sealed class JwtTokenValidationProperties : IJwtTokenValidationProperties
{
    private const string SecretKey = "Ry$@X2m1hY6T!gZq8K&*7DsLPw3NvFV4Wc*Jl0k?B@I9UQGzEa+-bHxfdS5rtO";

    public JwtTokenValidationProperties()
    {
        var secretKeyBytes = Encoding.UTF8.GetBytes(SecretKey);

        SecurityKey = new SymmetricSecurityKey(secretKeyBytes);
        Audience = "BookShelf";
        Issuer = "DevTricks";
    }

    public SecurityKey SecurityKey { get; }
    public string Audience { get; }
    public string Issuer { get; }
}