namespace BookShelf.Api.Security;

internal interface IJwtTokenGenerator
{
    string Generate(string email);
}