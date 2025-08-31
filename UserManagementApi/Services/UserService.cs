using UserManagementApi.Models;

namespace UserManagementApi.Services;

public class UserService : IUserService
{
    private static List<User> _users = [];
    
    public List<User> getAllUsers()
    {
        return _users;
    }

    public User getUserById(int id)
    {
        return _users.FirstOrDefault(u => u.Id == id);
    }

    public void createUser(User user)
    {
        user.Id = _users.Count == 0 ? 1 : _users[^1].Id + 1;
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