using BookShelf.Api.Responses.Authors;
using Microsoft.AspNetCore.Mvc;

namespace BookShelf.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthorController : ControllerBase
{
    [HttpGet("all")]
    public AuthorCollectionResponse GetAuthorCollection()
    {
        var authorCollectionResponse = new AuthorCollectionResponse
        {
            Items = new[]
            {
                new AuthorResponse
                {
                    Id = 1,
                    FirstName = "William",
                    LastName = "Shakespeare",
                    BirthDate = new DateTime(1564, 04, 26)
                },
                new AuthorResponse
                {
                    Id = 2,
                    FirstName = "George",
                    LastName = "Shaw",
                    BirthDate = new DateTime(1856, 07, 26)
                }
            }
        };

        return authorCollectionResponse;
    }
}