using Microsoft.AspNetCore.Mvc;
using Sample.Application.Services.Authentication.Commands;
using Sample.Application.Services.Authentication.Common;
using Sample.Application.Services.Authentication.Queries;
using Sample.Contracts.Authentication;

namespace Sample.API.Controllers;

[Route("auth")]
public class AuthenticationController : ApiController
{
    private readonly IAuthenticationCommandService _authenticationCommandService;
    private readonly IAuthenticationQueryService _authenticationQueryService;

    public AuthenticationController(
        IAuthenticationCommandService authenticationCommandService,
        IAuthenticationQueryService authenticationQueryService)
    {
        _authenticationCommandService = authenticationCommandService;
        _authenticationQueryService = authenticationQueryService;
    }

    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request)
    {
        var authResult = _authenticationCommandService.Register(request.FirstName, request.LastName, request.Email, request.Password);

        return authResult.Match(
            authResult => Ok(MathAuthResult(authResult)),
            errors => Problem(errors)
        );
    }

    private static AuthenticationResponse MathAuthResult(AuthenticationResult authResult)
    {
        return new AuthenticationResponse(
            authResult.User.Id,
            authResult.User.FirstName,
            authResult.User.LastName,
            authResult.User.Email,
            authResult.Token
        );
    }

    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {
        var authResult = _authenticationQueryService.Login(request.Email, request.Password);

        return authResult.Match(
            authResult => Ok(MathAuthResult(authResult)),
            errors => Problem(errors)
        );
    }
}