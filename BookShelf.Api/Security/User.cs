namespace BookShelf.Api.Security;

public class User
{
    public required string Email { get; init; }
    public required string PasswordHash { get; init; }
}