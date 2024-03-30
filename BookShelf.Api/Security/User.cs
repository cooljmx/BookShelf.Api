namespace BookShelf.Api.Security;

public sealed class User
{
    public required string Email { get; init; }
    public required string PasswordHash { get; init; }
}