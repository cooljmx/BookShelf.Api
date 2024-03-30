namespace BookShelf.Api.Responses.Authors;

public sealed class AuthorCollectionResponse
{
    public required IEnumerable<AuthorResponse> Items { get; init; }
}