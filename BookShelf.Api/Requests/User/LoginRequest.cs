namespace BookShelf.Api.Requests.User;

public sealed class LoginRequest
{
    public required string Email { get; init; }
    public required string Password { get; init; }
}