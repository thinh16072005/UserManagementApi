using Microsoft.AspNetCore.Mvc;
using UserManagementApi.Models;
using UserManagementApi.Services;

namespace UserManagementApi.Controller;

[ApiController]
[Route("api/[controller]")]
public class UserController(IUserService userService) : ControllerBase
{
    private readonly IUserService _userService = userService ?? throw new ArgumentNullException(nameof(userService));

    [HttpGet]
    public ActionResult<List<User>> GetAllUsers() => _userService.GetAllUsers() != null ? Ok(_userService.GetAllUsers()) : NotFound();
    
    [HttpGet("{id}")]
    public ActionResult<User> GetUserById(int id) => _userService.GetUserById(id) != null ? Ok(_userService.GetUserById(id)) : NotFound();

    [HttpPost]
    public ActionResult<User> CreateUser([FromBody] User user)
    {
        if (user is null) BadRequest();

        // Assign a simple in\-memory Id if missing
        if (user.Id <= 0)
        {
            var all = _userService.GetAllUsers();
            user.Id = all.Count == 0 ? 1 : all[^1].Id + 1;
        }

        _userService.CreateUser(user);

        return CreatedAtAction(nameof(GetUserById), new { id = user.Id }, user);
    }

    [HttpPut("{id}")]
    public ActionResult<User> UpdateUser(int id, User user)
    {
        if (_userService.GetUserById(id) == null) NotFound(); // Blank 4
        _userService.UpdateUser(id, user);
        return Ok();
    }

    [HttpDelete("{id}")]
    public ActionResult<User> DeleteUser(int id)
    {
        if (_userService.GetUserById(id) == null) NotFound(); // Blank 4
        _userService.DeleteUser(id);
        return NoContent();
    }
}