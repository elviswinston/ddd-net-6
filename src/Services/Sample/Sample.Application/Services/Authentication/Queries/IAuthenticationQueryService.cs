using ErrorOr;
using Sample.Application.Services.Authentication.Common;

namespace Sample.Application.Services.Authentication.Queries;

public interface IAuthenticationQueryService
{
    ErrorOr<AuthenticationResult> Login(string email, string password);
}