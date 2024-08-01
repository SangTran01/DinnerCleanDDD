using Dinner.Application.Services.Authentication;
using Dinner.Contracts.Authenticaton;
using Microsoft.AspNetCore.Mvc;

namespace Dinner.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthenticationController: ControllerBase
{
    private readonly IAuthenticationService _authenticationService;

    public AuthenticationController(IAuthenticationService authenticationService)
    {
        _authenticationService = authenticationService;
    }

    [HttpPost, Route("Register")]
    public IActionResult Register(RegisterRequest request)
    {
        var authResult = _authenticationService.Register(
            request.FirstName, 
            request.LastName, 
            request.Email, 
            request.Password);

        var authResponse = new AuthenticationResponse()
        {
            Id = authResult.Id
        };
        return Ok(authResponse);
    }
    
    [HttpPost, Route("Login")]
    public IActionResult Login(LoginRequest request)
    {
        var authResult = _authenticationService.Login(
            request.Email, 
            request.Password);
        
        var authResponse = new AuthenticationResponse()
        {
            Id = authResult.Id
        };
        return Ok(authResponse);
    }
}