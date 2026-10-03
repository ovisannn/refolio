using Refolio.DTOs.User.Request;
using Refolio.DTOs.User.Response;

namespace Refolio.Services.UserService;

public interface IUserService
{
    Task<UserResponse> RegisterUserAsync(RegisterUserRequest request);
}