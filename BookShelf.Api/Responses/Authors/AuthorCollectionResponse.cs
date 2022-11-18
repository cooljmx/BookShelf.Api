namespace BookShelf.Api.Responses.Authors;

public class AuthorCollectionResponse
{
    public required IEnumerable<AuthorResponse> Items { get; init; }
}