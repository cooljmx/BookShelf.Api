namespace BookShelf.Api.Responses.User;

public sealed class LoginResponse
{
    public required string Token { get; init; }
}