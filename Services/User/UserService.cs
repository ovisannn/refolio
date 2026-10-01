using refolio.DTOs.User;
using Refolio.Persistence;

namespace refolio.Services.User;

public class UserService: IUserService
{
    private readonly AppDbContext _dbContext;
    private readonly ILogger<UserService> _logger;
    
    public UserService(AppDbContext dbContext, ILogger<UserService> logger)
    {
        _dbContext = dbContext;
    }

    public async Task CreateUser(CreateUserRequest request)
    {
        
    }
}