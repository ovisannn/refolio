namespace Refolio.DTOs.User.Request;

public record RegisterUserRequest(string Username, string Password, string PasswordSalt, string Email);