namespace Refolio.DTOs.User.Request;

public record ChangePasswordRequest(string OldPassword, string NewPassword);