using Sample.Domain.Entities;

namespace Sample.Application.Services.Authentication.Common;

public record AuthenticationResult(
    User User,
    string Token
);