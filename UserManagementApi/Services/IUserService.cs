using UserManagementApi.Models;

namespace UserManagementApi.Services;

public interface IUserService
{
    List<User> getAllUsers();
    User getUserById(int id);
    void createUser(User user);
    void updateUser(int id, User user);
    void deleteUser(int id);
}