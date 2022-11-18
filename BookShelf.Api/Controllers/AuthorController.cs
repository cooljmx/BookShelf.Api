using BookShelf.Api.Responses.Authors;
using Microsoft.AspNetCore.Mvc;

namespace BookShelf.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthorController : ControllerBase
{
    [HttpGet]
    [Route("all")]
    public AuthorCollectionResponse GetAuthorCollection()
    {
        return new AuthorCollectionResponse
        {
            Items = new[]
            {
                new AuthorResponse
                {
                    Id = 1,
                    FirstName = "William",
                    LastName = "Shakespeare",
                    BirthDate = new DateOnly(1564, 04, 26)
                },
                new AuthorResponse
                {
                    Id = 2,
                    FirstName = "George",
                    LastName = "Show",
                    BirthDate = new DateOnly(1856, 07, 26)
                }
            }
        };
    }
}