namespace BookShelf.Api.Responses.Authors;

public class AuthorResponse
{
    public int Id { get; init; }
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public DateTime BirthDate { get; init; }
}