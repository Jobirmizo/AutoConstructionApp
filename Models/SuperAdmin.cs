using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoConstructionApp.Models;

public class SuperAdmin
{
    [Key]
    public int Id { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    [ForeignKey("Role")]
    public int RoleId { get; set; }
    [ForeignKey("Vehicle")]
    public int VehicleId { get; set; }
    [ForeignKey("Payment")]
    public int PaymentId { get; set; }
}