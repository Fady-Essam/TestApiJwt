using TestApiJwt.Models;

namespace TestApiJwt.Services;
public interface IAuthService
{
    Task<AuthModel> RegisterAsync(RegisterModel model);
}
