using UserManagementApi.Models;

namespace UserManagementApi.Services;

public class UserService : IUserService
{
    private static List<User> _users = [];
    
    public List<User> GetAllUsers()
    {
        return _users;
    }

    public User GetUserById(int id)
    {
        return _users.FirstOrDefault(u => u.Id == id);
    }

    public void CreateUser(User user)
    {
        user.Id = _users.Count == 0 ? 1 : _users[^1].Id + 1;
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