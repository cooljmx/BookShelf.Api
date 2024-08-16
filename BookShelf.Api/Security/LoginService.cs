using BookShelf.Api.Requests.User;
using BookShelf.Api.Responses.User;
using Microsoft.AspNetCore.Identity;

namespace BookShelf.Api.Security;

internal sealed class LoginService : ILoginService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly UserManager<User> _userManager;

    public LoginService(UserManager<User> userManager,
        IJwtTokenGenerator jwtTokenGenerator)
    {
        _userManager = userManager;
        _jwtTokenGenerator = jwtTokenGenerator;
    }

    public async Task<LoginResponse?> LoginAsync(LoginRequest request)
    {
        var user = await _userManager.FindByEmailAsync(request.Email);

        if (user == null)
            return null;

        var isPasswordValid = await _userManager.CheckPasswordAsync(user, request.Password);

        if (!isPasswordValid)
            return null;

        return new LoginResponse
        {
            Token = _jwtTokenGenerator.Generate(user.Email)
        };
    }
}