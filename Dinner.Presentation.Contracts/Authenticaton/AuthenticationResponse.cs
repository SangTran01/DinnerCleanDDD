﻿namespace Dinner.Contracts.Authenticaton;

public class AuthenticationResponse
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Token { get; set; }
}