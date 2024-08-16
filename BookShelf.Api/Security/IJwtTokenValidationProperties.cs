using Microsoft.IdentityModel.Tokens;

namespace BookShelf.Api.Security;

internal interface IJwtTokenValidationProperties
{
    SecurityKey SecurityKey { get; }
    string Audience { get; }
    string Issuer { get; }
}