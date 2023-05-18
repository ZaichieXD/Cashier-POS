using System.ComponentModel.DataAnnotations;
namespace Cashier_POS.Models;

public class UserModel
{
    [Key]
    public int EmployeeId { get; set; }
    [Required]
    public string? UserName { get; set; }
    [Required]
    public string? Password { get; set; }
}