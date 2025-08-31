using UserManagementApi.Models;

namespace UserManagementApi.Services;

public class UserService : IUserService
{
    private readonly List<User> _users = [];
    
    public List<User> GetAllUsers()
    {
        return _users;
    }

    public User GetUserById(int id)
    {
        return _users[id];
    }

    public void CreateUser(User user)
    {
        _users.Add(user);
    }

    public void UpdateUser(int id, User user)
    {
        _users[id] = user;
    }

    public void DeleteUser(int id)
    {
        _users.RemoveAt(id);
    }
}