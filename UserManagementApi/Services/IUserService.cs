using UserManagementApi.Models;

namespace UserManagementApi.Services;

public interface IUserService
{
    List<User> GetAllUsers();
    User GetUserById(int id);
    void CreateUser(User user);
    void UpdateUser(int id, User user);
    void DeleteUser(int id);
}