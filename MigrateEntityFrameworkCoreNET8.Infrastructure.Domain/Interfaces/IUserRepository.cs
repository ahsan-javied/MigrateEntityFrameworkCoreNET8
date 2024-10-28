using MigrateEntityFrameworkCoreNET8.Infrastructure.Domain.DTOs;
using MigrateEntityFrameworkCoreNET8.Infrastructure.Domain.Models;

namespace MigrateEntityFrameworkCoreNET8.Infrastructure.Domain.Interfaces
{
    public interface IUserRepository : IService
    {
        Task<List<UserDto>> GetUserDtosAsync();

        Task<List<User>> GetAllActiveUsersAsync();
        Task<List<User>> LoadUsersWithOrdersAsync();

        Task SaveAsync(User user);
    }
}
