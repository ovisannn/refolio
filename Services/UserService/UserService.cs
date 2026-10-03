using Refolio.DTOs.User.Request;
using Refolio.DTOs.User.Response;
using Refolio.Persistence;
using Refolio.Models;

namespace Refolio.Services.UserService;

public class UserService: IUserService
{
    private readonly AppDbContext _dbContext;
    private readonly ILogger<UserService> _logger;
    
    public UserService(AppDbContext dbContext, ILogger<UserService> logger)
    {
        _dbContext = dbContext;
        _logger = logger;
    }

    public async Task<UserResponse> RegisterUserAsync(RegisterUserRequest request)
    {
        var user = User.Create(request.Username, request.Password, request.PasswordSalt, request.Email);
        await _dbContext.AddAsync(user);
        await _dbContext.SaveChangesAsync();
        
        return new UserResponse(user.Username, user.Email);
    }
}  