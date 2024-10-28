using MigrateEntityFrameworkCoreNET8.Infrastructure.Domain.Models;

namespace MigrateEntityFrameworkCoreNET8.Infrastructure.Domain.Interfaces;

public interface IUserService : IService
{
    Task<List<User>> GetAllActiveUsersAsync();
}
