using Lab8.Models;

namespace Lab8.Services.Implementations;

internal class UserService(IPasswordEncryptionService encryptionService) : IUserService
{
    private readonly IPasswordEncryptionService _encryptionService = encryptionService;
    private readonly List<User> _users =
    [
        new User
        {
            FirstName = "John",
            LastName = "Doe",
            Email = "john.doe@example.com",
            DateOfBirth = new DateTime(1990, 1, 1),
            PasswordHash = "hashedPassword1",
            LastLoginAt = DateTimeOffset.MinValue,
            FailedLoginAttempts = 0
        },
        new User
        {
            FirstName = "Jane",
            LastName = "Smith",
            Email = "jane.smith@example.com",
            DateOfBirth = new DateTime(1992, 5, 15),
            PasswordHash = "hashedPassword2",
            LastLoginAt = DateTimeOffset.MinValue,
            FailedLoginAttempts = 1
        }
    ];


    public Task<User?> AuthenticateAsync(string email, string password)
    {
        var passwordHash = _encryptionService.EncryptPassword(password);
        return Task.FromResult(_users.FirstOrDefault(u => u.Email == email && u.PasswordHash == passwordHash));
    }


    public Task<bool> RegisterAsync(User user)
    {
        if (_users.Any(u => u.Email == user.Email))
        {
            return Task.FromResult(false);
        }

        _users.Add(user with
        {
            PasswordHash = _encryptionService.EncryptPassword(user.PasswordHash)
        });
        return Task.FromResult(true);
    }


    public Task<User?> GetByEmailAsync(string email)
    {
        return Task.FromResult(_users.FirstOrDefault(m => m.Email == email));
    }


    public Task<bool> UpdateAsync(User user)
    {
        var index = _users.FindIndex(m => m.Id == user.Id);
        if (index == -1)
        {
            return Task.FromResult(false);
        }

        _users[index] = user;
        return Task.FromResult(true);
    }
}
