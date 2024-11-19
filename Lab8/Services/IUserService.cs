using Lab8.Models;

namespace Lab8.Services;

public interface IUserService
{
    public Task<User?> AuthenticateAsync(string email, string password);

    public Task<bool> RegisterAsync(User user);

    public Task<User?> GetByEmailAsync(string email);

    public Task<bool> UpdateAsync(User user);
}
