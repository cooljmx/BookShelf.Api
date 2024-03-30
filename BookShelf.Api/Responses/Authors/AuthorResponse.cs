namespace BookShelf.Api.Responses.Authors;

public sealed class AuthorResponse
{
    public required int Id { get; init; }
    public required string FirstName { get; init; }
    public required string LastName { get; init; }
    public required DateOnly BirthDate { get; init; }
}