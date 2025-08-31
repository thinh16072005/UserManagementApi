using System.ComponentModel.DataAnnotations;

namespace UserManagementApi.Models;

public class User
{
    public required int Id { get; set; }
    
    public required string Name { get; set; }
    
    [StringLength(10, ErrorMessage = "Phone number cannot exceed 10 digits")]
    public string Phone { get; set; }
    
    private string Address { get; set; }

    public override string ToString()
    {
        return $"User {Id}, {Name}, {Phone}, {Address}";
    }
}