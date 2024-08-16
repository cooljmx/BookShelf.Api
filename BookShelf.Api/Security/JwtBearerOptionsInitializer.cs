using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace BookShelf.Api.Security;

internal sealed class JwtBearerOptionsInitializer : IPostConfigureOptions<JwtBearerOptions>
{
    private readonly IJwtTokenValidationProperties _jwtTokenValidationProperties;

    public JwtBearerOptionsInitializer(IJwtTokenValidationProperties jwtTokenValidationProperties)
    {
        _jwtTokenValidationProperties = jwtTokenValidationProperties;
    }

    public void PostConfigure(string? name, JwtBearerOptions options)
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateLifetime = true,
            RequireAudience = true,
            ValidateAudience = true,
            ValidateIssuer = true,
            ValidAudience = _jwtTokenValidationProperties.Audience,
            ValidIssuer = _jwtTokenValidationProperties.Issuer,
            IssuerSigningKey = _jwtTokenValidationProperties.SecurityKey
        };
    }
}