using System.ComponentModel.DataAnnotations;

namespace UserManagementApi.Models;

public class User
{
    [Required]
    private int Id { get; set; }
    
    [Required]
    private string Name { get; set; }
    
    [Required]
    [StringLength(10, ErrorMessage = "Phone number cannot exceed 10 digits")]
    private string Phone { get; set; }
    
    [Required]
    private DateOnly Birthdate { get; set; }
    
    [Required]
    private string Address { get; set; }
}