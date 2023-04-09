using BookShelf.Api.Requests.User;
using BookShelf.Api.Responses.User;

namespace BookShelf.Api.Security;

public interface ILoginService
{
    Task<LoginResponse?> LoginAsync(LoginRequest request);
}