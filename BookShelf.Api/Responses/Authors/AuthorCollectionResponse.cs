namespace BookShelf.Api.Responses.Authors;

public class AuthorCollectionResponse
{
    public IEnumerable<AuthorResponse> Items { get; init; }
}