using Dinner.Domain.Entities;

namespace Dinner.Application.Services.Persistence;

public interface IUserRepository
{
    public User? GetUserByEmail(string email);
    void AddUser(User user); 
}