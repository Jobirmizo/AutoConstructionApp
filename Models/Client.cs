using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoConstructionApp.Models;

public class Client
{
    [Key]
    public int Id { get; set; }
    public string Email { get; set; }
    public string Fname { get; set; }
    public string Lname { get; set; }
    public int PhoneNumber { get; set; }
    [ForeignKey("Location")]
    public int LocationId { get; set; }
    public string Image { get; set; }
    [ForeignKey("Vehicle")] 
    public int VehicleId { get; set; }
    [ForeignKey("Payment")]
    public int PaymentId { get; set; }
}