using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoConstructionApp.Models;

public class Role
{
    [Key] 
    public int Id { get; set; }
    [ForeignKey("Client")]
    public int ClientId { get; set; }
    [ForeignKey("Employee")]
    public int EmployeeId { get; set; }
    
}