using ErrorOr;
using Sample.Application.Services.Authentication.Common;

namespace Sample.Application.Services.Authentication.Commands;

public interface IAuthenticationCommandService
{
    ErrorOr<AuthenticationResult> Register(string firstName, string lastName, string email, string password);
}