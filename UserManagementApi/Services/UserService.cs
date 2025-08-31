using UserManagementApi.Models;

namespace UserManagementApi.Services;

public class UserService : IUserService
{
    private readonly List<User> _users = [];
    
    public List<User> getAllUsers()
    {
        return _users;
    }

    public User getUserById(int id)
    {
        return _users[id];
    }

    public void createUser(User user)
    {
        _users.Add(user);
    }

    public void updateUser(int id, User user)
    {
        _users[id] = user;
    }

    public void deleteUser(int id)
    {
        _users.RemoveAt(id);
    }
}